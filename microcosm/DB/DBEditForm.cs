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
    public partial class DBEditForm : Form
    {
        private DatabaseForm dbform;
        private UserData userdata;
        private int index;
        public DBEditForm(DatabaseForm dbform, int index, UserData userdata)
        {
            InitializeComponent();
            this.dbform = dbform;
            this.index = index;
            this.userdata = userdata;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DBEditForm_Load(object sender, EventArgs e)
        {
            nameBox.Text = userdata.name;
            furiganaBox.Text = userdata.furigana;
            birthDate.Value = new DateTime(userdata.birth_year, userdata.birth_month, userdata.birth_day);
            hourBox.Text = userdata.birth_hour.ToString();
            minuteBox.Text = userdata.birth_month.ToString();
            secondBox.Text = userdata.birth_second.ToString();
            placeBox.Text = userdata.birth_place;
            latBox.Text = String.Format("{0:0,4f}", userdata.lat.ToString());
            lngBox.Text = String.Format("{0:0,4f}", userdata.lng.ToString());
            timezoneBox.Text = Common.getTimezoneText(userdata.timezone.ToUpper());
            memoBox.Text = userdata.memo;
            
            
        }
    }
}
