namespace microcosm.DB
{
    partial class UserDataEditForm
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
            this.googleBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.memoBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.timezoneBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lngBox = new System.Windows.Forms.TextBox();
            this.latBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.placeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.minuteBox = new System.Windows.Forms.TextBox();
            this.secondBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.furiganaBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // googleBtn
            // 
            this.googleBtn.Location = new System.Drawing.Point(75, 241);
            this.googleBtn.Name = "googleBtn";
            this.googleBtn.Size = new System.Drawing.Size(173, 23);
            this.googleBtn.TabIndex = 59;
            this.googleBtn.Text = "Google Mapから緯度・経度取得";
            this.googleBtn.UseVisualStyleBackColor = true;
            this.googleBtn.Click += new System.EventHandler(this.googleBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(173, 212);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 58;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // memoBox
            // 
            this.memoBox.Location = new System.Drawing.Point(75, 361);
            this.memoBox.Multiline = true;
            this.memoBox.Name = "memoBox";
            this.memoBox.Size = new System.Drawing.Size(173, 70);
            this.memoBox.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 12);
            this.label12.TabIndex = 50;
            this.label12.Text = "メモ";
            // 
            // timezoneBox
            // 
            this.timezoneBox.FormattingEnabled = true;
            this.timezoneBox.Items.AddRange(new object[] {
            "JST(日本)",
            "GMT(世界標準)"});
            this.timezoneBox.Location = new System.Drawing.Point(127, 322);
            this.timezoneBox.Name = "timezoneBox";
            this.timezoneBox.Size = new System.Drawing.Size(121, 20);
            this.timezoneBox.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 12);
            this.label11.TabIndex = 49;
            this.label11.Text = "タイムゾーン";
            // 
            // lngBox
            // 
            this.lngBox.Location = new System.Drawing.Point(148, 291);
            this.lngBox.Name = "lngBox";
            this.lngBox.Size = new System.Drawing.Size(100, 19);
            this.lngBox.TabIndex = 61;
            // 
            // latBox
            // 
            this.latBox.Location = new System.Drawing.Point(23, 291);
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(100, 19);
            this.latBox.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 48;
            this.label10.Text = "軽度";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 47;
            this.label9.Text = "緯度";
            // 
            // placeBox
            // 
            this.placeBox.Location = new System.Drawing.Point(75, 187);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(173, 19);
            this.placeBox.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 46;
            this.label8.Text = "地名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 43;
            this.label7.Text = "時";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 44;
            this.label6.Text = "分";
            // 
            // hourBox
            // 
            this.hourBox.Location = new System.Drawing.Point(75, 158);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(30, 19);
            this.hourBox.TabIndex = 54;
            this.hourBox.Text = "12";
            // 
            // minuteBox
            // 
            this.minuteBox.Location = new System.Drawing.Point(135, 158);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(30, 19);
            this.minuteBox.TabIndex = 55;
            this.minuteBox.Text = "0";
            // 
            // secondBox
            // 
            this.secondBox.Location = new System.Drawing.Point(195, 158);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(30, 19);
            this.secondBox.TabIndex = 56;
            this.secondBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 45;
            this.label5.Text = "秒";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 42;
            this.label4.Text = "出生時刻";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "出生日";
            // 
            // birthDate
            // 
            this.birthDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.birthDate.Location = new System.Drawing.Point(48, 102);
            this.birthDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.birthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(200, 19);
            this.birthDate.TabIndex = 53;
            this.birthDate.Value = new System.DateTime(2000, 1, 1, 12, 0, 0, 0);
            // 
            // furiganaBox
            // 
            this.furiganaBox.Location = new System.Drawing.Point(75, 46);
            this.furiganaBox.Name = "furiganaBox";
            this.furiganaBox.Size = new System.Drawing.Size(173, 19);
            this.furiganaBox.TabIndex = 52;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(75, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(173, 19);
            this.nameBox.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 40;
            this.label2.Text = "ふりがな";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "名前";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(90, 438);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 64;
            this.submitBtn.Text = "決定";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(173, 438);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 65;
            this.cancelBtn.Text = "キャンセル";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // UserDataEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 473);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.googleBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.memoBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.timezoneBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lngBox);
            this.Controls.Add(this.latBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.placeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.furiganaBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserDataEditForm";
            this.Text = "ユーザーデータ編集";
            this.Load += new System.EventHandler(this.UserDataEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button googleBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox memoBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox timezoneBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lngBox;
        private System.Windows.Forms.TextBox latBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox placeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.TextBox minuteBox;
        private System.Windows.Forms.TextBox secondBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.TextBox furiganaBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}