using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace microcosm.DB
{
    public class XMLDBManager : DBManager
    {
        private string xmlFile;

        public XMLDBManager(string xmlFile)
        {
            this.xmlFile = xmlFile;
        }

        public new UserData getObject()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserData));
            FileStream fs = new FileStream(xmlFile, FileMode.Open);
            UserData udata = new UserData("名称未設定",
                "",
                2000,
                1,
                1,
                12,
                0,
                0,
                35.685175,
                139.7528,
                "東京都中央区",
                "",
                "JST");
            try
            {
                udata = (UserData)serializer.Deserialize(fs);
            } catch (Exception e)
            {
                MessageBox.Show("ファイルの読み込みで異常が発生しました。");
                Console.WriteLine(e.Message);
            }
            fs.Close();

            return udata;
        }

    }
}
