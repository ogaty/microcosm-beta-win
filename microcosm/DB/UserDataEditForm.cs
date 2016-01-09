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
using System.Net.Http;
using Newtonsoft.Json;

namespace microcosm.DB
{
    public partial class UserDataEditForm : Form
    {
        public DatabaseForm databaseform;
        public UserData udata;
        public string filename;
        public UserDataEditForm(DatabaseForm databaseform, UserData udata, string filename)
        {
            InitializeComponent();
            this.databaseform = databaseform;
            this.udata = udata;
            this.filename = filename;
        }

        private void UserDataEditForm_Load(object sender, EventArgs e)
        {
            nameBox.Text = udata.name;
            furiganaBox.Text = udata.furigana;
            birthDate.Value = new DateTime(udata.birth_year, udata.birth_month, udata.birth_day);
            hourBox.Text = udata.birth_hour.ToString();
            minuteBox.Text = udata.birth_minute.ToString();
            secondBox.Text = udata.birth_second.ToString();
            setPlace(udata.birth_place);
            setLatLng(udata.lat, udata.lng);
            timezoneBox.Text = Common.getTimezoneLongText(udata.timezone);
            memoBox.Text = udata.memo;
        }

        // キャンセルボタン
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 決定ボタン
        private void submitBtn_Click(object sender, EventArgs e)
        {
            UserData udata = new UserData(nameBox.Text,
                furiganaBox.Text,
                birthDate.Value.Year,
                birthDate.Value.Month,
                birthDate.Value.Day,
                int.Parse(hourBox.Text),
                int.Parse(minuteBox.Text),
                int.Parse(secondBox.Text),
                double.Parse(latBox.Text),
                double.Parse(lngBox.Text),
                placeBox.Text,
                memoBox.Text,
                Common.getTimezoneShortText(timezoneBox.SelectedIndex));

            udata.userevent = this.udata.userevent;
            if (File.Exists(this.filename))
            {
                File.Delete(this.filename);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(UserData));
            FileStream fs = new FileStream(this.filename, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            serializer.Serialize(sw, udata);
            sw.Close();
            fs.Close();

            databaseform.eventListViewRender(udata, this.filename);

            this.Close();
        }

        // 検索ボタン
        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<LatLng> latlnglist = new List<LatLng>();
            StreamReader sw = new StreamReader(@"tool\addr.csv");
            while(!sw.EndOfStream)
            {
                var line = sw.ReadLine();
                var values = line.Split(',');
                latlnglist.Add(new LatLng(values[0], double.Parse(values[1]), double.Parse(values[2])));
            }

            List<LatLng> findlist = latlnglist.FindAll(finding => finding.addr.Contains(placeBox.Text));
            SearchForm search = new SearchForm(this, placeBox.Text, findlist);
            search.Show();
        }

        // google検索ボタン
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
            } else
            {
                MessageBox.Show(Properties.Resources.ERROR_ERROR_RESPONSE);
            }
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

    }
}
