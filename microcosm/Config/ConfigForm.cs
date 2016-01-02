using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace microcosm.Config
{
    public partial class ConfigForm : Form
    {
        public MainForm mainform;
        private ConfigData configdata;

        public ConfigForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            ECentric centric = this.mainform.config.centric;
            if (centric == ECentric.GEO_CENTRIC)
            {
                centric_geo.Checked = true;
                centric_herio.Checked = false;
            } else
            {
                centric_geo.Checked = false;
                centric_herio.Checked = true;
            }
        }

        private void centric_geo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mainform.config.centric = centric_geo.Checked == true ? ECentric.GEO_CENTRIC : ECentric.HERIO_SENCTRIC;
            this.Close();
        }
    }
}
