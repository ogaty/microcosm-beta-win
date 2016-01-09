using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using microcosm.Config;

namespace microcosm.DB
{
    public partial class SearchForm : Form
    {
        public UserDataEditForm udataform;
        public UserEventEditForm ueventform;
        public ConfigForm configform;
        public List<LatLng> items;
        public string searchplace;

        public SearchForm(UserDataEditForm form, string searchplace, List<LatLng> items)
        {
            InitializeComponent();
            this.udataform = form;
            this.searchplace = searchplace;
            this.items = items;
        }

        public SearchForm(UserEventEditForm form, string searchplace, List<LatLng> items)
        {
            InitializeComponent();
            this.ueventform = form;
            this.searchplace = searchplace;
            this.items = items;
        }

        public SearchForm(ConfigForm form, string searchplace, List<LatLng> items)
        {
            InitializeComponent();
            this.configform = form;
            this.searchplace = searchplace;
            this.items = items;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            searchBox.Text = searchplace;
            foreach (var item in items)
            {
                ListViewItem litem = new ListViewItem(item.addr);
                string[] lsubitems = { item.lat.ToString(), item.lng.ToString() };
                litem.SubItems.AddRange(lsubitems);
                searchList.Items.Add(litem);
            }
        }

        // 決定ボタン
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (udataform != null)
            {
                udataform.setLatLng(double.Parse(searchList.SelectedItems[0].SubItems[1].Text), 
                    double.Parse(searchList.SelectedItems[0].SubItems[2].Text));
                udataform.setPlace(searchList.SelectedItems[0].SubItems[0].Text);
            } else if (ueventform != null)
            {
                ueventform.setLatLng(double.Parse(searchList.SelectedItems[0].SubItems[1].Text),
                    double.Parse(searchList.SelectedItems[0].SubItems[2].Text));
                ueventform.setPlace(searchList.SelectedItems[0].SubItems[0].Text);
            } else if (configform != null)
            {
                configform.setLatLng(double.Parse(searchList.SelectedItems[0].SubItems[1].Text),
                    double.Parse(searchList.SelectedItems[0].SubItems[2].Text));
                configform.setPlace(searchList.SelectedItems[0].SubItems[0].Text);
            }

            this.Close();
        }
    }
}
