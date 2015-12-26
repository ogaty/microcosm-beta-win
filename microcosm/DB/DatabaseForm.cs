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
    // 未テスト
    // データが無いxml
    // データが壊れたxml
    // ディレクトリだけ


    // ユーザーデータ選択ダイアログ
    public partial class DatabaseForm : Form
    {
        public XMLDBManager DBMgr;
        public ContextMenuStrip rightmenu;
        public DatabaseForm(string DBFilename)
        {
            InitializeComponent();

            // マネージャー呼び出し
            if (DBMgr == null)
            {
                DBMgr = new XMLDBManager(DBFilename);
            }

            // 共通右クリックメニュー
            rightmenu = new ContextMenuStrip();
            rightmenu.Items.Add("テスト");


            // DBファイルに従ってツリー構築
            List< UserDir > UserList = DBMgr.getObject();
            foreach (UserDir userdirs in UserList)
            {
                if (userdirs.dir != "nodir")
                {
                    TreeNode node = new TreeNode(userdirs.dir);
                    dbDirTree.Nodes.Add(node);
                    if (userdirs.data != null)
                    {
                        foreach (UserData data in userdirs.data)
                        {
                            int index = node.Nodes.Add(new TreeNode(data.name));
                            node.Nodes[index].Tag = data;
                        }

                    }
                } else
                {
                    // ディレクトリ無し
                    if (userdirs.data != null)
                    {
                        foreach (UserData data in userdirs.data)
                        {
                            int index = dbDirTree.Nodes.Add(new TreeNode(data.name));
                            dbDirTree.Nodes[index].Tag = data;
                        }

                    }

                }
            }


            return;
        }

        private void OnSelected(int index)
        {

        }

        private void Database_Load(object sender, EventArgs e)
        {
        }

        private void dbDirTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UserData data = (UserData)e.Node.Tag;
            if (data != null) { 
                namelabel.Text = data.name;
                birthlabel.Text = String.Format("{0}年{1}月{2}日", data.birth_year.ToString(), data.birth_month.ToString(), data.birth_day.ToString());
            }
        }

        // 表示ボタン
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 右クリック
        private void dbDirTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Select the clicked node
                dbDirTree.SelectedNode = dbDirTree.GetNodeAt(e.X, e.Y);

                if (dbDirTree.SelectedNode != null)
                {
                    rightmenu.Show(dbDirTree, e.Location);
                }
            }

        }
    }
}
