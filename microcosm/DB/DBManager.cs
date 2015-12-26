using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using microcosm.DB;

namespace microcosm
{
    // DBの型はJSONをメインとするけどXML,yamlでも使えるようにしたい
    // AMATERU他からのインポートもしたい
    // というわけで基底クラスを作る
    public class DBManager : DBManagerInterface
    {
        protected JObject jData;
        public List<UserDir> ulist ;

        public DBManager ()
        {
            return;
        }


        public List<UserDir> getObject()
        {
            return ulist;
        }

    }
}
