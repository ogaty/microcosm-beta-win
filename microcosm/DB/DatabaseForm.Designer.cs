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
            this.panel1 = new System.Windows.Forms.Panel();
            this.birthlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新規追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォルダの追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.データベースDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.placelabel = new System.Windows.Forms.Label();
            this.latlnglabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timezoneLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.memoLabel = new System.Windows.Forms.Label();
            this.eventList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eventBirthLabel = new System.Windows.Forms.Label();
            this.eventPlaceLabel = new System.Windows.Forms.Label();
            this.eventLatlngLabel = new System.Windows.Forms.Label();
            this.eventTimezoneLabel = new System.Windows.Forms.Label();
            this.eventMemoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbDirTree
            // 
            this.dbDirTree.Location = new System.Drawing.Point(12, 27);
            this.dbDirTree.Name = "dbDirTree";
            this.dbDirTree.Size = new System.Drawing.Size(121, 330);
            this.dbDirTree.TabIndex = 0;
            this.dbDirTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dbDirTree_AfterSelect);
            this.dbDirTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbDirTree_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.eventMemoLabel);
            this.panel1.Controls.Add(this.eventTimezoneLabel);
            this.panel1.Controls.Add(this.eventLatlngLabel);
            this.panel1.Controls.Add(this.eventPlaceLabel);
            this.panel1.Controls.Add(this.eventBirthLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.eventList);
            this.panel1.Controls.Add(this.memoLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.timezoneLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.latlnglabel);
            this.panel1.Controls.Add(this.placelabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.birthlabel);
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Location = new System.Drawing.Point(155, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 301);
            this.panel1.TabIndex = 1;
            // 
            // birthlabel
            // 
            this.birthlabel.AutoSize = true;
            this.birthlabel.Location = new System.Drawing.Point(24, 82);
            this.birthlabel.Name = "birthlabel";
            this.birthlabel.Size = new System.Drawing.Size(28, 12);
            this.birthlabel.TabIndex = 1;
            this.birthlabel.Text = "birth";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(24, 38);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(32, 12);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "name";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(584, 334);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "表示";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(503, 334);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(340, 334);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(422, 334);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 5;
            this.edit.Text = "編集";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規追加ToolStripMenuItem,
            this.編集ToolStripMenuItem,
            this.削除ToolStripMenuItem,
            this.フォルダの追加ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 92);
            // 
            // 新規追加ToolStripMenuItem
            // 
            this.新規追加ToolStripMenuItem.Name = "新規追加ToolStripMenuItem";
            this.新規追加ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.新規追加ToolStripMenuItem.Text = "新規追加";
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.編集ToolStripMenuItem.Text = "編集";
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.削除ToolStripMenuItem.Text = "削除";
            // 
            // フォルダの追加ToolStripMenuItem
            // 
            this.フォルダの追加ToolStripMenuItem.Name = "フォルダの追加ToolStripMenuItem";
            this.フォルダの追加ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.フォルダの追加ToolStripMenuItem.Text = "フォルダの追加";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.データベースDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // データベースDToolStripMenuItem
            // 
            this.データベースDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeDBToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.データベースDToolStripMenuItem.Name = "データベースDToolStripMenuItem";
            this.データベースDToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.データベースDToolStripMenuItem.Text = "データベース(&D)";
            // 
            // ChangeDBToolStripMenuItem
            // 
            this.ChangeDBToolStripMenuItem.Name = "ChangeDBToolStripMenuItem";
            this.ChangeDBToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ChangeDBToolStripMenuItem.Text = "データベース切り替え(&D)";
            this.ChangeDBToolStripMenuItem.Click += new System.EventHandler(this.ChangeDBToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "上書き保存(&S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cancelToolStripMenuItem.Text = "閉じる(&X)";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "出生時刻";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "出生地";
            // 
            // placelabel
            // 
            this.placelabel.AutoSize = true;
            this.placelabel.Location = new System.Drawing.Point(24, 130);
            this.placelabel.Name = "placelabel";
            this.placelabel.Size = new System.Drawing.Size(32, 12);
            this.placelabel.TabIndex = 5;
            this.placelabel.Text = "place";
            // 
            // latlnglabel
            // 
            this.latlnglabel.AutoSize = true;
            this.latlnglabel.Location = new System.Drawing.Point(24, 154);
            this.latlnglabel.Name = "latlnglabel";
            this.latlnglabel.Size = new System.Drawing.Size(33, 12);
            this.latlnglabel.TabIndex = 6;
            this.latlnglabel.Text = "latlng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "タイムゾーン";
            // 
            // timezoneLabel
            // 
            this.timezoneLabel.AutoSize = true;
            this.timezoneLabel.Location = new System.Drawing.Point(24, 203);
            this.timezoneLabel.Name = "timezoneLabel";
            this.timezoneLabel.Size = new System.Drawing.Size(50, 12);
            this.timezoneLabel.TabIndex = 8;
            this.timezoneLabel.Text = "timezone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "memo";
            // 
            // memoLabel
            // 
            this.memoLabel.AutoSize = true;
            this.memoLabel.Location = new System.Drawing.Point(24, 250);
            this.memoLabel.Name = "memoLabel";
            this.memoLabel.Size = new System.Drawing.Size(41, 24);
            this.memoLabel.TabIndex = 10;
            this.memoLabel.Text = "memo\r\nmemo1";
            // 
            // eventList
            // 
            this.eventList.FormattingEnabled = true;
            this.eventList.ItemHeight = 12;
            this.eventList.Location = new System.Drawing.Point(364, 15);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(120, 268);
            this.eventList.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "イベント時刻";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "発生地";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "タイムゾーン";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "memo";
            // 
            // eventBirthLabel
            // 
            this.eventBirthLabel.AutoSize = true;
            this.eventBirthLabel.Location = new System.Drawing.Point(183, 82);
            this.eventBirthLabel.Name = "eventBirthLabel";
            this.eventBirthLabel.Size = new System.Drawing.Size(28, 12);
            this.eventBirthLabel.TabIndex = 16;
            this.eventBirthLabel.Text = "birth";
            // 
            // eventPlaceLabel
            // 
            this.eventPlaceLabel.AutoSize = true;
            this.eventPlaceLabel.Location = new System.Drawing.Point(183, 130);
            this.eventPlaceLabel.Name = "eventPlaceLabel";
            this.eventPlaceLabel.Size = new System.Drawing.Size(32, 12);
            this.eventPlaceLabel.TabIndex = 17;
            this.eventPlaceLabel.Text = "place";
            // 
            // eventLatlngLabel
            // 
            this.eventLatlngLabel.AutoSize = true;
            this.eventLatlngLabel.Location = new System.Drawing.Point(183, 154);
            this.eventLatlngLabel.Name = "eventLatlngLabel";
            this.eventLatlngLabel.Size = new System.Drawing.Size(33, 12);
            this.eventLatlngLabel.TabIndex = 18;
            this.eventLatlngLabel.Text = "latlng";
            // 
            // eventTimezoneLabel
            // 
            this.eventTimezoneLabel.AutoSize = true;
            this.eventTimezoneLabel.Location = new System.Drawing.Point(183, 203);
            this.eventTimezoneLabel.Name = "eventTimezoneLabel";
            this.eventTimezoneLabel.Size = new System.Drawing.Size(50, 12);
            this.eventTimezoneLabel.TabIndex = 19;
            this.eventTimezoneLabel.Text = "timezone";
            // 
            // eventMemoLabel
            // 
            this.eventMemoLabel.AutoSize = true;
            this.eventMemoLabel.Location = new System.Drawing.Point(183, 250);
            this.eventMemoLabel.Name = "eventMemoLabel";
            this.eventMemoLabel.Size = new System.Drawing.Size(41, 24);
            this.eventMemoLabel.TabIndex = 20;
            this.eventMemoLabel.Text = "memo\r\nmemo1";
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(671, 369);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dbDirTree);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DatabaseForm";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView dbDirTree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label birthlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新規追加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォルダの追加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem データベースDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeDBToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.Label memoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timezoneLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label latlnglabel;
        private System.Windows.Forms.Label placelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox eventList;
        private System.Windows.Forms.Label eventMemoLabel;
        private System.Windows.Forms.Label eventTimezoneLabel;
        private System.Windows.Forms.Label eventLatlngLabel;
        private System.Windows.Forms.Label eventPlaceLabel;
        private System.Windows.Forms.Label eventBirthLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}