using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SwissEphNet;
using microcosm.Config;

namespace microcosm.Calc
{
    public class AstroCalc
    {
        public ConfigData config;
        public double year_days = 365.2424;
        public SwissEph s;

        public AstroCalc(ConfigData config)
        {
            this.config = config;
            s = new SwissEph();
            // http://www.astro.com/ftp/swisseph/ephe/archive_zip/ からDL
            s.swe_set_ephe_path(config.ephepath);
            s.OnLoadFile += (sender, ev) => {
                if (File.Exists(ev.FileName))
                    ev.File = new FileStream(ev.FileName, FileMode.Open);
            };
        }

        // 天体の位置を計算する
        public List<PlanetData> PositionCalc(int year, int month, int day, int hour, int min, double sec, double lat, double lng)
        {
            List<PlanetData> planetdata = new List<PlanetData>(); ;

            // absolute position
            double[] x = { 0, 0, 0, 0, 0, 0 };
            string serr = "";

            int utc_year = 0;
            int utc_month = 0;
            int utc_day = 0;
            int utc_hour = 0;
            int utc_minute = 0;
            double utc_second = 0;

            // [0]:Ephemeris Time [1]:Universal Time
            double[] dret = {0.0, 0.0};

            // utcに変換
            s.swe_utc_time_zone(year, month, day, hour, min, sec, 9.0, ref utc_year, ref utc_month, ref utc_day, ref utc_hour, ref utc_minute, ref utc_second);
            s.swe_utc_to_jd(utc_year, utc_month, utc_day, utc_hour, utc_minute, utc_second, 1, dret, ref serr);

            // 10天体ループ
            Enumerable.Range(0, 10).ToList().ForEach(i =>
            {
                int flag = SwissEph.SEFLG_SWIEPH | SwissEph.SEFLG_SPEED;
                if (config.centric == ECentric.HELIO_CENTRIC)
                    flag |= SwissEph.SEFLG_HELCTR;
                if (config.sidereal == Esidereal.SIDEREAL)
                {
                    flag |= SwissEph.SEFLG_SIDEREAL;
                    s.swe_set_sid_mode(SwissEph.SE_SIDM_LAHIRI, 0, 0);
                    // ayanamsa計算
                    double daya = 0.0;
                    double ut = s.swe_get_ayanamsa_ex_ut(dret[1], SwissEph.SEFLG_SWIEPH, out daya, ref serr);

                    // Ephemeris Timeで計算, 結果はxに入る
                    s.swe_calc_ut(dret[1], i, flag, x, ref serr);
                    // tropicalからayanamsaをマイナス
                    if (x[0] > daya)
                    {
                        x[0] -= daya;
                    }
                    else
                    {
                        x[0] = x[0] - daya + 360;
                    }
                }
                else
                {
                    // Universal Timeで計算, 結果はxに入る
                    s.swe_calc_ut(dret[1], i, flag, x, ref serr);
                }


                PlanetData p = new PlanetData() { no = i, absolute_position = x[0], speed = x[3], aspects = new List<Aspect>() };
                planetdata.Add(p);
            });

            s.swe_close();
            return planetdata;
        }

        // カスプを計算
        public double[] CuspCalc(int year, int month, int day, int hour, int min, double sec, double lat, double lng)
        {
            int utc_year = 0;
            int utc_month = 0;
            int utc_day = 0;
            int utc_hour = 0;
            int utc_minute = 0;
            double utc_second = 0;
            string serr = "";
            // [0]:Ephemeris Time [1]:Universal Time
            double[] dret = { 0.0, 0.0 };

            SwissEph s = new SwissEph();

            // utcに変換
            s.swe_utc_time_zone(year, month, day, hour, min, sec, 9.0, ref utc_year, ref utc_month, ref utc_day, ref utc_hour, ref utc_minute, ref utc_second);
            s.swe_utc_to_jd(utc_year, utc_month, utc_day, utc_hour, utc_minute, utc_second, 1, dret, ref serr);

            double[] cusps = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] ascmc = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            s.swe_houses(dret[1], lat, lng, 'P', cusps, ascmc);
            s.swe_close();

            return cusps;
        }

        // 一度一年法
        // 一年を365.24日で計算、当然ずれが生じる
        // 面倒なのでとりあえず放置
        public List<PlanetData> PrimaryProgressionCalc(List<PlanetData> natallist, DateTime natalTime, DateTime transitTime)
        {
            List<PlanetData> progresslist = new List<PlanetData>();
            TimeSpan ts = transitTime - natalTime;
            double years = ts.TotalDays / year_days;
            natallist.ForEach(data =>
            {
                PlanetData progressdata = new PlanetData() { absolute_position = data.absolute_position, no = data.no, sensitive = data.sensitive, speed = data.speed };
                progressdata.absolute_position += years;
                progressdata.absolute_position %= 365;
                progresslist.Add(progressdata);
            });

            return progresslist;
        }

        // 一日一年法
        // 一年を365.24日で計算、当然ずれが生じる
        // 面倒なのでとりあえず放置
        public List<PlanetData> SecondaryProgressionCalc(List<PlanetData> natallist, DateTime natalTime, DateTime transitTime)
        {
            List<PlanetData> progresslist = new List<PlanetData>();
            TimeSpan ts = transitTime - natalTime;
            double years = ts.TotalDays / year_days;

            // 日付を秒数に変換する
            int seconds = (int)(years * 86400);

            TimeSpan add = TimeSpan.FromSeconds(seconds);

            DateTime newTime = natalTime + add;

            // absolute position
            double[] x = { 0, 0, 0, 0, 0, 0 };
            string serr = "";

            int utc_year = 0;
            int utc_month = 0;
            int utc_day = 0;
            int utc_hour = 0;
            int utc_minute = 0;
            double utc_second = 0;

            // [0]:Ephemeris Time [1]:Universal Time
            double[] dret = { 0.0, 0.0 };

            // utcに変換
            s.swe_utc_time_zone(newTime.Year, newTime.Month, newTime.Day, newTime.Hour, newTime.Minute, newTime.Second, 9.0, ref utc_year, ref utc_month, ref utc_day, ref utc_hour, ref utc_minute, ref utc_second);
            s.swe_utc_to_jd(utc_year, utc_month, utc_day, utc_hour, utc_minute, utc_second, 1, dret, ref serr);

            natallist.ForEach(data =>
            {
                int flag = SwissEph.SEFLG_SWIEPH | SwissEph.SEFLG_SPEED;
                if (config.centric == ECentric.HELIO_CENTRIC) flag |= SwissEph.SEFLG_HELCTR;
                if (config.sidereal == Esidereal.SIDEREAL)
                {
                    flag |= SwissEph.SEFLG_SIDEREAL;
                    s.swe_set_sid_mode(SwissEph.SE_SIDM_LAHIRI, 0, 0);
                    // ayanamsa計算
                    double daya = 0.0;
                    double ut = s.swe_get_ayanamsa_ex_ut(dret[1], SwissEph.SEFLG_SWIEPH, out daya, ref serr);

                    // Ephemeris Timeで計算, 結果はxに入る
                    s.swe_calc_ut(dret[1], data.no, flag, x, ref serr);
                    // tropicalからayanamsaをマイナス
                    x[0] = x[0] > daya ? x[0] - daya : x[0] - daya + 360;
                }
                else
                {
                    // Universal Timeで計算, 結果はxに入る
                    s.swe_calc_ut(dret[1], data.no, flag, x, ref serr);
                }

                PlanetData progressdata = new PlanetData() { absolute_position = x[0], no = data.no, sensitive = data.sensitive, speed = data.speed };
                progresslist.Add(progressdata);

            });

            return progresslist;
        }

        // CPS
        // 月、水星、金星、太陽は一日一年法
        // 火星以降および感受点は一度一年法
        // 一年を365.24日で計算、当然ずれが生じる
        // 面倒なのでとりあえず放置
        public List<PlanetData> CompositProgressionCalc(List<PlanetData> natallist, DateTime natalTime, DateTime transitTime)
        {
            List<PlanetData> progresslist = new List<PlanetData>();
            TimeSpan ts = transitTime - natalTime;
            double years = ts.TotalDays / year_days;

            // 日付を秒数に変換する
            int seconds = (int)(years * 86400);

            TimeSpan add = TimeSpan.FromSeconds(seconds);

            DateTime newTime = natalTime + add;

            // absolute position
            double[] x = { 0, 0, 0, 0, 0, 0 };
            string serr = "";

            int utc_year = 0;
            int utc_month = 0;
            int utc_day = 0;
            int utc_hour = 0;
            int utc_minute = 0;
            double utc_second = 0;

            // [0]:Ephemeris Time [1]:Universal Time
            double[] dret = { 0.0, 0.0 };

            // utcに変換
            s.swe_utc_time_zone(newTime.Year, newTime.Month, newTime.Day, newTime.Hour, newTime.Minute, newTime.Second, 9.0, ref utc_year, ref utc_month, ref utc_day, ref utc_hour, ref utc_minute, ref utc_second);
            s.swe_utc_to_jd(utc_year, utc_month, utc_day, utc_hour, utc_minute, utc_second, 1, dret, ref serr);

            natallist.ForEach( data => 
            {
                PlanetData progressdata;
                if ((data.no != Common.ZODIAC_MOON) && (data.no != Common.ZODIAC_MERCURY) && (data.no != Common.ZODIAC_VENUS) && (data.no != Common.ZODIAC_SUN))
                {
                    progressdata = new PlanetData() { absolute_position = data.absolute_position, no = data.no, sensitive = data.sensitive, speed = data.speed };
                    progressdata.absolute_position += years;
                    progressdata.absolute_position %= 365;
                    progresslist.Add(progressdata);
                    return;
                }
                int flag = SwissEph.SEFLG_SWIEPH | SwissEph.SEFLG_SPEED;
                if (config.centric == ECentric.HELIO_CENTRIC)
                    flag |= SwissEph.SEFLG_HELCTR;
                if (config.sidereal == Esidereal.SIDEREAL)
                {
                    flag |= SwissEph.SEFLG_SIDEREAL;
                    s.swe_set_sid_mode(SwissEph.SE_SIDM_LAHIRI, 0, 0);
                    // ayanamsa計算
                    double daya = 0.0;
                    double ut = s.swe_get_ayanamsa_ex_ut(dret[1], SwissEph.SEFLG_SWIEPH, out daya, ref serr);

                    // Ephemeris Timeで計算, 結果はxに入る
                    s.swe_calc_ut(dret[1], data.no, flag, x, ref serr);
                    // tropicalからayanamsaをマイナス
                    x[0] = x[0] > daya ? x[0] - daya : x[0] - daya + 360;
                }
                else
                {
                    // Universal Timeで計算, 結果はxに入る
                    s.swe_calc_ut(dret[1], data.no, flag, x, ref serr);
                }

                progressdata = new PlanetData() { absolute_position = x[0], no = data.no, sensitive = data.sensitive, speed = data.speed };
                progresslist.Add(progressdata);

            });


            return progresslist;
        }

        // アスペクトを計算する
        public List<PlanetData> AspectCalc(AspectSetting a_setting, List<PlanetData> natallist)
        {
            // if (natal-natal)
            for (int i = 0; i < natallist.Count - 2; i++)
            {
                for (int j = i + 1; j < natallist.Count - 1; j++)
                {
                    // 90.0 と　300.0では210度ではなく150度にならなければいけない
                    double aspect_degree = natallist[i].absolute_position - natallist[j].absolute_position;
                    if (aspect_degree > 180)
                    {
                        aspect_degree = natallist[j].absolute_position + 360 - natallist[i].absolute_position;
                    }
                    if (aspect_degree < 0)
                    {
                        aspect_degree = Math.Abs(aspect_degree);
                    }
                    // conjunction
                    if (aspect_degree < a_setting.orb_natal_sun)
                        natallist[i].aspects.Add(new Aspect() { target_no = j, aspect_kind = AspectKind.CONJUNCTION });

                    // square
                    if (aspect_degree < 90.0 + a_setting.orb_natal_sun &&
                        aspect_degree > 90.0 - a_setting.orb_natal_sun)
                        natallist[i].aspects.Add(new Aspect() { target_no = j, aspect_kind = AspectKind.SQUARE });

                    // trine
                    if (aspect_degree < 120.0 + a_setting.orb_natal_sun &&
                        aspect_degree > 120.0 - a_setting.orb_natal_sun)
                        natallist[i].aspects.Add(new Aspect() { target_no = j, aspect_kind = AspectKind.TRINE });

                    // opposition
                    if (aspect_degree < 180.0 + a_setting.orb_natal_sun &&
                        aspect_degree > 180.0 - a_setting.orb_natal_sun)
                        natallist[i].aspects.Add(new Aspect() { target_no = j, aspect_kind = AspectKind.OPPOSITION });

                    // sextile
                    if (aspect_degree < 60.0 + a_setting.orb_natal_sun &&
                        aspect_degree > 60.0 - a_setting.orb_natal_sun)
                        natallist[i].aspects.Add(new Aspect() { target_no = j, aspect_kind = AspectKind.SEXTILE });

                    // inconjunct / quincunx
                    if (aspect_degree < 150.0 + a_setting.orb_natal_sun &&
                        aspect_degree > 150.0 - a_setting.orb_natal_sun)
                        natallist[i].aspects.Add(new Aspect() { target_no = j, aspect_kind = AspectKind.INCONJUNCT });

                    // sesquiquadrate
                    if (aspect_degree < 135.0 + a_setting.orb_natal_sun &&
                        aspect_degree > 135.0 - a_setting.orb_natal_sun)
                        natallist[i].aspects.Add(new Aspect() { target_no = j, aspect_kind = AspectKind.SESQUIQUADRATE });
                }
            }

            return natallist;
        }
    }
}
