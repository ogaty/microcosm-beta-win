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

        // 選択した時
        private void dbDirTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (Directory.Exists(e.Node.Tag.ToString())) return;

            XMLDBManager DBMgr = new XMLDBManager(e.Node.Tag.ToString());
            UserData data = DBMgr.getObject();

            eventListView.Items.Clear();
            this.setBirth(data.name,
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

            if (data.userevent == null)
            {
                return;
            }

            foreach (UserEvent ev in data.userevent)
            {
                setEventData(ev.event_name,
                    String.Format("{0}年{1}月{2}日 {3:00}:{4:00}:{5:00}",
                        ev.event_year,
                        ev.event_month,
                        ev.event_day,
                        ev.event_hour,
                        ev.event_minute,
                        ev.event_second
                    ),
                    ev.event_place,
                    String.Format("({0},{1})", ev.event_lat, ev.event_lng),
                    ev.event_timezone,
                    ev.event_memo
                 );
            }

            return;
        }

        // ラベルクリア
        private void clearLabels()
        {
            eventListView.Items.Clear();
        }
        // ラベル設定
        private void setBirth(string name, string birth_text, string birth_place, string latlng_text, string timezone, string memo)
        {
            ListViewItem item = new ListViewItem(name);
            string[] subitems = { birth_text, birth_place, latlng_text, timezone };
            item.SubItems.AddRange(subitems);
            item.Tag = memo;
            eventListView.Items.Add(item);
        }

        private void setEventData(string event_name, string event_birth_text, string event_place, string event_latlng, string event_timezone, string event_memo)
        {
            ListViewItem item = new ListViewItem("- " + event_name);
            string[] subitems = { event_birth_text, event_place, event_latlng, event_timezone, event_memo };
            item.SubItems.AddRange(subitems);
            item.Tag = event_memo;
            eventListView.Items.Add(item);
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
//                this.DBMgr = new XMLDBManager(ofd.FileName);
//                this.CreateUserList();
//                this.clearLabels();
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
                            /*
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
                            */
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
                        /*
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
                        */
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
            MessageBox.Show(datadir + @"\user" + i.ToString() + ".csm");
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

        // リストを選択
        private void eventListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListView)sender).SelectedItems.Count == 0)
            {
                return;
            }

            if (((ListView)sender).SelectedItems[0].Tag != null) {
                memo.Text = (string)((ListView)sender).SelectedItems[0].Tag.ToString();
            }
        }

        private void fileNameChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirEditForm diredit = new DirEditForm(this, dbDirTree.SelectedNode.Tag.ToString());
            diredit.Show();
        }


    }
}
