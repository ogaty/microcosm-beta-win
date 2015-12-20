using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace microcosm.DB
{
    class JSONDBManager : DBManager
    {
        public JSONDBManager(string jsonFile)
        {
            ulist = new List<UserData>();

            jData = JObject.Parse(File.ReadAllText(jsonFile));
            JArray items = (JArray)jData["userdata"];
            JObject item;
            for (int i = 0; i < items.Count; i++)
            {
                item = (JObject)items[i];
                UserData udata = new UserData();
                try
                {
                    udata.setData(
                        (int)item["no"],
                        (string)item["name"],
                        (string)item["furigana"],
                        (int)item["birth_year"],
                        (int)item["birth_month"],
                        (int)item["birth_day"],
                        (int)item["birth_hour"],
                        (int)item["birth_minute"],
                        (int)item["birth_second"],
                        (string)item["lat"],
                        (string)item["lng"],
                        (string)item["birth_place"],
                        (string)item["memo"],
                        (int)item["timezone"]
                    );
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                ulist.Add(udata);
            }

            return;
        }

    }
}
