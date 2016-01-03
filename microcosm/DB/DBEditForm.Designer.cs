namespace microcosm.DB
{
    partial class DBEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.furiganaBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.secondBox = new System.Windows.Forms.TextBox();
            this.minuteBox = new System.Windows.Forms.TextBox();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.placeBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.latBox = new System.Windows.Forms.TextBox();
            this.lngBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timezoneBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.memoBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.eventnameBox = new System.Windows.Forms.TextBox();
            this.eventEnable = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.eventDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.eventYearBox = new System.Windows.Forms.TextBox();
            this.eventMonthBox = new System.Windows.Forms.TextBox();
            this.eventDayBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.eventMemoBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.eventTimezone = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.eventLngBox = new System.Windows.Forms.TextBox();
            this.eventLatBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.eventPlaceBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.googleBtn = new System.Windows.Forms.Button();
            this.searchBtn2 = new System.Windows.Forms.Button();
            this.googleBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ふりがな";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(66, 20);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(173, 19);
            this.nameBox.TabIndex = 2;
            // 
            // furiganaBox
            // 
            this.furiganaBox.Location = new System.Drawing.Point(66, 54);
            this.furiganaBox.Name = "furiganaBox";
            this.furiganaBox.Size = new System.Drawing.Size(173, 19);
            this.furiganaBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(334, 460);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "決定";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(432, 460);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // birthDate
            // 
            this.birthDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.birthDate.Location = new System.Drawing.Point(39, 110);
            this.birthDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.birthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(200, 19);
            this.birthDate.TabIndex = 6;
            this.birthDate.Value = new System.DateTime(2000, 1, 1, 12, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "出生日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "出生時刻";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "秒";
            // 
            // secondBox
            // 
            this.secondBox.Location = new System.Drawing.Point(186, 166);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(30, 19);
            this.secondBox.TabIndex = 10;
            this.secondBox.Text = "0";
            // 
            // minuteBox
            // 
            this.minuteBox.Location = new System.Drawing.Point(126, 166);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(30, 19);
            this.minuteBox.TabIndex = 11;
            this.minuteBox.Text = "0";
            // 
            // hourBox
            // 
            this.hourBox.Location = new System.Drawing.Point(66, 166);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(30, 19);
            this.hourBox.TabIndex = 12;
            this.hourBox.Text = "12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "時";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "地名";
            // 
            // placeBox
            // 
            this.placeBox.Location = new System.Drawing.Point(66, 195);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(173, 19);
            this.placeBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "緯度";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "軽度";
            // 
            // latBox
            // 
            this.latBox.Location = new System.Drawing.Point(14, 299);
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(100, 19);
            this.latBox.TabIndex = 19;
            // 
            // lngBox
            // 
            this.lngBox.Location = new System.Drawing.Point(139, 299);
            this.lngBox.Name = "lngBox";
            this.lngBox.Size = new System.Drawing.Size(100, 19);
            this.lngBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "タイムゾーン";
            // 
            // timezoneBox
            // 
            this.timezoneBox.FormattingEnabled = true;
            this.timezoneBox.Items.AddRange(new object[] {
            "JST(日本)",
            "GMT(世界標準)"});
            this.timezoneBox.Location = new System.Drawing.Point(118, 330);
            this.timezoneBox.Name = "timezoneBox";
            this.timezoneBox.Size = new System.Drawing.Size(121, 20);
            this.timezoneBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "メモ";
            // 
            // memoBox
            // 
            this.memoBox.Location = new System.Drawing.Point(66, 369);
            this.memoBox.Multiline = true;
            this.memoBox.Name = "memoBox";
            this.memoBox.Size = new System.Drawing.Size(173, 70);
            this.memoBox.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "イベント名";
            // 
            // eventnameBox
            // 
            this.eventnameBox.Location = new System.Drawing.Point(334, 21);
            this.eventnameBox.Name = "eventnameBox";
            this.eventnameBox.Size = new System.Drawing.Size(173, 19);
            this.eventnameBox.TabIndex = 26;
            this.eventnameBox.Text = "出生";
            // 
            // eventEnable
            // 
            this.eventEnable.AutoSize = true;
            this.eventEnable.Location = new System.Drawing.Point(277, 57);
            this.eventEnable.Name = "eventEnable";
            this.eventEnable.Size = new System.Drawing.Size(108, 16);
            this.eventEnable.TabIndex = 27;
            this.eventEnable.Text = "イベント詳細設定";
            this.eventEnable.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(275, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "イベント日";
            // 
            // eventDate
            // 
            this.eventDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.eventDate.Location = new System.Drawing.Point(307, 110);
            this.eventDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.eventDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(200, 19);
            this.eventDate.TabIndex = 29;
            this.eventDate.Value = new System.DateTime(2000, 1, 1, 12, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(275, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 30;
            this.label15.Text = "イベント時刻";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(371, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 36;
            this.label16.Text = "時";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(430, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 35;
            this.label17.Text = "分";
            // 
            // eventYearBox
            // 
            this.eventYearBox.Location = new System.Drawing.Point(334, 166);
            this.eventYearBox.Name = "eventYearBox";
            this.eventYearBox.Size = new System.Drawing.Size(30, 19);
            this.eventYearBox.TabIndex = 34;
            this.eventYearBox.Text = "12";
            // 
            // eventMonthBox
            // 
            this.eventMonthBox.Location = new System.Drawing.Point(394, 166);
            this.eventMonthBox.Name = "eventMonthBox";
            this.eventMonthBox.Size = new System.Drawing.Size(30, 19);
            this.eventMonthBox.TabIndex = 33;
            this.eventMonthBox.Text = "0";
            // 
            // eventDayBox
            // 
            this.eventDayBox.Location = new System.Drawing.Point(454, 166);
            this.eventDayBox.Name = "eventDayBox";
            this.eventDayBox.Size = new System.Drawing.Size(30, 19);
            this.eventDayBox.TabIndex = 32;
            this.eventDayBox.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(490, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 31;
            this.label18.Text = "秒";
            // 
            // eventMemoBox
            // 
            this.eventMemoBox.Location = new System.Drawing.Point(334, 366);
            this.eventMemoBox.Multiline = true;
            this.eventMemoBox.Name = "eventMemoBox";
            this.eventMemoBox.Size = new System.Drawing.Size(173, 70);
            this.eventMemoBox.TabIndex = 46;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(282, 366);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 12);
            this.label19.TabIndex = 45;
            this.label19.Text = "メモ";
            // 
            // eventTimezone
            // 
            this.eventTimezone.FormattingEnabled = true;
            this.eventTimezone.Items.AddRange(new object[] {
            "JST(日本)",
            "GMT(世界標準)"});
            this.eventTimezone.Location = new System.Drawing.Point(386, 327);
            this.eventTimezone.Name = "eventTimezone";
            this.eventTimezone.Size = new System.Drawing.Size(121, 20);
            this.eventTimezone.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(280, 330);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 12);
            this.label20.TabIndex = 43;
            this.label20.Text = "タイムゾーン";
            // 
            // eventLngBox
            // 
            this.eventLngBox.Location = new System.Drawing.Point(407, 296);
            this.eventLngBox.Name = "eventLngBox";
            this.eventLngBox.Size = new System.Drawing.Size(100, 19);
            this.eventLngBox.TabIndex = 42;
            // 
            // eventLatBox
            // 
            this.eventLatBox.Location = new System.Drawing.Point(282, 296);
            this.eventLatBox.Name = "eventLatBox";
            this.eventLatBox.Size = new System.Drawing.Size(100, 19);
            this.eventLatBox.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(405, 281);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 40;
            this.label21.Text = "軽度";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(281, 281);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 39;
            this.label22.Text = "緯度";
            // 
            // eventPlaceBox
            // 
            this.eventPlaceBox.Location = new System.Drawing.Point(334, 192);
            this.eventPlaceBox.Name = "eventPlaceBox";
            this.eventPlaceBox.Size = new System.Drawing.Size(173, 19);
            this.eventPlaceBox.TabIndex = 38;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(282, 195);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 37;
            this.label23.Text = "地名";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(164, 220);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 47;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // googleBtn
            // 
            this.googleBtn.Location = new System.Drawing.Point(66, 249);
            this.googleBtn.Name = "googleBtn";
            this.googleBtn.Size = new System.Drawing.Size(173, 23);
            this.googleBtn.TabIndex = 48;
            this.googleBtn.Text = "Google Mapから緯度・経度取得";
            this.googleBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn2
            // 
            this.searchBtn2.Location = new System.Drawing.Point(432, 217);
            this.searchBtn2.Name = "searchBtn2";
            this.searchBtn2.Size = new System.Drawing.Size(75, 23);
            this.searchBtn2.TabIndex = 49;
            this.searchBtn2.Text = "検索";
            this.searchBtn2.UseVisualStyleBackColor = true;
            // 
            // googleBtn2
            // 
            this.googleBtn2.Location = new System.Drawing.Point(334, 249);
            this.googleBtn2.Name = "googleBtn2";
            this.googleBtn2.Size = new System.Drawing.Size(173, 23);
            this.googleBtn2.TabIndex = 50;
            this.googleBtn2.Text = "Google Mapから緯度・経度取得";
            this.googleBtn2.UseVisualStyleBackColor = true;
            // 
            // DBEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 495);
            this.Controls.Add(this.googleBtn2);
            this.Controls.Add(this.searchBtn2);
            this.Controls.Add(this.googleBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.eventMemoBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.eventTimezone);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.eventLngBox);
            this.Controls.Add(this.eventLatBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.eventPlaceBox);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.eventYearBox);
            this.Controls.Add(this.eventMonthBox);
            this.Controls.Add(this.eventDayBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.eventEnable);
            this.Controls.Add(this.eventnameBox);
            this.Controls.Add(this.label13);
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
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.furiganaBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DBEditForm";
            this.Text = "DBEditForm";
            this.Load += new System.EventHandler(this.DBEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox furiganaBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox secondBox;
        private System.Windows.Forms.TextBox minuteBox;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox placeBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox latBox;
        private System.Windows.Forms.TextBox lngBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox timezoneBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox memoBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox eventnameBox;
        private System.Windows.Forms.CheckBox eventEnable;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker eventDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox eventYearBox;
        private System.Windows.Forms.TextBox eventMonthBox;
        private System.Windows.Forms.TextBox eventDayBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox eventMemoBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox eventTimezone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox eventLngBox;
        private System.Windows.Forms.TextBox eventLatBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox eventPlaceBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button googleBtn;
        private System.Windows.Forms.Button searchBtn2;
        private System.Windows.Forms.Button googleBtn2;
    }
}