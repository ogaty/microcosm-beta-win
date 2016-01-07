using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
