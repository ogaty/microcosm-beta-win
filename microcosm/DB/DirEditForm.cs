using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace microcosm.DB
{
    public partial class DirEditForm : Form
    {
        private DatabaseForm dbform;
        private string filename;
        public DirEditForm(DatabaseForm dbform, string filename)
        {
            InitializeComponent();
            this.dbform = dbform;
            this.filename = filename;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(filename))
            {
                if (File.Exists(dbform.datadir + @"\" + dirnameBox.Text) || Directory.Exists(dbform.datadir + @"\" + dirnameBox.Text))
                {
                    MessageBox.Show(Properties.Resources.ERROR_FILE_EXIST);
                    return;
                }
                File.Move(filename, dbform.datadir + @"\" + dirnameBox.Text);
            } else if (Directory.Exists(filename))
            {
                if (File.Exists(dbform.datadir + @"\" + dirnameBox.Text) || Directory.Exists(dbform.datadir + @"\" + dirnameBox.Text))
                {
                    MessageBox.Show(Properties.Resources.ERROR_FILE_EXIST);
                    return;
                }
                Directory.Move(filename, dbform.datadir + @"\" + dirnameBox.Text);
            }
            dbform.CreateTree();
            this.Close();
        }

        private void DirEditForm_Load(object sender, EventArgs e)
        {
            dirnameBox.Text = (new FileInfo(filename)).Name;
        }
    }
}
