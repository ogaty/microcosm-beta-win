using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using microcosm.DB;
using System.Reflection;
using System.Xml.Serialization;

namespace microcosm.DB
{
    // 未テスト
    // データが無いxml
    // データが壊れたxml
    // ディレクトリだけ

    // ユーザーデータ選択ダイアログ
    public partial class DatabaseForm : Form
    {
        private MainForm mainform;
        public XMLDBManager DBMgr;
        public bool changed;
        public string datadir { get; } = System.Windows.Forms.Application.StartupPath + @"\data";
        public DatabaseForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;

            return;
        }

        private void Database_Load(object sender, EventArgs e)
        {
            //            this.CreateUserList();
            CreateTree();
        }

        // ツリー作成
        public void CreateTree()
        {
            dbDirTree.Nodes.Clear();

            var rootDirectoryInfo = new DirectoryInfo(datadir);
            dbDirTree.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
            dbDirTree.Nodes[0].Expand();
        }


        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name) { Tag = directoryInfo.FullName };
            foreach (var directory in directoryInfo.GetDirectories()) { 
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }
            foreach (var file in directoryInfo.GetFiles("*.csm"))
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name) { Tag = file.FullName });
            }
            return directoryNode;
        }


        private void OnSelected(int index)
        {

        }

        // ツリーを選択した時
        private void dbDirTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (Directory.Exists(e.Node.Tag.ToString())) return;

            XMLDBManager DBMgr = new XMLDBManager(e.Node.Tag.ToString());
            UserData data = DBMgr.getObject();

            eventListViewRender(data, datadir + @"\" + e.Node.Text);
        }

        // ラベルクリア
        private void clearLabels()
        {
            eventListView.Items.Clear();
        }
        // ラベル設定
        private void setBirth(UserData data, string filename)
        {
            ListViewItem item = new ListViewItem(data.name);
            string birth_text = String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                    data.birth_year,
                    data.birth_month,
                    data.birth_day,
                    data.birth_hour,
                    data.birth_minute,
                    data.birth_second
                );
            string latlng_text = String.Format("({0},{1})", data.lat, data.lng);
            string timezone = data.timezone;

            string[] subitems = { birth_text, data.birth_place, latlng_text, timezone };
            item.SubItems.AddRange(subitems);
            item.Tag = new User(data, null, filename, -1);
            eventListView.Items.Add(item);
        }

        private void setEventData(UserEvent uevent, string filename, int index)
        {
            ListViewItem item = new ListViewItem("- " + uevent.event_name);
            string event_birth_text = String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                        uevent.event_year,
                        uevent.event_month,
                        uevent.event_day,
                        uevent.event_hour,
                        uevent.event_minute,
                        uevent.event_second
                    );
            string event_latlng = String.Format("({0},{1})", uevent.event_lat, uevent.event_lng);

            string[] subitems = { event_birth_text, uevent.event_place, event_latlng, uevent.event_timezone };
            item.SubItems.AddRange(subitems);
            item.Tag = new User(null, uevent, filename, index);
            eventListView.Items.Add(item);
        }

        // ツリー右クリック
        private void dbDirTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Select the clicked node
                dbDirTree.SelectedNode = dbDirTree.GetNodeAt(e.X, e.Y);

                if (dbDirTree.SelectedNode != null)
                {
                    contextMenuStrip1.Show(dbDirTree, e.Location);
                }
            }

        }

        // 表示ボタン
        private void displayButton_Click(object sender, EventArgs e)
        {
            if (eventListView.FocusedItem == null)
            {
                return;
            }
            User u = (User)this.eventListView.FocusedItem.Tag;
            User udata = (User)this.eventListView.Items[0].Tag;
            this.mainform.ReflectUserData(u, udata);

            this.Close();
        }

        // メニュー→閉じる
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dbDirTree_MouseUp(object sender, MouseEventArgs e)
        {
//            dbDirTree.SelectedNode = null;
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);

            }
        }

        // ユーザーファイル追加
        private void addUser()
        {
            UserData addData = new UserData(
                "新規データ",
                "しんきでーた",
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
                "JST"
            );

            int i = 1;
            while (File.Exists(datadir + @"\user" + i.ToString() + ".csm"))
            {
                i++;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(UserData));
            FileStream fs = new FileStream(datadir + @"\user" + i.ToString() + ".csm", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            serializer.Serialize(sw, addData);
            sw.Close();
            fs.Close();
            CreateTree();

        }

        // ツリー右クリック新規追加
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUser();
        }

        // ツリー右クリック削除
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("削除してよろしいですか？",
                "ファイルを削除します",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                if (File.Exists(dbDirTree.SelectedNode.Tag.ToString())) {
                    File.Delete(dbDirTree.SelectedNode.Tag.ToString());
                } else if (Directory.Exists(dbDirTree.SelectedNode.Tag.ToString()))
                {
                    Directory.Delete(dbDirTree.SelectedNode.Tag.ToString());
                }

                CreateTree();
            }
        }

        // ツリー右クリックディレクトリ作成
        private void addDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (Directory.Exists(datadir + @"\dir" + i.ToString()))
            {
                i++;
            }

            Directory.CreateDirectory(datadir + @"\dir" + i.ToString());
            CreateTree();
        }

        // ツリー右クリック名前変更
        private void fileNameChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirEditForm diredit = new DirEditForm(this, dbDirTree.SelectedNode.Tag.ToString());
            diredit.Show();
        }


        private void dbDirTree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeView tv = (TreeView)sender;
            tv.SelectedNode = (TreeNode)e.Item;
            tv.Focus();
            //ノードのドラッグを開始する
            DragDropEffects dde =
                tv.DoDragDrop(e.Item, DragDropEffects.All);
            //移動した時は、ドラッグしたノードを削除する
            if ((dde & DragDropEffects.Move) == DragDropEffects.Move)
                tv.Nodes.Remove((TreeNode)e.Item);
        }

        private void dbDirTree_DragOver(object sender, DragEventArgs e)
        {
            //ドラッグされているデータがTreeNodeか調べる
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {

                e.Effect = DragDropEffects.Move;
            }
            else
                //TreeNodeでなければ受け入れない
                e.Effect = DragDropEffects.None;

        }

        private void dbDirTree_DragDrop(object sender, DragEventArgs e)
        {
            //ドロップされたデータがTreeNodeか調べる
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
            }
        }

        // キャンセルボタン
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // リスト右クリック表示
        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eventListView.FocusedItem == null)
            {
                return;
            }
            User u = (User)this.eventListView.FocusedItem.Tag;
            User udata = (User)eventListView.Items[0].Tag;
            this.mainform.ReflectUserData(u, udata);

            this.Close();

        }

        //リスト右クリック編集
        private void editEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eventListView.SelectedItems.Count == 0)
            {
                return;
            }
            User udata = (User)eventListView.Items[0].Tag;
            User uevent = (User)eventListView.SelectedItems[0].Tag;

            if (uevent.udata == null)
            {
                int index = uevent.index;
                UserEventEditForm ueventedit = new UserEventEditForm(this, udata.udata, index, udata.filename);
                ueventedit.Show();
            } else
            {
                UserDataEditForm udataedit = new UserDataEditForm(this, udata.udata, udata.filename);
                udataedit.Show();
            }
        }

    }
}
