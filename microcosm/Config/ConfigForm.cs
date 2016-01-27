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
using microcosm.DB;
using System.Net.Http;
using Newtonsoft.Json;

namespace microcosm.Config
{
    public partial class ConfigForm : Form
    {
        public MainForm mainform;

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

            if (this.mainform.config.progression == 1)
            {
                primaryProgression.Checked = true;
                secondaryProgression.Checked = false;
                compositProgression.Checked = false;
            } else if (this.mainform.config.progression == 2)
            {
                primaryProgression.Checked = false;
                secondaryProgression.Checked = true;
                compositProgression.Checked = false;
            } else
            {
                primaryProgression.Checked = false;
                secondaryProgression.Checked = false;
                compositProgression.Checked = true;
            }

            placeBox.Text = mainform.config.defaultPlace;
            latBox.Text = mainform.config.lat.ToString();
            lngBox.Text = mainform.config.lng.ToString();
            

        }

        private void centric_geo_CheckedChanged(object sender, EventArgs e)
        {
        }

        // キャンセル
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // OK
        private void button1_Click(object sender, EventArgs e)
        {
            this.mainform.config.centric = centric_geo.Checked == true ? ECentric.GEO_CENTRIC : ECentric.HELIO_CENTRIC;
            this.mainform.config.defaultPlace = placeBox.Text;
            this.mainform.config.lat = double.Parse(latBox.Text);
            this.mainform.config.lng = double.Parse(lngBox.Text);
            if (primaryProgression.Checked)
            {
                this.mainform.config.progression = 1;
            } else if (secondaryProgression.Checked)
            {
                this.mainform.config.progression = 2;
            } else
            {
                this.mainform.config.progression = 3;
            }

            if (File.Exists(mainform.filename))
            {
                File.Delete(mainform.filename);
            }
            XmlSerializer serializer = new XmlSerializer(typeof(ConfigData));
            FileStream fs = new FileStream(mainform.filename, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            serializer.Serialize(sw, mainform.config);
            sw.Close();
            fs.Close();


            mainform.chartRefresh();
            this.Close();
        }

        // 検索
        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<LatLng> latlnglist = new List<LatLng>();
            StreamReader sw = new StreamReader(@"tool\addr.csv");
            while (!sw.EndOfStream)
            {
                var line = sw.ReadLine();
                var values = line.Split(',');
                latlnglist.Add(new LatLng(values[0], double.Parse(values[1]), double.Parse(values[2])));
            }

            List<LatLng> findlist = latlnglist.FindAll(finding => finding.addr.Contains(placeBox.Text));
            SearchForm search = new SearchForm(this, placeBox.Text, findlist);
            search.Show();

        }

        // 検索した緯度経度を設定
        public void setLatLng(double lat, double lng)
        {
            latBox.Text = lat.ToString();
            lngBox.Text = lng.ToString();
        }

        // 検索した場所を設定
        public void setPlace(string place)
        {
            placeBox.Text = place;
        }

        // google
        private async void googleBtn_Click(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();
            string url = "http://maps.google.com/maps/api/geocode/json?address=" + placeBox.Text;
            var response = await http.GetAsync(url);

            var contents = await response.Content.ReadAsStringAsync();

            var jsonresult = JsonConvert.DeserializeObject<GoogleLatLng>(contents);
            if (jsonresult.status == "OK")
            {
                latBox.Text = jsonresult.results[0].geometry.location.lat.ToString();
                lngBox.Text = jsonresult.results[0].geometry.location.lng.ToString();
            }
            else
            {
                MessageBox.Show(Properties.Resources.ERROR_ERROR_RESPONSE);
            }
        }
    }
}
