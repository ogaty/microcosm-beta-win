using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace microcosm.DB
{
    public partial class DatabaseForm
    {
        // リストを選択
        private void eventListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView view = (ListView)sender;

            if (view.SelectedItems.Count == 0)
            {
                return;
            }

            if (view.SelectedItems[0].Tag != null)
            {
                User u = (User)view.SelectedItems[0].Tag;
                if (u.uevent == null)
                {
                    UserData udata = u.udata;
                    memo.Text = udata.memo.ToString();
                }
                else
                {
                    UserEvent uevent = u.uevent;
                    memo.Text = uevent.event_memo.ToString();
                }
            }
        }


        // リストビュー右クリック
        private void eventListView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (eventListView.FocusedItem == null)
                {
                    contextMenuStrip2.Show(e.Location);
                    return;
                }

                if (eventListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    eventListView.ContextMenuStrip = contextMenuStrip3;
                }
                else
                {
                    eventListView.ContextMenuStrip = contextMenuStrip2;
                }
            }

        }

        // リスト右クリック→追加
        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewEvent();
        }

        // リスト選択時右クリック新規イベント追加
        private void addEvent3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewEvent();
        }

        // リスト右クリックイベント追加
        private void addNewEvent()
        {
            UserEvent uevent = new UserEvent(
                "新規イベント",
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second,
                "東京都中央区",
                38,
                138,
                "JST",
                "");
            User u = (User)eventListView.Items[0].Tag;
            u.udata.userevent.Add(uevent);

            XmlSerializer serializer = new XmlSerializer(typeof(UserData));
            FileStream fs = new FileStream(u.filename, FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            serializer.Serialize(sw, u.udata);
            sw.Close();
            fs.Close();

            eventListViewRender(u.udata, u.filename);
        }

        // リスト再描画
        public void eventListViewRender(UserData data, string filename)
        {
            eventListView.Items.Clear();
//            this.setBirth(data, datadir + @"\" + e.Node.Text);
            this.setBirth(data, filename);

            if (data.userevent == null)
            {
                return;
            }

            int i = 0;
            data.userevent.ForEach(ev =>
            {
                setEventData(ev, datadir + @"\" + filename, i);
                i++;
            });
        }

        // 右クリック削除
        private void deleteEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eventListView.SelectedItems.Count == 0)
            {
                return;
            }

            User u = (User)eventListView.Items[0].Tag;

            int index = eventListView.SelectedItems[0].Index;
            eventListView.Items[index].Remove();
            u.udata.userevent.RemoveAt(index);

            XmlSerializer serializer = new XmlSerializer(typeof(UserData));
            if (File.Exists(u.filename))
            {
                File.Delete(u.filename);
            }
            FileStream fs = new FileStream(u.filename, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            serializer.Serialize(sw, u.udata);
            sw.Close();
            fs.Close();

        }

        private void eventListView_DoubleClick(object sender, EventArgs e)
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

    }
}
