using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissEphNet;
using microcosm.Config;

namespace microcosm.Calc
{
    public class AstroCalc
    {
        public List<PlanetData> planetdata;
        public ConfigData config;

        public AstroCalc(ConfigData config)
        {
            planetdata = new List<PlanetData>();
            this.config = config;
        }

        public List<PlanetData> PositionCalc(int year, int month, int day, int hour, int min, double sec, double lng, double lat)
        {
            SwissEph s = new SwissEph();

            // absolute position
            double[] x = { 0, 0, 0, 0, 0, 0 };
            string serr = "";

            // http://www.astro.com/ftp/swisseph/ephe/archive_zip/ からDL
            s.swe_set_ephe_path(config.ephepath);

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
            for (int i = 0; i < 10; i++)
            {
                int flag = SwissEph.SEFLG_SWIEPH;
                if (config.centric == ECentric.HELIO_CENTRIC)
                {
                    flag |= SwissEph.SEFLG_HELCTR;
                }
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
                    x[0] -= daya;
                }
                else
                {
                    // Universal Timeで計算, 結果はxに入る
                    s.swe_calc_ut(dret[1], i, flag, x, ref serr);
                }


                PlanetData p = new PlanetData() { no = i, absolute_position = x[0], text = Common.getPlanetText(i), symbol = Common.getPlanetSymbol(i) };
                planetdata.Add(p);
            }

            s.swe_close();
            return planetdata;
        }
    }
}
