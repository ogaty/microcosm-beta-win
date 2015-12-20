using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace microcosm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenDatabaseOToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

            }
        }
    }
}
