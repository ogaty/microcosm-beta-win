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
        private MainForm mainform;
        public XMLDBManager DBMgr;
        public bool changed;
        private string filename;
        public DatabaseForm(MainForm mainform, string DBFilename)
        {
            InitializeComponent();
            this.mainform = mainform;

            // マネージャー呼び出し
            if (this.DBMgr == null)
            {
                this.DBMgr = new XMLDBManager(DBFilename);
            }
            this.filename = DBFilename;


            return;
        }

        private void Database_Load(object sender, EventArgs e)
        {
            this.CreateUserList();
        }

        // TreeView生成
        public void CreateUserList()
        {
            dbDirTree.Nodes.Clear();
            TreeNode root = new TreeNode("userlist");

            // DBファイルに従ってツリー構築
            List<UserDir> UserList = this.DBMgr.getObject();
            foreach (UserDir userdirs in UserList)
            {
                if (userdirs.dir != "__nodir")
                {
                    // ディレクトリあり
                    TreeNode node = new TreeNode(userdirs.dir);
                    root.Nodes.Add(node);
                    if (userdirs.data != null)
                    {
                        foreach (UserData data in userdirs.data)
                        {
                            int index = node.Nodes.Add(new TreeNode(data.name));
                            node.Nodes[index].Tag = data;
                        }

                    }
                }
                else
                {
                    // ディレクトリ無し
                    if (userdirs.data != null)
                    {
                        foreach (UserData data in userdirs.data)
                        {
                            int index = root.Nodes.Add(new TreeNode(data.name));
                            root.Nodes[index].Tag = data;
                        }

                    }

                }
            }
            root.Expand();
            dbDirTree.Nodes.Add(root);

        }

        private void OnSelected(int index)
        {

        }

        // 選択した時
        private void dbDirTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UserData data = (UserData)e.Node.Tag;
            if (data != null)
            {
                this.setLabels(data.name,
                    String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                        data.birth_year,
                        data.birth_month,
                        data.birth_day,
                        data.birth_hour,
                        data.birth_minute,
                        data.birth_second
                    ),
                    data.birth_place,
                    String.Format("({0},{1})", data.lat, data.lng),
                    data.timezone,
                    data.memo
                );
                eventList.Items.Clear();
                if (null != data.userevent)
                { 
                    for (int i = 0; i < data.userevent.Count; i++)
                    {
                        eventList.Items.Add(data.userevent[i].event_name);
                    }
                }
            }
            else
            {
                this.clearLabels();
            }
        }

        // ラベルクリア
        private void clearLabels()
        {
            this.setLabels("", "", "", "", "", "");
        }
        // ラベル設定
        private void setLabels(string name, string birth_text, string birth_place, string latlng_text, string timezone, string memo)
        {
            namelabel.Text = name;
            birthlabel.Text = birth_text;
            placelabel.Text = birth_place;
            latlnglabel.Text = latlng_text;
            timezoneLabel.Text = timezone;
            memoLabel.Text = memo;
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
                    contextMenuStrip1.Show(dbDirTree, e.Location);
                }
            }

        }

        // 表示ボタン
        private void displayButton_Click(object sender, EventArgs e)
        {
            if (this.dbDirTree.SelectedNode == null)
            {
                return;
            }
            UserData data = (UserData)this.dbDirTree.SelectedNode.Tag;
            this.mainform.ReflactUserData(data);
            this.Close();
        }

        // 追加ボタン
        private void addButton_Click(object sender, EventArgs e)
        {
            addUser();

        }

        // 削除
        private void deleteButton_Click(object sender, EventArgs e)
        {
            dbDirTree.SelectedNode.Remove();
            this.clearLabels();
            this.changed = true;
        }

        // DB切り替え
        private void ChangeDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.changed)
            {
                MessageBox.Show("変更されています。保存しますか？");
            }
            // ファイルオープンダイアログ(XML) 後ほど拡張子変えるかも
            OpenFileDialog ofd = new OpenFileDialog();
            // デフォルトファイル
            ofd.FileName = "default.xml";
            ofd.Filter = "microcosm DB(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
            ofd.Title = "ファイルを選択してください";

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.DBMgr = new XMLDBManager(ofd.FileName);
                this.CreateUserList();
                this.clearLabels();
            }
        }

        // 閉じる
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 保存
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            XmlDeclaration declaration = xml.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = xml.CreateElement("userdata");
            XmlElement nodirtree = xml.CreateElement("dir");

            xml.AppendChild(declaration);

            foreach (TreeNode nodes in dbDirTree.Nodes[0].Nodes)
            {
                if (nodes.Tag == null)
                {
                    // フォルダ
                    XmlElement dir = xml.CreateElement("dir");
                    dir.SetAttribute("name", nodes.Text);

                    foreach (TreeNode detailnodes in nodes.Nodes)
                    {
                        XmlElement userdir = xml.CreateElement("user");
                        UserData udata = (UserData)detailnodes.Tag;

                        XmlElement userno = xml.CreateElement("no");
                        userno.InnerText = udata.no.ToString();
                        userdir.AppendChild(userno);

                        XmlElement userdata = xml.CreateElement("name");
                        userdata.InnerText = detailnodes.Text;
                        userdir.AppendChild(userdata);

                        XmlElement furigana = xml.CreateElement("furigana");
                        furigana.InnerText = udata.furigana;
                        userdir.AppendChild(furigana);

                        XmlElement birth_year = xml.CreateElement("birth_year");
                        birth_year.InnerText = udata.birth_year.ToString();
                        userdir.AppendChild(birth_year);

                        XmlElement birth_month = xml.CreateElement("birth_month");
                        birth_month.InnerText = udata.birth_month.ToString();
                        userdir.AppendChild(birth_month);

                        XmlElement birth_day = xml.CreateElement("birth_day");
                        birth_day.InnerText = udata.birth_day.ToString();
                        userdir.AppendChild(birth_day);

                        XmlElement birth_hour = xml.CreateElement("birth_hour");
                        birth_hour.InnerText = udata.birth_hour.ToString();
                        userdir.AppendChild(birth_hour);

                        XmlElement birth_minute = xml.CreateElement("birth_minute");
                        birth_minute.InnerText = udata.birth_minute.ToString();
                        userdir.AppendChild(birth_minute);

                        XmlElement birth_second = xml.CreateElement("birth_second");
                        birth_second.InnerText = udata.birth_second.ToString();
                        userdir.AppendChild(birth_second);

                        XmlElement birth_place = xml.CreateElement("birth_place");
                        birth_place.InnerText = udata.birth_place;
                        userdir.AppendChild(birth_place);

                        XmlElement lat = xml.CreateElement("lat");
                        lat.InnerText = udata.lat.ToString();
                        userdir.AppendChild(lat);

                        XmlElement lng = xml.CreateElement("lng");
                        lng.InnerText = udata.lng.ToString();
                        userdir.AppendChild(lng);

                        XmlElement memo = xml.CreateElement("memo");
                        memo.InnerText = udata.memo;
                        userdir.AppendChild(memo);

                        XmlElement timezone = xml.CreateElement("timezone");
                        timezone.InnerText = udata.timezone.ToString();
                        userdir.AppendChild(timezone);

                        XmlElement eventlist = xml.CreateElement("eventlist");

                        for (int i = 0; i < udata.userevent.Count; i++)
                        {
                            XmlElement eventdir = xml.CreateElement("event");
                            XmlElement eventname = xml.CreateElement("event_name");
                            eventname.InnerText = udata.userevent[i].event_name;
                            eventdir.AppendChild(eventname);
                            XmlElement eventdetail = xml.CreateElement("event_detail");
                            if (udata.userevent[i].event_detail == true)
                            {
                                XmlElement eventyear = xml.CreateElement("event_year");
                                eventyear.InnerText = udata.userevent[i].event_year.ToString();
                                eventdetail.AppendChild(eventyear);

                                XmlElement eventmonth = xml.CreateElement("event_month");
                                eventmonth.InnerText = udata.userevent[i].event_month.ToString();
                                eventdetail.AppendChild(eventmonth);

                                XmlElement eventday = xml.CreateElement("event_day");
                                eventday.InnerText = udata.userevent[i].event_day.ToString();
                                eventdetail.AppendChild(eventday);

                                XmlElement eventhour = xml.CreateElement("event_hour");
                                eventhour.InnerText = udata.userevent[i].event_hour.ToString();
                                eventdetail.AppendChild(eventhour);

                                XmlElement eventminute = xml.CreateElement("event_minute");
                                eventminute.InnerText = udata.userevent[i].event_minute.ToString();
                                eventdetail.AppendChild(eventminute);

                                XmlElement eventsecond = xml.CreateElement("event_second");
                                eventsecond.InnerText = udata.userevent[i].event_second.ToString();
                                eventdetail.AppendChild(eventsecond);

                                XmlElement eventplace = xml.CreateElement("event_place");
                                eventplace.InnerText = udata.userevent[i].event_place.ToString();
                                eventdetail.AppendChild(eventplace);

                                XmlElement eventlat = xml.CreateElement("event_lat");
                                eventlat.InnerText = udata.userevent[i].event_lat.ToString();
                                eventdetail.AppendChild(eventlat);

                                XmlElement eventlng = xml.CreateElement("event_lng");
                                eventlng.InnerText = udata.userevent[i].event_lng.ToString();
                                eventdetail.AppendChild(eventlng);

                                XmlElement eventmemo = xml.CreateElement("event_memo");
                                eventmemo.InnerText = udata.userevent[i].event_memo.ToString();
                                eventdetail.AppendChild(eventmemo);

                                XmlElement eventtimezone = xml.CreateElement("event_timezone");
                                eventtimezone.InnerText = udata.userevent[i].event_timezone.ToString();
                                eventdetail.AppendChild(eventtimezone);

                            }
                            eventdir.AppendChild(eventdetail);
                            eventlist.AppendChild(eventdir);

                        }
                        userdir.AppendChild(eventlist);

                        dir.AppendChild(userdir);
                    }

                    root.AppendChild(dir);
                }
                else
                {
                    XmlElement userdir = xml.CreateElement("user");
                    UserData udata = (UserData)nodes.Tag;

                    XmlElement userno = xml.CreateElement("no");
                    userno.InnerText = udata.no.ToString();
                    userdir.AppendChild(userno);

                    XmlElement userdata = xml.CreateElement("name");
                    userdata.InnerText = nodes.Text;
                    userdir.AppendChild(userdata);

                    XmlElement furigana = xml.CreateElement("furigana");
                    furigana.InnerText = udata.furigana;
                    userdir.AppendChild(furigana);

                    XmlElement birth_year = xml.CreateElement("birth_year");
                    birth_year.InnerText = udata.birth_year.ToString();
                    userdir.AppendChild(birth_year);

                    XmlElement birth_month = xml.CreateElement("birth_month");
                    birth_month.InnerText = udata.birth_month.ToString();
                    userdir.AppendChild(birth_month);

                    XmlElement birth_day = xml.CreateElement("birth_day");
                    birth_day.InnerText = udata.birth_day.ToString();
                    userdir.AppendChild(birth_day);

                    XmlElement birth_hour = xml.CreateElement("birth_hour");
                    birth_hour.InnerText = udata.birth_hour.ToString();
                    userdir.AppendChild(birth_hour);

                    XmlElement birth_minute = xml.CreateElement("birth_minute");
                    birth_minute.InnerText = udata.birth_minute.ToString();
                    userdir.AppendChild(birth_minute);

                    XmlElement birth_second = xml.CreateElement("birth_second");
                    birth_second.InnerText = udata.birth_second.ToString();
                    userdir.AppendChild(birth_second);

                    XmlElement birth_place = xml.CreateElement("birth_place");
                    birth_place.InnerText = udata.birth_place;
                    userdir.AppendChild(birth_place);

                    XmlElement lat = xml.CreateElement("lat");
                    lat.InnerText = udata.lat.ToString();
                    userdir.AppendChild(lat);

                    XmlElement lng = xml.CreateElement("lng");
                    lng.InnerText = udata.lng.ToString();
                    userdir.AppendChild(lng);

                    XmlElement memo = xml.CreateElement("memo");
                    memo.InnerText = udata.memo;
                    userdir.AppendChild(memo);

                    XmlElement timezone = xml.CreateElement("timezone");
                    timezone.InnerText = udata.timezone.ToString();
                    userdir.AppendChild(timezone);

                    XmlElement eventlist = xml.CreateElement("eventlist");

                    for (int i = 0; i < udata.userevent.Count; i++)
                    {
                        XmlElement eventdir = xml.CreateElement("event");
                        XmlElement eventname = xml.CreateElement("event_name");
                        eventname.InnerText = udata.userevent[i].event_name;
                        eventdir.AppendChild(eventname);
                        XmlElement eventdetail = xml.CreateElement("event_detail");
                        if (udata.userevent[i].event_detail == true)
                        {
                            XmlElement eventyear = xml.CreateElement("event_year");
                            eventyear.InnerText = udata.userevent[i].event_year.ToString();
                            eventdetail.AppendChild(eventyear);

                            XmlElement eventmonth = xml.CreateElement("event_month");
                            eventmonth.InnerText = udata.userevent[i].event_month.ToString();
                            eventdetail.AppendChild(eventmonth);

                            XmlElement eventday = xml.CreateElement("event_day");
                            eventday.InnerText = udata.userevent[i].event_day.ToString();
                            eventdetail.AppendChild(eventday);

                            XmlElement eventhour = xml.CreateElement("event_hour");
                            eventhour.InnerText = udata.userevent[i].event_hour.ToString();
                            eventdetail.AppendChild(eventhour);

                            XmlElement eventminute = xml.CreateElement("event_minute");
                            eventminute.InnerText = udata.userevent[i].event_minute.ToString();
                            eventdetail.AppendChild(eventminute);

                            XmlElement eventsecond = xml.CreateElement("event_second");
                            eventsecond.InnerText = udata.userevent[i].event_second.ToString();
                            eventdetail.AppendChild(eventsecond);

                            XmlElement eventplace = xml.CreateElement("event_place");
                            eventplace.InnerText = udata.userevent[i].event_place.ToString();
                            eventdetail.AppendChild(eventplace);

                            XmlElement eventlat = xml.CreateElement("event_lat");
                            eventlat.InnerText = udata.userevent[i].event_lat.ToString();
                            eventdetail.AppendChild(eventlat);

                            XmlElement eventlng = xml.CreateElement("event_lng");
                            eventlng.InnerText = udata.userevent[i].event_lng.ToString();
                            eventdetail.AppendChild(eventlng);

                            XmlElement eventmemo = xml.CreateElement("event_memo");
                            eventmemo.InnerText = udata.userevent[i].event_memo.ToString();
                            eventdetail.AppendChild(eventmemo);

                            XmlElement eventtimezone = xml.CreateElement("event_timezone");
                            eventtimezone.InnerText = udata.userevent[i].event_timezone.ToString();
                            eventdetail.AppendChild(eventtimezone);

                        }
                        eventdir.AppendChild(eventdetail);
                        eventlist.AppendChild(eventdir);
                    }

                    userdir.AppendChild(eventlist);

                    nodirtree.AppendChild(userdir);
                }
            }
            root.AppendChild(nodirtree);
            xml.AppendChild(root);
//            xml.Save(this.filename);
            xml.Save("test.xml");
        }

        private void edit_Click(object sender, EventArgs e)
        {
            TreeNode select = dbDirTree.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag == null)
            {
                DirEditForm edit = new DirEditForm(this, select.Index);
                edit.Show();
            }
            else
            {
                DBEditForm edit = new DBEditForm(this, select.Index, (UserData)select.Tag);
                edit.Show();
            }
        }

        public void setDirName(int index, string dirname)
        {
            dbDirTree.Nodes[index].Text = dirname;
        }

        private void dbDirTree_MouseUp(object sender, MouseEventArgs e)
        {
//            dbDirTree.SelectedNode = null;
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);

            }
        }

        private void addUser()
        {
            UserData addData = new UserData(
                9999,
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

            TreeNode node = new TreeNode("新規データ");
            node.Tag = addData;
            var index = dbDirTree.Nodes[0].Nodes.Add(node);
            //dbDirTree.SelectedNode = dbDirTree.Nodes[index];
            this.changed = true;

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = dbDirTree.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag == null)
            {
                DirEditForm edit = new DirEditForm(this, select.Index);
                edit.Show();
            }
            else
            {
                DBEditForm edit = new DBEditForm(this, select.Index, (UserData)select.Tag);
                edit.Show();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbDirTree.SelectedNode.Remove();
            this.clearLabels();
            this.changed = true;
        }

        private void addDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode("新規フォルダ");
            node.Tag = null;
            var index = dbDirTree.Nodes[0].Nodes.Add(node);
//            dbDirTree.SelectedNode = dbDirTree.Nodes[index];
            this.changed = true;
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
    }
}
