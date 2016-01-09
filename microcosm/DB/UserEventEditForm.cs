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
using System.Xml.Serialization;
using System.Net.Http;
using Newtonsoft.Json;

namespace microcosm.DB
{
    public partial class UserEventEditForm : Form
    {
        public DatabaseForm databaseform;
        public UserData udata;
        public int index;
        public string filename;

        public UserEventEditForm(DatabaseForm databaseform, UserData udata, int index, string filename)
        {
            InitializeComponent();
            this.databaseform = databaseform;
            this.udata = udata;
            this.index = index;
            this.filename = filename;
        }

        private void UserEventEditForm_Load(object sender, EventArgs e)
        {
            eventnameBox.Text = udata.userevent[index].event_name;
            eventDate.Value = new DateTime(udata.userevent[index].event_year, udata.userevent[index].event_month, udata.userevent[index].event_day);
            eventHourBox.Text = udata.userevent[index].event_hour.ToString();
            eventMinuteBox.Text = udata.userevent[index].event_minute.ToString();
            eventSecondBox.Text = udata.userevent[index].event_second.ToString();
            setPlace(udata.userevent[index].event_place);
            setLatLng(udata.userevent[index].event_lat, udata.userevent[index].event_lng);
            eventTimezone.Text = Common.getTimezoneLongText(udata.userevent[index].event_timezone);
            eventMemoBox.Text = udata.userevent[index].event_memo;
            
        }

        // キャンセルボタン
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 決定ボタン
        private void submitButton_Click(object sender, EventArgs e)
        {
            UserEvent uevent = new UserEvent(
                eventnameBox.Text,
                eventDate.Value.Year,
                eventDate.Value.Month,
                eventDate.Value.Day,
                int.Parse(eventHourBox.Text),
                int.Parse(eventMinuteBox.Text),
                int.Parse(eventSecondBox.Text),
                eventPlaceBox.Text,
                double.Parse(eventLatBox.Text),
                double.Parse(eventLngBox.Text),
                Common.getTimezoneShortText(eventTimezone.SelectedIndex),
                eventMemoBox.Text);
            this.udata.userevent[index] = uevent;

            if (File.Exists(this.filename))
            {
                File.Delete(this.filename);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(UserData));
            FileStream fs = new FileStream(this.filename, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            serializer.Serialize(sw, this.udata);
            sw.Close();
            fs.Close();

            databaseform.eventListViewRender(udata, this.filename);

            this.Close();
        }

        // 検索
        private void searchBtn2_Click(object sender, EventArgs e)
        {
            List<LatLng> latlnglist = new List<LatLng>();
            StreamReader sw = new StreamReader(@"tool\addr.csv");
            while (!sw.EndOfStream)
            {
                var line = sw.ReadLine();
                var values = line.Split(',');
                latlnglist.Add(new LatLng(values[0], double.Parse(values[1]), double.Parse(values[2])));
            }

            List<LatLng> findlist = latlnglist.FindAll(finding => finding.addr.Contains(eventPlaceBox.Text));
            SearchForm search = new SearchForm(this, eventPlaceBox.Text, findlist);
            search.Show();

        }

        // google検索ボタン
        private async void googleBtn2_Click(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();
            string url = "http://maps.google.com/maps/api/geocode/json?address=" + eventPlaceBox.Text;
            var response = await http.GetAsync(url);

            var contents = await response.Content.ReadAsStringAsync();

            var jsonresult = JsonConvert.DeserializeObject<GoogleLatLng>(contents);
            if (jsonresult.status == "OK")
            {
                eventLatBox.Text = jsonresult.results[0].geometry.location.lat.ToString();
                eventLngBox.Text = jsonresult.results[0].geometry.location.lng.ToString();
            }
            else
            {
                MessageBox.Show(Properties.Resources.ERROR_ERROR_RESPONSE);
            }

        }

        // 検索した緯度経度を設定
        public void setLatLng(double lat, double lng)
        {
            eventLatBox.Text = lat.ToString();
            eventLngBox.Text = lng.ToString();
        }

        public void setPlace(string place)
        {
            eventPlaceBox.Text = place;
        }
    }
}
