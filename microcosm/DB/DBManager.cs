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
    public class DBManager : DBManagerInterface
    {
        private JObject jData;

        public DBManager (string jsonFile)
        {
            jData = JObject.Parse(File.ReadAllText(jsonFile));
        }


        public DBData getObject()
        {
            DBData dbd = new DBData();
            dbd.setData(
                (int)jData["no"],
                (string)jData["name"],
                (string)jData["furigana"],
                (string)jData["birth_data"],
                (string)jData["lat"],
                (string)jData["lng"],
                (string)jData["birth_place"],
                (string)jData["memo"],
                (int)jData["jisa"]
            );

            return dbd;
        }

    }
}
