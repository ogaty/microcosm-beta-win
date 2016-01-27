using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualBasic.PowerPacks;
using SwissEphNet;
using microcosm.DB;
using microcosm.Config;
using microcosm.Calc;

namespace microcosm
{
    public partial class MainForm : Form
    {
        public ConfigData config;
        public Settings setting;
        public AspectSetting[] aspectSettingList;
        public AspectSetting aspectSetting;
        public string filename = @"system\system.xml";
        public string aspect_filename = @"system\aspect";

        public List<PlanetData> natallist;
        public List<PlanetData> progresslist;
        public List<PlanetData> transitlist;

        public double[] natalcusp;
        public double[] progresscusp;
        public double[] transitcusp;

        public AstroCalc calc;
        public bool flag;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // コンフィグ読み込み
            config = new ConfigData();
            setting = new Settings();
            aspectSettingList = new AspectSetting[10];
            for (int i = 0; i< 9; i++)
            {
                aspectSettingList[i] = new AspectSetting();
            }

            // 表示設定
            for (int i = 0; i < 10; i++)
            {
                if (File.Exists(aspect_filename + i.ToString() + ".xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AspectSetting));
                    FileStream fs = new FileStream(aspect_filename + i.ToString() + ".xml", FileMode.Open);
                    aspectSettingList[i] = (AspectSetting)serializer.Deserialize(fs);
                    fs.Close();
                    if (aspectSettingList[i].dispname == null)
                    {
                        aspectSelect.Items.Add("表示設定" + i.ToString());
                    } else
                    {
                        aspectSelect.Items.Add(aspectSettingList[i].dispname);
                    }
                } else
                {
                    aspectSelect.Items.Add("表示設定" + i.ToString());
                }
            }

            string name = "現在";
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            string birth = String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                        year.ToString(),
                        month.ToString(),
                        day.ToString(),
                        hour.ToString(),
                        minute.ToString(),
                        second.ToString()
                    );
            string place = "東京都中央区";
            double lat = 35.670587;
            double lng = 139.772003;
            if (!File.Exists(filename))
            {
                // 初期データ
                setMainData(name, birth, place, lat, lng);
                setMainEventData(name, birth, place, lat, lng);
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ConfigData));
                FileStream fs = new FileStream(filename, FileMode.Open);
                config = (ConfigData)serializer.Deserialize(fs);
                fs.Close();

                if (config.lat == 0 || config.lng == 0)
                {
                    // 初期データ
                    setMainData(name, birth, place, lat, lng);
                } else
                {
                    place = config.defaultPlace;
                    lat = config.lat;
                    lng = config.lng;
                    setMainData(name,
                        birth,
                        place,
                        lat,
                        lng);
                }
                setMainEventData(name, birth, place, lat, lng);

            }
            if (config.ephepath == null)
            {
                config.ephepath = System.Windows.Forms.Application.StartupPath + @"\ephe"; ;
            }

            // デフォルトデータ
            setNatalData(year, month, day, hour, minute, second, lat, lng);
            setTransitData(year, month, day, hour, minute, second, lat, lng);
            // 計算
            calc = new AstroCalc(config);

            // 表示(comboBoxのindexChangeで再描画)
            aspectSelect.SelectedIndex = 0;
            aspectSetting = aspectSettingList[0];

        }

        // 左上枠設定
        public void setMainData()
        {
            string name = "現在";
            string birth = String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                        DateTime.Now.Year.ToString(),
                        DateTime.Now.Month.ToString(),
                        DateTime.Now.Day.ToString(),
                        DateTime.Now.Hour.ToString(),
                        DateTime.Now.Minute.ToString(),
                        DateTime.Now.Second.ToString()
                    );
            string place = "東京都中央区";
            double lat = 35.670587;
            double lng = 139.772003;
            setMainData(name, birth, place, lat, lng);
        }
        public void setMainData(string name, string birth, string place, double lat, double lng)
        {
            usernameLabel.Text = name;
            birthLabel.Text = birth;
            placeLabel.Text = place;
            latLabel.Text = lat.ToString();
            lngLabel.Text = lng.ToString();
        }
        public void setMainEventData(string name, string birth, string place, double lat, double lng)
        {
            eventNameLabel.Text = name;
            eventDateLabel.Text = birth;
            eventPlaceLabel.Text = place;
            eventLatLabel.Text = lat.ToString();
            eventLngLabel.Text = lng.ToString();
        }

        // Natalセット
        public void setNatalData(int year, int month, int day, int hour, int minute, int second, double lat, double lng)
        {
            setting.natal_year = year;
            setting.natal_month = month;
            setting.natal_day = day;
            setting.natal_hour = hour;
            setting.natal_minute = minute;
            setting.natal_second = second;
            setting.natal_lat = lat;
            setting.natal_lng = lng;
        }

        // Natalセット
        public void setTransitData(int year, int month, int day, int hour, int minute, int second, double lat, double lng)
        {
            setting.transit_year = year;
            setting.transit_month = month;
            setting.transit_day = day;
            setting.transit_hour = hour;
            setting.transit_minute = minute;
            setting.transit_second = second;
            setting.transit_lat = lat;
            setting.transit_lng = lng;
        }

        // DB開く
        private void OpenDatabaseOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseForm db = new DatabaseForm(this);
            db.Show();
        }

        // DBから取得したデータを反映
        public void ReflectUserData(User u, User userdata)
        {
            if (u.udata == null)
            {
                UserEvent uevent = u.uevent;
                UserData udata = userdata.udata;
                this.usernameLabel.Text = udata.name;
                this.birthLabel.Text = String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                    udata.birth_year, udata.birth_month, udata.birth_day,
                    udata.birth_hour, udata.birth_minute, udata.birth_second);
                this.placeLabel.Text = udata.birth_place;
                this.latLabel.Text = udata.lat.ToString();
                this.lngLabel.Text = udata.lng.ToString();
                setNatalData(udata.birth_year, udata.birth_month, udata.birth_day, udata.birth_hour, udata.birth_minute, udata.birth_second, udata.lat, udata.lng);
                setTransitData(uevent.event_year, uevent.event_month, uevent.event_day, uevent.event_hour, uevent.event_minute, uevent.event_second, uevent.event_lat, uevent.event_lng);

                eventNameLabel.Text = uevent.event_name;
                eventDateLabel.Text = String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                    uevent.event_year, uevent.event_month, uevent.event_day,
                    uevent.event_hour, uevent.event_minute, uevent.event_second);
                eventPlaceLabel.Text = uevent.event_place;
                eventLatLabel.Text = uevent.event_lat.ToString();
                eventLngLabel.Text = uevent.event_lng.ToString();

            }
            else
            {
                UserData udata = u.udata;
                this.usernameLabel.Text = udata.name;
                this.birthLabel.Text = String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                    udata.birth_year, udata.birth_month, udata.birth_day,
                    udata.birth_hour, udata.birth_minute, udata.birth_second);
                this.placeLabel.Text = udata.birth_place;
                setNatalData(udata.birth_year, udata.birth_month, udata.birth_day, udata.birth_hour, udata.birth_minute, udata.birth_second, udata.lat, udata.lng);

            }

            chartRefresh();
        }

        // オプション→設定
        private void ConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.config == null)
                this.config = new ConfigData();

            ConfigForm config = new ConfigForm(this);
            config.Show();
        }

        private void centerSlider_Scroll(object sender, EventArgs e)
        {
        }

        private void ovalShape1_MouseHover(object sender, EventArgs e)
        {
            ((OvalShape)sender).BorderWidth = 3;
        }

        private void ovalShape1_MouseLeave(object sender, EventArgs e)
        {
            ((OvalShape)sender).BorderWidth = 2;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(filename))
            {
                MessageBox.Show("初期設定を行います。");
                ConfigForm configform = new ConfigForm(this);
                configform.Show();
            }
        }

        // メニュー一重円
        private void singleChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting.bands = 1;
            ToolStripMenuItem menuitem = (ToolStripMenuItem)sender;
            menuitem.Checked = true;
            tripleChartToolStripMenuItem.Checked = false;
            chartRefresh();
        }

        // メニュー三重円
        private void tripleChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting.bands = 3;
            ToolStripMenuItem menuitem = (ToolStripMenuItem)sender;
            menuitem.Checked = true;
            singleChartToolStripMenuItem.Checked = false;
            chartRefresh();
        }

        // チャート再描画
        public void chartRefresh()
        {
            natallist = calc.PositionCalc(setting.natal_year, setting.natal_month, setting.natal_day, setting.natal_hour, setting.natal_minute, setting.natal_second, setting.natal_lat, setting.natal_lng);
            natalcusp = calc.CuspCalc(setting.natal_year, setting.natal_month, setting.natal_day, setting.natal_hour, setting.natal_minute, setting.natal_second, setting.natal_lat, setting.natal_lng);
            natallist = calc.AspectCalcSame(aspectSetting, natallist);

            progresscusp = null;
            transitcusp = null;
            if (setting.bands > 1)
            {
                if (config.progression == 1)
                {
                    progresslist = calc.PrimaryProgressionCalc(natallist, new DateTime(setting.natal_year, setting.natal_month, setting.natal_day, setting.natal_hour, setting.natal_minute, setting.natal_second), new DateTime(setting.transit_year, setting.transit_month, setting.transit_day, setting.transit_hour, setting.transit_minute, setting.transit_second));
                } else if (config.progression == 2)
                {
                    progresslist = calc.SecondaryProgressionCalc(natallist, new DateTime(setting.natal_year, setting.natal_month, setting.natal_day, setting.natal_hour, setting.natal_minute, setting.natal_second), new DateTime(setting.transit_year, setting.transit_month, setting.transit_day, setting.transit_hour, setting.transit_minute, setting.transit_second));
                }
                else
                {
                    progresslist = calc.CompositProgressionCalc(natallist, new DateTime(setting.natal_year, setting.natal_month, setting.natal_day, setting.natal_hour, setting.natal_minute, setting.natal_second), new DateTime(setting.transit_year, setting.transit_month, setting.transit_day, setting.transit_hour, setting.transit_minute, setting.transit_second));
                }
                progresscusp = calc.CuspCalc(setting.transit_year, setting.transit_month, setting.transit_day, setting.transit_hour, setting.transit_minute, setting.transit_second, setting.transit_lat, setting.transit_lng);
                progresslist = calc.AspectCalcSame(aspectSetting, progresslist);
                natallist = calc.AspectCalcOther(aspectSetting, natallist, progresslist, 1);

                if (setting.bands > 2)
                {
                    transitlist = calc.PositionCalc(setting.transit_year, setting.transit_month, setting.transit_day, setting.transit_hour, setting.transit_minute, setting.transit_second, setting.transit_lat, setting.transit_lng);
                    transitcusp = calc.CuspCalc(setting.transit_year, setting.transit_month, setting.transit_day, setting.transit_hour, setting.transit_minute, setting.transit_second, setting.transit_lat, setting.transit_lng);
                    transitlist = calc.AspectCalcSame(aspectSetting, transitlist);
                    natallist = calc.AspectCalcOther(aspectSetting, natallist, transitlist, 2);
                    progresslist = calc.AspectCalcOther(aspectSetting, progresslist, transitlist, 2);
                }
            }

            tableRender(natallist, progresslist, transitlist, natalcusp, progresscusp, transitcusp);
            refreshRender();
            ringRender();
            zodiacRender(natalcusp[1]);
            houseCuspRender(natalcusp);
            signCuspRender(natalcusp[1]);
            planetRender(natalcusp[1], natallist, progresslist, transitlist);
            aspectsRendering(natalcusp[1], natallist, progresslist, transitlist);

        }

        public void ChangeSettingCombo(AspectSetting[] setList)
        {
            aspectSettingList = setList;
            Enumerable.Range(0, 10).ToList().ForEach(index => { aspectSelect.Items[index] = aspectSettingList[index].dispname; });
        }

        private void DisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm disp = new DisplayForm(this, aspectSettingList);
            disp.Show();
        }

        private void aspectSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            aspectSetting = aspectSettingList[((ComboBox)sender).SelectedIndex];
            chartRefresh();
        }

        private void NowDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = "現在";
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            string birth = String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                        year.ToString(),
                        month.ToString(),
                        day.ToString(),
                        hour.ToString(),
                        minute.ToString(),
                        second.ToString()
                    );
            double lat = config.lat;
            double lng = config.lng;
            string place = config.defaultPlace;
            setMainData(name, birth, place, lat, lng);

            // デフォルトデータ
            setNatalData(year, month, day, hour, minute, second, lat, lng);
            // 計算
            calc = new AstroCalc(config);

            // 表示(comboBoxのindexChangeで再描画)
            chartRefresh();

        }

        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.Version v = new Help.Version();
            v.Show();
        }
    }
}
