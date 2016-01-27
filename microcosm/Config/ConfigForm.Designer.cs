﻿namespace microcosm.Config
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 227);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 201);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "計算";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.compositProgression);
            this.groupBox4.Controls.Add(this.secondaryProgression);
            this.groupBox4.Controls.Add(this.primaryProgression);
            this.groupBox4.Location = new System.Drawing.Point(154, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "進行図計算方法";
            // 
            // compositProgression
            // 
            this.compositProgression.AutoSize = true;
            this.compositProgression.Location = new System.Drawing.Point(7, 65);
            this.compositProgression.Name = "compositProgression";
            this.compositProgression.Size = new System.Drawing.Size(165, 16);
            this.compositProgression.TabIndex = 2;
            this.compositProgression.Text = "CPS(Composit Progression)";
            this.compositProgression.UseVisualStyleBackColor = true;
            // 
            // secondaryProgression
            // 
            this.secondaryProgression.AutoSize = true;
            this.secondaryProgression.Location = new System.Drawing.Point(7, 42);
            this.secondaryProgression.Name = "secondaryProgression";
            this.secondaryProgression.Size = new System.Drawing.Size(208, 16);
            this.secondaryProgression.TabIndex = 1;
            this.secondaryProgression.Text = "一日一年法(Secondary Progression)";
            this.secondaryProgression.UseVisualStyleBackColor = true;
            // 
            // primaryProgression
            // 
            this.primaryProgression.AutoSize = true;
            this.primaryProgression.Checked = true;
            this.primaryProgression.Location = new System.Drawing.Point(6, 19);
            this.primaryProgression.Name = "primaryProgression";
            this.primaryProgression.Size = new System.Drawing.Size(194, 16);
            this.primaryProgression.TabIndex = 0;
            this.primaryProgression.TabStop = true;
            this.primaryProgression.Text = "一度一年法(Primary Progression)";
            this.primaryProgression.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(8, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 72);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "春分点計算";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "sidereal";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "tropical";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.centric_herio);
            this.groupBox1.Controls.Add(this.centric_geo);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "中心点計算方式";
            // 
            // centric_herio
            // 
            this.centric_herio.AutoSize = true;
            this.centric_herio.Location = new System.Drawing.Point(7, 41);
            this.centric_herio.Name = "centric_herio";
            this.centric_herio.Size = new System.Drawing.Size(93, 16);
            this.centric_herio.TabIndex = 1;
            this.centric_herio.Text = "Herio-Centric";
            this.centric_herio.UseVisualStyleBackColor = true;
            // 
            // centric_geo
            // 
            this.centric_geo.AutoSize = true;
            this.centric_geo.Checked = true;
            this.centric_geo.Location = new System.Drawing.Point(7, 19);
            this.centric_geo.Name = "centric_geo";
            this.centric_geo.Size = new System.Drawing.Size(86, 16);
            this.centric_geo.TabIndex = 0;
            this.centric_geo.TabStop = true;
            this.centric_geo.Text = "Geo-Centric";
            this.centric_geo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 201);
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
            this.groupBox2.Location = new System.Drawing.Point(14, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 162);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "デフォルトの場所";
            // 
            // googleBtn
            // 
            this.googleBtn.Location = new System.Drawing.Point(9, 72);
            this.googleBtn.Name = "googleBtn";
            this.googleBtn.Size = new System.Drawing.Size(185, 23);
            this.googleBtn.TabIndex = 6;
            this.googleBtn.Text = "Google Mapから緯度・経度取得";
            this.googleBtn.UseVisualStyleBackColor = true;
            this.googleBtn.Click += new System.EventHandler(this.googleBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(119, 43);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // lngBox
            // 
            this.lngBox.Location = new System.Drawing.Point(42, 137);
            this.lngBox.Name = "lngBox";
            this.lngBox.Size = new System.Drawing.Size(152, 19);
            this.lngBox.TabIndex = 4;
            this.lngBox.Text = "139.697035";
            // 
            // latBox
            // 
            this.latBox.Location = new System.Drawing.Point(42, 111);
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(152, 19);
            this.latBox.TabIndex = 3;
            this.latBox.Text = "35.53137";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "経度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "緯度";
            // 
            // placeBox
            // 
            this.placeBox.Location = new System.Drawing.Point(6, 18);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(188, 19);
            this.placeBox.TabIndex = 0;
            this.placeBox.Text = "東京都中央区";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 264);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}