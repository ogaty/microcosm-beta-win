namespace microcosm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.データベースDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancel = new System.Windows.Forms.Button();
            this.eventListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.latlng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timezone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memo = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbDirTree
            // 
            this.dbDirTree.Location = new System.Drawing.Point(12, 27);
            this.dbDirTree.Name = "dbDirTree";
            this.dbDirTree.Size = new System.Drawing.Size(121, 330);
            this.dbDirTree.TabIndex = 0;
            this.dbDirTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.dbDirTree_ItemDrag);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.データベースDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // データベースDToolStripMenuItem
            // 
            this.データベースDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.データベースDToolStripMenuItem.Name = "データベースDToolStripMenuItem";
            this.データベースDToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.データベースDToolStripMenuItem.Text = "データベース(&D)";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveToolStripMenuItem.Text = "上書き保存(&S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cancelToolStripMenuItem.Text = "閉じる(&X)";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
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
            this.eventListView.Location = new System.Drawing.Point(159, 27);
            this.eventListView.Name = "eventListView";
            this.eventListView.Size = new System.Drawing.Size(626, 220);
            this.eventListView.TabIndex = 22;
            this.eventListView.UseCompatibleStateImageBehavior = false;
            this.eventListView.View = System.Windows.Forms.View.Details;
            this.eventListView.SelectedIndexChanged += new System.EventHandler(this.eventListView_SelectedIndexChanged);
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
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(159, 253);
            this.memo.Multiline = true;
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(626, 75);
            this.memo.TabIndex = 23;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(548, 334);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 24;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
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
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(797, 369);
            this.Controls.Add(this.save);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.eventListView);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.dbDirTree);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DatabaseForm";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem データベースDToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ListView eventListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader place;
        private System.Windows.Forms.ColumnHeader latlng;
        private System.Windows.Forms.ColumnHeader timezone;
        private System.Windows.Forms.TextBox memo;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ToolStripMenuItem fileNameChangeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
    }
}