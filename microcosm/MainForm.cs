using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissEphNet;
using microcosm.DB;
using microcosm.Config;

namespace microcosm
{
    public partial class MainForm : Form
    {
        private string DBFileName = "default.xml";
        public ConfigData config;

        public MainForm()
        {
            InitializeComponent();

            SwissEph s = new SwissEph();
        }

        // DB開く
        private void OpenDatabaseOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseForm db = new DatabaseForm(this, DBFileName);
            db.CreateUserList();
            db.Show();
        }

        // DB変更
        private void ChangeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ファイルオープンダイアログ(CSM)
            OpenFileDialog ofd = new OpenFileDialog();
            // デフォルトファイル
            ofd.FileName = "default.csm";
            ofd.Filter = "microcosm DB(*.csm)|*.csm|すべてのファイル(*.*)|*.*";
            ofd.Title = "ファイルを選択してください";

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DatabaseForm db = new DatabaseForm(this, ofd.FileName);
                db.CreateUserList();
                db.Show();
            }
        }

        public void ReflactUserData(UserData udata)
        {
            this.usernameLabel.Text = udata.name;
            this.birthLabel.Text = String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}", 
                udata.birth_year, udata.birth_month, udata.birth_day,
                udata.birth_hour, udata.birth_minute, udata.birth_second);
            this.placeLabel.Text = udata.birth_place;

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
    }
}
