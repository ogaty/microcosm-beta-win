using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using SwissEphNet;
using microcosm.DB;
using microcosm.Config;

namespace microcosm
{
    public partial class MainForm : Form
    {
        public ConfigData config;

        public MainForm()
        {
            InitializeComponent();

            SwissEph s = new SwissEph();
            singleChartRender();
        }

        // DB開く
        private void OpenDatabaseOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseForm db = new DatabaseForm(this);
            db.Show();
        }

        // DB変更
        private void ChangeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ファイルオープンダイアログ(XML) 後ほど拡張子変えるかも
            OpenFileDialog ofd = new OpenFileDialog();
            // デフォルトファイル
            ofd.FileName = "default.xml";
            ofd.Filter = "microcosm DB(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
            ofd.Title = "ファイルを選択してください";

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
//                DatabaseForm db = new DatabaseForm(this, ofd.FileName);
//                db.CreateUserList();
//                db.Show();
            }
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
