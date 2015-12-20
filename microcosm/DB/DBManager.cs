using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace microcosm
{
    // DBの型はJSONをメインとするけどXML,yamlでも使えるようにしたい
    // AMATERU他からのインポートもしたい
    // というわけで基底クラスを作る
    public class DBManager : DBManagerInterface
    {
        private JObject jData;
        private List<UserData> ulist ;

        public DBManager (string jsonFile)
        {
            jData = JObject.Parse(File.ReadAllText(jsonFile));
            JArray items = (JArray)jData["userdata"];
            JObject item;
            JToken jtoken;
            for (int i = 0; i < items.Count; i++)
            {
                item = (JObject)items[i];
                jtoken = item.First;
            }
            ulist = new List<UserData>();
        }


        public UserData getObject()
        {
            UserData udata = new UserData();
            udata.setData(
                (int)jData["no"],
                (string)jData["name"],
                (string)jData["furigana"],
                (int)jData["birth_year"],
                (int)jData["birth_month"],
                (int)jData["birth_day"],
                (int)jData["birth_hour"],
                (int)jData["birth_minute"],
                (int)jData["birth_second"],
                (string)jData["lat"],
                (string)jData["lng"],
                (string)jData["birth_place"],
                (string)jData["memo"],
                (int)jData["jisa"]
            );

            // Listにしてね
            return udata;
        }

    }
}
