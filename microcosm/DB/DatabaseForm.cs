using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using microcosm.DB;

namespace microcosm
{
    // ユーザーデータ選択ダイアログ
    public partial class DatabaseForm : Form
    {
        public DBManager DBMgr;
        public DatabaseForm(string DBFilename)
        {
            InitializeComponent();

            // マネージャー呼び出し
            if (DBMgr == null)
            {
                DBMgr = new JSONDBManager(DBFilename);
            }

            // DBファイルに従ってツリー構築
            List < UserData > UserList = DBMgr.getObject();
            foreach (UserData user in UserList)
            {
                TreeNode node = new TreeNode(user.name);
                dbDirTree.Nodes.Add(node);
            }

        }

        private void Database_Load(object sender, EventArgs e)
        {
        }
    }
}
