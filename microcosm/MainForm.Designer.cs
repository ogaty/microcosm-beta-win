namespace microcosm
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDatabaseOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オプションOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.placeLabel = new System.Windows.Forms.Label();
            this.latLabel = new System.Windows.Forms.Label();
            this.lngLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.astroWindow = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.centerSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.astroWindow)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileFToolStripMenuItem,
            this.オプションOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileFToolStripMenuItem
            // 
            this.FileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenDatabaseOToolStripMenuItem,
            this.ChangeDatabaseToolStripMenuItem});
            this.FileFToolStripMenuItem.Name = "FileFToolStripMenuItem";
            this.FileFToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.FileFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // OpenDatabaseOToolStripMenuItem
            // 
            this.OpenDatabaseOToolStripMenuItem.Name = "OpenDatabaseOToolStripMenuItem";
            this.OpenDatabaseOToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.OpenDatabaseOToolStripMenuItem.Text = "データベースを開く(&N)";
            this.OpenDatabaseOToolStripMenuItem.Click += new System.EventHandler(this.OpenDatabaseOToolStripMenuItem_Click);
            // 
            // ChangeDatabaseToolStripMenuItem
            // 
            this.ChangeDatabaseToolStripMenuItem.Name = "ChangeDatabaseToolStripMenuItem";
            this.ChangeDatabaseToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ChangeDatabaseToolStripMenuItem.Text = "データベースを変更(&O)";
            this.ChangeDatabaseToolStripMenuItem.Click += new System.EventHandler(this.ChangeDatabaseToolStripMenuItem_Click);
            // 
            // オプションOToolStripMenuItem
            // 
            this.オプションOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigToolStripMenuItem});
            this.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem";
            this.オプションOToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.オプションOToolStripMenuItem.Text = "オプション(&O)";
            // 
            // ConfigToolStripMenuItem
            // 
            this.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem";
            this.ConfigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ConfigToolStripMenuItem.Text = "設定(&C)";
            this.ConfigToolStripMenuItem.Click += new System.EventHandler(this.ConfigToolStripMenuItem_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(6, 15);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(29, 12);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "現在";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Location = new System.Drawing.Point(6, 33);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(121, 12);
            this.birthLabel.TabIndex = 2;
            this.birthLabel.Text = "1970年1月1日 12:00:00";
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Location = new System.Drawing.Point(6, 49);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(81, 12);
            this.placeLabel.TabIndex = 3;
            this.placeLabel.Text = "東京都 中央区";
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.Location = new System.Drawing.Point(6, 66);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(55, 12);
            this.latLabel.TabIndex = 4;
            this.latLabel.Text = "37.000000";
            // 
            // lngLabel
            // 
            this.lngLabel.AutoSize = true;
            this.lngLabel.Location = new System.Drawing.Point(67, 66);
            this.lngLabel.Name = "lngLabel";
            this.lngLabel.Size = new System.Drawing.Size(61, 12);
            this.lngLabel.TabIndex = 5;
            this.lngLabel.Text = "137.000000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 464);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usernameLabel);
            this.groupBox1.Controls.Add(this.lngLabel);
            this.groupBox1.Controls.Add(this.birthLabel);
            this.groupBox1.Controls.Add(this.latLabel);
            this.groupBox1.Controls.Add(this.placeLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 464);
            this.panel3.TabIndex = 1;
            // 
            // astroWindow
            // 
            this.astroWindow.BackColor = System.Drawing.Color.PaleTurquoise;
            this.astroWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.astroWindow.Location = new System.Drawing.Point(200, 24);
            this.astroWindow.Name = "astroWindow";
            this.astroWindow.Size = new System.Drawing.Size(704, 464);
            this.astroWindow.TabIndex = 7;
            this.astroWindow.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.centerSlider);
            this.groupBox2.Location = new System.Drawing.Point(692, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "サイズ";
            // 
            // centerSlider
            // 
            this.centerSlider.Location = new System.Drawing.Point(90, 18);
            this.centerSlider.Maximum = 120;
            this.centerSlider.Minimum = 60;
            this.centerSlider.Name = "centerSlider";
            this.centerSlider.Size = new System.Drawing.Size(104, 45);
            this.centerSlider.TabIndex = 0;
            this.centerSlider.Value = 90;
            this.centerSlider.Scroll += new System.EventHandler(this.centerSlider_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "中心円";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(904, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.astroWindow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "microcosm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.astroWindow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenDatabaseOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeDatabaseToolStripMenuItem;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label lngLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem オプションOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfigToolStripMenuItem;
        private System.Windows.Forms.PictureBox astroWindow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar centerSlider;
    }
}

