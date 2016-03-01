namespace microcosm.Config
{
    partial class ConfigForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.compositProgression = new System.Windows.Forms.RadioButton();
            this.secondaryProgression = new System.Windows.Forms.RadioButton();
            this.primaryProgression = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.centric_herio = new System.Windows.Forms.RadioButton();
            this.centric_geo = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.googleBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.lngBox = new System.Windows.Forms.TextBox();
            this.latBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.placeBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.house_pla = new System.Windows.Forms.RadioButton();
            this.house_koch = new System.Windows.Forms.RadioButton();
            this.house_cam = new System.Windows.Forms.RadioButton();
            this.house_equ = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 454);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage1.Size = new System.Drawing.Size(907, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "計算";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.compositProgression);
            this.groupBox4.Controls.Add(this.secondaryProgression);
            this.groupBox4.Controls.Add(this.primaryProgression);
            this.groupBox4.Location = new System.Drawing.Point(334, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox4.Size = new System.Drawing.Size(501, 200);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "進行図計算方法";
            // 
            // compositProgression
            // 
            this.compositProgression.AutoSize = true;
            this.compositProgression.Location = new System.Drawing.Point(15, 130);
            this.compositProgression.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.compositProgression.Name = "compositProgression";
            this.compositProgression.Size = new System.Drawing.Size(318, 28);
            this.compositProgression.TabIndex = 2;
            this.compositProgression.Text = "CPS(Composit Progression)";
            this.compositProgression.UseVisualStyleBackColor = true;
            // 
            // secondaryProgression
            // 
            this.secondaryProgression.AutoSize = true;
            this.secondaryProgression.Location = new System.Drawing.Point(15, 84);
            this.secondaryProgression.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.secondaryProgression.Name = "secondaryProgression";
            this.secondaryProgression.Size = new System.Drawing.Size(403, 28);
            this.secondaryProgression.TabIndex = 1;
            this.secondaryProgression.Text = "一日一年法(Secondary Progression)";
            this.secondaryProgression.UseVisualStyleBackColor = true;
            // 
            // primaryProgression
            // 
            this.primaryProgression.AutoSize = true;
            this.primaryProgression.Checked = true;
            this.primaryProgression.Location = new System.Drawing.Point(13, 38);
            this.primaryProgression.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.primaryProgression.Name = "primaryProgression";
            this.primaryProgression.Size = new System.Drawing.Size(375, 28);
            this.primaryProgression.TabIndex = 0;
            this.primaryProgression.TabStop = true;
            this.primaryProgression.Text = "一度一年法(Primary Progression)";
            this.primaryProgression.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(17, 200);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox3.Size = new System.Drawing.Size(267, 144);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "春分点計算";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 84);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "sidereal";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 38);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "tropical";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.centric_herio);
            this.groupBox1.Controls.Add(this.centric_geo);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(267, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "中心点計算方式";
            // 
            // centric_herio
            // 
            this.centric_herio.AutoSize = true;
            this.centric_herio.Location = new System.Drawing.Point(15, 82);
            this.centric_herio.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.centric_herio.Name = "centric_herio";
            this.centric_herio.Size = new System.Drawing.Size(178, 28);
            this.centric_herio.TabIndex = 1;
            this.centric_herio.Text = "Herio-Centric";
            this.centric_herio.UseVisualStyleBackColor = true;
            // 
            // centric_geo
            // 
            this.centric_geo.AutoSize = true;
            this.centric_geo.Checked = true;
            this.centric_geo.Location = new System.Drawing.Point(15, 38);
            this.centric_geo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.centric_geo.Name = "centric_geo";
            this.centric_geo.Size = new System.Drawing.Size(166, 28);
            this.centric_geo.TabIndex = 0;
            this.centric_geo.TabStop = true;
            this.centric_geo.Text = "Geo-Centric";
            this.centric_geo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage2.Size = new System.Drawing.Size(907, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "その他";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.googleBtn);
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.lngBox);
            this.groupBox2.Controls.Add(this.latBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.placeBox);
            this.groupBox2.Location = new System.Drawing.Point(30, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox2.Size = new System.Drawing.Size(433, 324);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "デフォルトの場所";
            // 
            // googleBtn
            // 
            this.googleBtn.Location = new System.Drawing.Point(20, 144);
            this.googleBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.googleBtn.Name = "googleBtn";
            this.googleBtn.Size = new System.Drawing.Size(401, 46);
            this.googleBtn.TabIndex = 6;
            this.googleBtn.Text = "Google Mapから緯度・経度取得";
            this.googleBtn.UseVisualStyleBackColor = true;
            this.googleBtn.Click += new System.EventHandler(this.googleBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(258, 86);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(163, 46);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // lngBox
            // 
            this.lngBox.Location = new System.Drawing.Point(91, 274);
            this.lngBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lngBox.Name = "lngBox";
            this.lngBox.Size = new System.Drawing.Size(325, 31);
            this.lngBox.TabIndex = 4;
            this.lngBox.Text = "139.697035";
            // 
            // latBox
            // 
            this.latBox.Location = new System.Drawing.Point(91, 222);
            this.latBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(325, 31);
            this.latBox.TabIndex = 3;
            this.latBox.Text = "35.53137";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "経度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "緯度";
            // 
            // placeBox
            // 
            this.placeBox.Location = new System.Drawing.Point(13, 36);
            this.placeBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(403, 31);
            this.placeBox.TabIndex = 0;
            this.placeBox.Text = "東京都中央区";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 466);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(907, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ハウス";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.house_equ);
            this.groupBox5.Controls.Add(this.house_cam);
            this.groupBox5.Controls.Add(this.house_koch);
            this.groupBox5.Controls.Add(this.house_pla);
            this.groupBox5.Location = new System.Drawing.Point(19, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(478, 230);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ハウス計算";
            // 
            // house_pla
            // 
            this.house_pla.AutoSize = true;
            this.house_pla.Checked = true;
            this.house_pla.Location = new System.Drawing.Point(28, 41);
            this.house_pla.Name = "house_pla";
            this.house_pla.Size = new System.Drawing.Size(123, 28);
            this.house_pla.TabIndex = 0;
            this.house_pla.TabStop = true;
            this.house_pla.Text = "Placidas";
            this.house_pla.UseVisualStyleBackColor = true;
            // 
            // house_koch
            // 
            this.house_koch.AutoSize = true;
            this.house_koch.Location = new System.Drawing.Point(28, 84);
            this.house_koch.Name = "house_koch";
            this.house_koch.Size = new System.Drawing.Size(91, 28);
            this.house_koch.TabIndex = 1;
            this.house_koch.TabStop = true;
            this.house_koch.Text = "Koch";
            this.house_koch.UseVisualStyleBackColor = true;
            // 
            // house_cam
            // 
            this.house_cam.AutoSize = true;
            this.house_cam.Location = new System.Drawing.Point(28, 131);
            this.house_cam.Name = "house_cam";
            this.house_cam.Size = new System.Drawing.Size(144, 28);
            this.house_cam.TabIndex = 2;
            this.house_cam.TabStop = true;
            this.house_cam.Text = "Campanus";
            this.house_cam.UseVisualStyleBackColor = true;
            // 
            // house_equ
            // 
            this.house_equ.AutoSize = true;
            this.house_equ.Location = new System.Drawing.Point(28, 176);
            this.house_equ.Name = "house_equ";
            this.house_equ.Size = new System.Drawing.Size(95, 28);
            this.house_equ.TabIndex = 3;
            this.house_equ.TabStop = true;
            this.house_equ.Text = "Equal";
            this.house_equ.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 528);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ConfigForm";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton centric_herio;
        private System.Windows.Forms.RadioButton centric_geo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button googleBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox lngBox;
        private System.Windows.Forms.TextBox latBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox placeBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton compositProgression;
        private System.Windows.Forms.RadioButton secondaryProgression;
        private System.Windows.Forms.RadioButton primaryProgression;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton house_cam;
        private System.Windows.Forms.RadioButton house_koch;
        private System.Windows.Forms.RadioButton house_pla;
        private System.Windows.Forms.RadioButton house_equ;
    }
}