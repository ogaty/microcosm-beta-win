using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace microcosm.DB
{
    public partial class DirEditForm : Form
    {
        private DatabaseForm dbform;
        private int index;
        public DirEditForm(DatabaseForm dbform, int index)
        {
            InitializeComponent();
            this.dbform = dbform;
            this.index = index;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            dbform.setDirName(index, dirnameBox.Text);
            this.Close();
        }
    }
}
