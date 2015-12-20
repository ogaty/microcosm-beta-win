using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace microcosm
{
    // ユーザーデータ選択ダイアログ
    public partial class Database : Form
    {
        public DBManager DBObj;
        public Database(String DBData)
        {
            InitializeComponent();

            // マネージャー呼び出し
            if (DBObj == null)
            {
                DBObj = new DBManager(DBData);
            }

            // DBファイルに従ってツリー構築
            TreeNode node = new TreeNode("text");
            dbDirTree.Nodes.Add(node);

        }

        private void Database_Load(object sender, EventArgs e)
        {
        }
    }
}
