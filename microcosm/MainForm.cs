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

namespace microcosm
{
    public partial class MainForm : Form
    {
        public ConfigData config;
        public string filename = @"system\system.xml";

        public MainForm()
        {
            InitializeComponent();

            SwissEph s = new SwissEph();
            singleChartRender();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // コンフィグ読み込み
            if (this.config == null)
            {
                this.config = new ConfigData();
            }

            if (!File.Exists(filename))
            {
                // 初期データ
                setMainData();
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
                    setMainData();
                } else
                {
                    setMainData("現在",
                        String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                            DateTime.Now.Year.ToString(),
                            DateTime.Now.Month.ToString(),
                            DateTime.Now.Day.ToString(),
                            DateTime.Now.Hour.ToString(),
                            DateTime.Now.Minute.ToString(),
                            DateTime.Now.Second.ToString()
                        ),
                        config.defaultPlace,
                        config.lat,
                        config.lng);
                }

            }

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

        // DB開く
        private void OpenDatabaseOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseForm db = new DatabaseForm(this);
            db.Show();
        }

        // DBから取得したデータを反映
        public void ReflactUserData(User u)
        {
            if (u.udata == null)
            {
                UserEvent uevent = u.uevent;
                this.usernameLabel.Text = uevent.event_name;
                this.birthLabel.Text = String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                    uevent.event_year, uevent.event_month, uevent.event_day,
                    uevent.event_hour, uevent.event_minute, uevent.event_second);
                this.placeLabel.Text = uevent.event_place;

            }
            else
            {
                UserData udata = u.udata;
                this.usernameLabel.Text = udata.name;
                this.birthLabel.Text = String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                    udata.birth_year, udata.birth_month, udata.birth_day,
                    udata.birth_hour, udata.birth_minute, udata.birth_second);
                this.placeLabel.Text = udata.birth_place;
            }

        }

        // オプション→設定
        private void ConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.config == null)
            {
                this.config = new ConfigData();
            }

            ConfigForm config = new ConfigForm(this);
            config.Show();
        }

        private void centerSlider_Scroll(object sender, EventArgs e)
        {
            singleChartRender(centerSlider.Value);
        }

        private void ovalShape1_MouseHover(object sender, EventArgs e)
        {
            ((OvalShape)sender).BorderWidth = 3;
        }

        private void ovalShape1_MouseLeave(object sender, EventArgs e)
        {
            ((OvalShape)sender).BorderWidth = 2;
        }

    }
}
