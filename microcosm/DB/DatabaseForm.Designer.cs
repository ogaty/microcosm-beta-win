namespace microcosm.DB
{
    partial class DatabaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dbDirTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.displayButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNameChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancel = new System.Windows.Forms.Button();
            this.eventListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.latlng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timezone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEvent3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbDirTree
            // 
            this.dbDirTree.LabelEdit = true;
            this.dbDirTree.Location = new System.Drawing.Point(12, 35);
            this.dbDirTree.Name = "dbDirTree";
            this.dbDirTree.Size = new System.Drawing.Size(121, 322);
            this.dbDirTree.TabIndex = 0;
            this.dbDirTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dbDirTree_AfterSelect);
            this.dbDirTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbDirTree_NodeMouseClick);
            this.dbDirTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.dbDirTree_DragDrop);
            this.dbDirTree.DragOver += new System.Windows.Forms.DragEventHandler(this.dbDirTree_DragOver);
            this.dbDirTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dbDirTree_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(629, 334);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "表示";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.addDirToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.fileNameChangeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 92);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addUserToolStripMenuItem.Text = "新規追加";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // addDirToolStripMenuItem
            // 
            this.addDirToolStripMenuItem.Name = "addDirToolStripMenuItem";
            this.addDirToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addDirToolStripMenuItem.Text = "フォルダの追加";
            this.addDirToolStripMenuItem.Click += new System.EventHandler(this.addDirToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteToolStripMenuItem.Text = "削除";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // fileNameChangeToolStripMenuItem
            // 
            this.fileNameChangeToolStripMenuItem.Name = "fileNameChangeToolStripMenuItem";
            this.fileNameChangeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fileNameChangeToolStripMenuItem.Text = "ファイル名の変更";
            this.fileNameChangeToolStripMenuItem.Click += new System.EventHandler(this.fileNameChangeToolStripMenuItem_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(710, 334);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "キャンセル";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // eventListView
            // 
            this.eventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.time,
            this.place,
            this.latlng,
            this.timezone});
            this.eventListView.ContextMenuStrip = this.contextMenuStrip2;
            this.eventListView.FullRowSelect = true;
            this.eventListView.Location = new System.Drawing.Point(159, 35);
            this.eventListView.Name = "eventListView";
            this.eventListView.Size = new System.Drawing.Size(626, 212);
            this.eventListView.TabIndex = 22;
            this.eventListView.UseCompatibleStateImageBehavior = false;
            this.eventListView.View = System.Windows.Forms.View.Details;
            this.eventListView.SelectedIndexChanged += new System.EventHandler(this.eventListView_SelectedIndexChanged);
            this.eventListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.eventListView_MouseDown);
            // 
            // name
            // 
            this.name.Text = "名前";
            this.name.Width = 120;
            // 
            // time
            // 
            this.time.Text = "時刻";
            this.time.Width = 150;
            // 
            // place
            // 
            this.place.Text = "場所";
            this.place.Width = 100;
            // 
            // latlng
            // 
            this.latlng.Text = "緯度経度";
            this.latlng.Width = 120;
            // 
            // timezone
            // 
            this.timezone.Text = "タイムゾーン";
            this.timezone.Width = 80;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(134, 26);
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.addEventToolStripMenuItem.Text = "イベント追加";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.addEventToolStripMenuItem_Click);
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(159, 253);
            this.memo.Multiline = true;
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(626, 75);
            this.memo.TabIndex = 23;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.addEvent3ToolStripMenuItem,
            this.deleteEventToolStripMenuItem,
            this.editEventToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(134, 92);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.displayToolStripMenuItem.Text = "表示";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // addEvent3ToolStripMenuItem
            // 
            this.addEvent3ToolStripMenuItem.Name = "addEvent3ToolStripMenuItem";
            this.addEvent3ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.addEvent3ToolStripMenuItem.Text = "イベント追加";
            this.addEvent3ToolStripMenuItem.Click += new System.EventHandler(this.addEvent3ToolStripMenuItem_Click);
            // 
            // deleteEventToolStripMenuItem
            // 
            this.deleteEventToolStripMenuItem.Name = "deleteEventToolStripMenuItem";
            this.deleteEventToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteEventToolStripMenuItem.Text = "イベント削除";
            this.deleteEventToolStripMenuItem.Click += new System.EventHandler(this.deleteEventToolStripMenuItem_Click);
            // 
            // editEventToolStripMenuItem
            // 
            this.editEventToolStripMenuItem.Name = "editEventToolStripMenuItem";
            this.editEventToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editEventToolStripMenuItem.Text = "編集";
            this.editEventToolStripMenuItem.Click += new System.EventHandler(this.editEventToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.toolStripMenuItem1.Text = "データベース(&D)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "閉じる(&X)";
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(797, 369);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.eventListView);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.dbDirTree);
            this.Name = "DatabaseForm";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView dbDirTree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDirToolStripMenuItem;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ListView eventListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader place;
        private System.Windows.Forms.ColumnHeader latlng;
        private System.Windows.Forms.ColumnHeader timezone;
        private System.Windows.Forms.TextBox memo;
        private System.Windows.Forms.ToolStripMenuItem fileNameChangeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEvent3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEventToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}