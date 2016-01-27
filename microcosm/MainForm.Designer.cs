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
            this.表示DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.チャートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripleChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オプションOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.placeLabel = new System.Windows.Forms.Label();
            this.latLabel = new System.Windows.Forms.Label();
            this.lngLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.progressionLabel = new System.Windows.Forms.Label();
            this.cusp12 = new System.Windows.Forms.Label();
            this.cusp11 = new System.Windows.Forms.Label();
            this.cusp10 = new System.Windows.Forms.Label();
            this.cusp9 = new System.Windows.Forms.Label();
            this.cusp8 = new System.Windows.Forms.Label();
            this.cusp7 = new System.Windows.Forms.Label();
            this.cusp6 = new System.Windows.Forms.Label();
            this.cusp5 = new System.Windows.Forms.Label();
            this.cusp4 = new System.Windows.Forms.Label();
            this.cusp3 = new System.Windows.Forms.Label();
            this.cusp2 = new System.Windows.Forms.Label();
            this.cusp1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.placidusLabel = new System.Windows.Forms.Label();
            this.centricLabel = new System.Windows.Forms.Label();
            this.tropicalLabel = new System.Windows.Forms.Label();
            this.planetList = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.centerSlider = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.chartPanel = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventLngLabel = new System.Windows.Forms.Label();
            this.eventDateLabel = new System.Windows.Forms.Label();
            this.eventLatLabel = new System.Windows.Forms.Label();
            this.eventPlaceLabel = new System.Windows.Forms.Label();
            this.aspectSelect = new System.Windows.Forms.ComboBox();
            this.DisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NowDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPanel)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileFToolStripMenuItem,
            this.表示DToolStripMenuItem,
            this.オプションOToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileFToolStripMenuItem
            // 
            this.FileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenDatabaseOToolStripMenuItem,
            this.NowDataToolStripMenuItem});
            this.FileFToolStripMenuItem.Name = "FileFToolStripMenuItem";
            this.FileFToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.FileFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // OpenDatabaseOToolStripMenuItem
            // 
            this.OpenDatabaseOToolStripMenuItem.Name = "OpenDatabaseOToolStripMenuItem";
            this.OpenDatabaseOToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.OpenDatabaseOToolStripMenuItem.Text = "データベースを開く(&O)";
            this.OpenDatabaseOToolStripMenuItem.Click += new System.EventHandler(this.OpenDatabaseOToolStripMenuItem_Click);
            // 
            // 表示DToolStripMenuItem
            // 
            this.表示DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.チャートToolStripMenuItem});
            this.表示DToolStripMenuItem.Name = "表示DToolStripMenuItem";
            this.表示DToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.表示DToolStripMenuItem.Text = "表示(&D)";
            // 
            // チャートToolStripMenuItem
            // 
            this.チャートToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleChartToolStripMenuItem,
            this.tripleChartToolStripMenuItem});
            this.チャートToolStripMenuItem.Name = "チャートToolStripMenuItem";
            this.チャートToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.チャートToolStripMenuItem.Text = "チャート";
            // 
            // singleChartToolStripMenuItem
            // 
            this.singleChartToolStripMenuItem.Checked = true;
            this.singleChartToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.singleChartToolStripMenuItem.Name = "singleChartToolStripMenuItem";
            this.singleChartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.singleChartToolStripMenuItem.Text = "一重円";
            this.singleChartToolStripMenuItem.Click += new System.EventHandler(this.singleChartToolStripMenuItem_Click);
            // 
            // tripleChartToolStripMenuItem
            // 
            this.tripleChartToolStripMenuItem.Name = "tripleChartToolStripMenuItem";
            this.tripleChartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.tripleChartToolStripMenuItem.Text = "三重円";
            this.tripleChartToolStripMenuItem.Click += new System.EventHandler(this.tripleChartToolStripMenuItem_Click);
            // 
            // オプションOToolStripMenuItem
            // 
            this.オプションOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigToolStripMenuItem,
            this.DisplayToolStripMenuItem});
            this.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem";
            this.オプションOToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.オプションOToolStripMenuItem.Text = "オプション(&O)";
            // 
            // ConfigToolStripMenuItem
            // 
            this.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem";
            this.ConfigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ConfigToolStripMenuItem.Text = "共通設定(&C)";
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
            this.panel1.Controls.Add(this.leftPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 614);
            this.panel1.TabIndex = 6;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.Window;
            this.leftPanel.Controls.Add(this.progressionLabel);
            this.leftPanel.Controls.Add(this.cusp12);
            this.leftPanel.Controls.Add(this.cusp11);
            this.leftPanel.Controls.Add(this.cusp10);
            this.leftPanel.Controls.Add(this.cusp9);
            this.leftPanel.Controls.Add(this.cusp8);
            this.leftPanel.Controls.Add(this.cusp7);
            this.leftPanel.Controls.Add(this.cusp6);
            this.leftPanel.Controls.Add(this.cusp5);
            this.leftPanel.Controls.Add(this.cusp4);
            this.leftPanel.Controls.Add(this.cusp3);
            this.leftPanel.Controls.Add(this.cusp2);
            this.leftPanel.Controls.Add(this.cusp1);
            this.leftPanel.Controls.Add(this.label14);
            this.leftPanel.Controls.Add(this.label13);
            this.leftPanel.Controls.Add(this.label12);
            this.leftPanel.Controls.Add(this.label11);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.label9);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.groupBox1);
            this.leftPanel.Controls.Add(this.placidusLabel);
            this.leftPanel.Controls.Add(this.centricLabel);
            this.leftPanel.Controls.Add(this.tropicalLabel);
            this.leftPanel.Controls.Add(this.planetList);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(259, 614);
            this.leftPanel.TabIndex = 1;
            // 
            // progressionLabel
            // 
            this.progressionLabel.AutoSize = true;
            this.progressionLabel.Location = new System.Drawing.Point(19, 593);
            this.progressionLabel.Name = "progressionLabel";
            this.progressionLabel.Size = new System.Drawing.Size(65, 12);
            this.progressionLabel.TabIndex = 34;
            this.progressionLabel.Text = "一日一年法";
            // 
            // cusp12
            // 
            this.cusp12.AutoSize = true;
            this.cusp12.Location = new System.Drawing.Point(80, 545);
            this.cusp12.Name = "cusp12";
            this.cusp12.Size = new System.Drawing.Size(37, 12);
            this.cusp12.TabIndex = 33;
            this.cusp12.Text = "00.000";
            // 
            // cusp11
            // 
            this.cusp11.AutoSize = true;
            this.cusp11.Location = new System.Drawing.Point(80, 530);
            this.cusp11.Name = "cusp11";
            this.cusp11.Size = new System.Drawing.Size(37, 12);
            this.cusp11.TabIndex = 32;
            this.cusp11.Text = "00.000";
            // 
            // cusp10
            // 
            this.cusp10.AutoSize = true;
            this.cusp10.Location = new System.Drawing.Point(80, 513);
            this.cusp10.Name = "cusp10";
            this.cusp10.Size = new System.Drawing.Size(37, 12);
            this.cusp10.TabIndex = 31;
            this.cusp10.Text = "00.000";
            // 
            // cusp9
            // 
            this.cusp9.AutoSize = true;
            this.cusp9.Location = new System.Drawing.Point(80, 496);
            this.cusp9.Name = "cusp9";
            this.cusp9.Size = new System.Drawing.Size(37, 12);
            this.cusp9.TabIndex = 30;
            this.cusp9.Text = "00.000";
            // 
            // cusp8
            // 
            this.cusp8.AutoSize = true;
            this.cusp8.Location = new System.Drawing.Point(80, 478);
            this.cusp8.Name = "cusp8";
            this.cusp8.Size = new System.Drawing.Size(37, 12);
            this.cusp8.TabIndex = 29;
            this.cusp8.Text = "00.000";
            // 
            // cusp7
            // 
            this.cusp7.AutoSize = true;
            this.cusp7.Location = new System.Drawing.Point(80, 461);
            this.cusp7.Name = "cusp7";
            this.cusp7.Size = new System.Drawing.Size(37, 12);
            this.cusp7.TabIndex = 28;
            this.cusp7.Text = "00.000";
            // 
            // cusp6
            // 
            this.cusp6.AutoSize = true;
            this.cusp6.Location = new System.Drawing.Point(80, 443);
            this.cusp6.Name = "cusp6";
            this.cusp6.Size = new System.Drawing.Size(37, 12);
            this.cusp6.TabIndex = 27;
            this.cusp6.Text = "00.000";
            // 
            // cusp5
            // 
            this.cusp5.AutoSize = true;
            this.cusp5.Location = new System.Drawing.Point(80, 428);
            this.cusp5.Name = "cusp5";
            this.cusp5.Size = new System.Drawing.Size(37, 12);
            this.cusp5.TabIndex = 26;
            this.cusp5.Text = "00.000";
            // 
            // cusp4
            // 
            this.cusp4.AutoSize = true;
            this.cusp4.Location = new System.Drawing.Point(80, 410);
            this.cusp4.Name = "cusp4";
            this.cusp4.Size = new System.Drawing.Size(37, 12);
            this.cusp4.TabIndex = 25;
            this.cusp4.Text = "00.000";
            // 
            // cusp3
            // 
            this.cusp3.AutoSize = true;
            this.cusp3.Location = new System.Drawing.Point(80, 391);
            this.cusp3.Name = "cusp3";
            this.cusp3.Size = new System.Drawing.Size(37, 12);
            this.cusp3.TabIndex = 24;
            this.cusp3.Text = "00.000";
            // 
            // cusp2
            // 
            this.cusp2.AutoSize = true;
            this.cusp2.Location = new System.Drawing.Point(80, 372);
            this.cusp2.Name = "cusp2";
            this.cusp2.Size = new System.Drawing.Size(37, 12);
            this.cusp2.TabIndex = 23;
            this.cusp2.Text = "00.000";
            // 
            // cusp1
            // 
            this.cusp1.AutoSize = true;
            this.cusp1.Location = new System.Drawing.Point(80, 353);
            this.cusp1.Name = "cusp1";
            this.cusp1.Size = new System.Drawing.Size(37, 12);
            this.cusp1.TabIndex = 22;
            this.cusp1.Text = "00.000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 545);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "Ⅻ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 530);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 20;
            this.label13.Text = "Ⅺ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 513);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "Ⅹ(MC)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 496);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "Ⅸ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 478);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ⅷ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ⅶ(DSC)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ⅵ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ⅴ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ⅳ(IC)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ⅲ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ⅱ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ⅰ(ASC)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usernameLabel);
            this.groupBox1.Controls.Add(this.lngLabel);
            this.groupBox1.Controls.Add(this.birthLabel);
            this.groupBox1.Controls.Add(this.latLabel);
            this.groupBox1.Controls.Add(this.placeLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // placidusLabel
            // 
            this.placidusLabel.AutoSize = true;
            this.placidusLabel.Location = new System.Drawing.Point(19, 572);
            this.placidusLabel.Name = "placidusLabel";
            this.placidusLabel.Size = new System.Drawing.Size(47, 12);
            this.placidusLabel.TabIndex = 3;
            this.placidusLabel.Text = "placidus";
            // 
            // centricLabel
            // 
            this.centricLabel.AutoSize = true;
            this.centricLabel.Location = new System.Drawing.Point(93, 572);
            this.centricLabel.Name = "centricLabel";
            this.centricLabel.Size = new System.Drawing.Size(58, 12);
            this.centricLabel.TabIndex = 2;
            this.centricLabel.Text = "geocentric";
            // 
            // tropicalLabel
            // 
            this.tropicalLabel.AutoSize = true;
            this.tropicalLabel.Location = new System.Drawing.Point(177, 572);
            this.tropicalLabel.Name = "tropicalLabel";
            this.tropicalLabel.Size = new System.Drawing.Size(43, 12);
            this.tropicalLabel.TabIndex = 1;
            this.tropicalLabel.Text = "tropical";
            // 
            // planetList
            // 
            this.planetList.Location = new System.Drawing.Point(13, 109);
            this.planetList.Name = "planetList";
            this.planetList.Size = new System.Drawing.Size(227, 221);
            this.planetList.TabIndex = 0;
            this.planetList.UseCompatibleStateImageBehavior = false;
            this.planetList.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.centerSlider);
            this.groupBox2.Location = new System.Drawing.Point(692, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "サイズ";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // chartPanel
            // 
            this.chartPanel.BackColor = System.Drawing.Color.LightCyan;
            this.chartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel.Location = new System.Drawing.Point(262, 24);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(752, 614);
            this.chartPanel.TabIndex = 10;
            this.chartPanel.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.aspectSelect);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(854, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 614);
            this.panel2.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.eventNameLabel);
            this.groupBox3.Controls.Add(this.eventLngLabel);
            this.groupBox3.Controls.Add(this.eventDateLabel);
            this.groupBox3.Controls.Add(this.eventLatLabel);
            this.groupBox3.Controls.Add(this.eventPlaceLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(6, 15);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(29, 12);
            this.eventNameLabel.TabIndex = 1;
            this.eventNameLabel.Text = "現在";
            // 
            // eventLngLabel
            // 
            this.eventLngLabel.AutoSize = true;
            this.eventLngLabel.Location = new System.Drawing.Point(67, 66);
            this.eventLngLabel.Name = "eventLngLabel";
            this.eventLngLabel.Size = new System.Drawing.Size(61, 12);
            this.eventLngLabel.TabIndex = 5;
            this.eventLngLabel.Text = "137.000000";
            // 
            // eventDateLabel
            // 
            this.eventDateLabel.AutoSize = true;
            this.eventDateLabel.Location = new System.Drawing.Point(6, 33);
            this.eventDateLabel.Name = "eventDateLabel";
            this.eventDateLabel.Size = new System.Drawing.Size(121, 12);
            this.eventDateLabel.TabIndex = 2;
            this.eventDateLabel.Text = "1970年1月1日 12:00:00";
            // 
            // eventLatLabel
            // 
            this.eventLatLabel.AutoSize = true;
            this.eventLatLabel.Location = new System.Drawing.Point(6, 66);
            this.eventLatLabel.Name = "eventLatLabel";
            this.eventLatLabel.Size = new System.Drawing.Size(55, 12);
            this.eventLatLabel.TabIndex = 4;
            this.eventLatLabel.Text = "37.000000";
            // 
            // eventPlaceLabel
            // 
            this.eventPlaceLabel.AutoSize = true;
            this.eventPlaceLabel.Location = new System.Drawing.Point(6, 49);
            this.eventPlaceLabel.Name = "eventPlaceLabel";
            this.eventPlaceLabel.Size = new System.Drawing.Size(81, 12);
            this.eventPlaceLabel.TabIndex = 3;
            this.eventPlaceLabel.Text = "東京都 中央区";
            // 
            // aspectSelect
            // 
            this.aspectSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aspectSelect.FormattingEnabled = true;
            this.aspectSelect.Location = new System.Drawing.Point(12, 110);
            this.aspectSelect.Name = "aspectSelect";
            this.aspectSelect.Size = new System.Drawing.Size(136, 20);
            this.aspectSelect.TabIndex = 2;
            this.aspectSelect.SelectedIndexChanged += new System.EventHandler(this.aspectSelect_SelectedIndexChanged);
            // 
            // DisplayToolStripMenuItem
            // 
            this.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem";
            this.DisplayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DisplayToolStripMenuItem.Text = "表示設定(&D)";
            this.DisplayToolStripMenuItem.Click += new System.EventHandler(this.DisplayToolStripMenuItem_Click);
            // 
            // NowDataToolStripMenuItem
            // 
            this.NowDataToolStripMenuItem.Name = "NowDataToolStripMenuItem";
            this.NowDataToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.NowDataToolStripMenuItem.Text = "現在のチャートを表示(&N)";
            this.NowDataToolStripMenuItem.Click += new System.EventHandler(this.NowDataToolStripMenuItem_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersionToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // VersionToolStripMenuItem
            // 
            this.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem";
            this.VersionToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.VersionToolStripMenuItem.Text = "バージョン情報(&V)";
            this.VersionToolStripMenuItem.Click += new System.EventHandler(this.VersionToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1014, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "microcosm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPanel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenDatabaseOToolStripMenuItem;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label lngLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.ToolStripMenuItem オプションOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfigToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar centerSlider;
        private System.Windows.Forms.ListView planetList;
        private System.Windows.Forms.Label centricLabel;
        private System.Windows.Forms.Label tropicalLabel;
        private System.Windows.Forms.Label placidusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cusp12;
        private System.Windows.Forms.Label cusp11;
        private System.Windows.Forms.Label cusp10;
        private System.Windows.Forms.Label cusp9;
        private System.Windows.Forms.Label cusp8;
        private System.Windows.Forms.Label cusp7;
        private System.Windows.Forms.Label cusp6;
        private System.Windows.Forms.Label cusp5;
        private System.Windows.Forms.Label cusp4;
        private System.Windows.Forms.Label cusp3;
        private System.Windows.Forms.Label cusp2;
        private System.Windows.Forms.Label cusp1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox chartPanel;
        private System.Windows.Forms.ToolStripMenuItem 表示DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem チャートToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripleChartToolStripMenuItem;
        private System.Windows.Forms.Label progressionLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label eventLngLabel;
        private System.Windows.Forms.Label eventDateLabel;
        private System.Windows.Forms.Label eventLatLabel;
        private System.Windows.Forms.Label eventPlaceLabel;
        private System.Windows.Forms.ComboBox aspectSelect;
        private System.Windows.Forms.ToolStripMenuItem DisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NowDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VersionToolStripMenuItem;
    }
}

