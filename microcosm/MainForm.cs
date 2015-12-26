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

namespace microcosm
{
    public partial class MainForm : Form
    {
        private string DBFileName = "default.xml";

        public MainForm()
        {
            InitializeComponent();

            SwissEph s = new SwissEph();
        }

        private void OpenDatabaseOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseForm db = new DatabaseForm(DBFileName);
            db.Show();
        }

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
                DatabaseForm db = new DatabaseForm(ofd.FileName);
                db.Show();
            }
        }
    }
}
