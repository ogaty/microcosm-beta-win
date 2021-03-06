﻿namespace microcosm.DB
{
    partial class UserEventEditForm
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
            this.googleBtn2 = new System.Windows.Forms.Button();
            this.searchBtn2 = new System.Windows.Forms.Button();
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
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.eventHourBox = new System.Windows.Forms.TextBox();
            this.eventMinuteBox = new System.Windows.Forms.TextBox();
            this.eventSecondBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.eventDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.eventnameBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // googleBtn2
            // 
            this.googleBtn2.Location = new System.Drawing.Point(184, 410);
            this.googleBtn2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.googleBtn2.Name = "googleBtn2";
            this.googleBtn2.Size = new System.Drawing.Size(375, 46);
            this.googleBtn2.TabIndex = 61;
            this.googleBtn2.Text = "Google Mapから緯度・経度取得";
            this.googleBtn2.UseVisualStyleBackColor = true;
            this.googleBtn2.Click += new System.EventHandler(this.googleBtn2_Click);
            // 
            // searchBtn2
            // 
            this.searchBtn2.Location = new System.Drawing.Point(397, 346);
            this.searchBtn2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.searchBtn2.Name = "searchBtn2";
            this.searchBtn2.Size = new System.Drawing.Size(163, 46);
            this.searchBtn2.TabIndex = 60;
            this.searchBtn2.Text = "検索";
            this.searchBtn2.UseVisualStyleBackColor = true;
            this.searchBtn2.Click += new System.EventHandler(this.searchBtn2_Click);
            // 
            // eventMemoBox
            // 
            this.eventMemoBox.Location = new System.Drawing.Point(132, 644);
            this.eventMemoBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.eventMemoBox.Multiline = true;
            this.eventMemoBox.Name = "eventMemoBox";
            this.eventMemoBox.Size = new System.Drawing.Size(422, 136);
            this.eventMemoBox.TabIndex = 65;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(72, 644);
            this.label19.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 24);
            this.label19.TabIndex = 74;
            this.label19.Text = "メモ";
            // 
            // eventTimezone
            // 
            this.eventTimezone.FormattingEnabled = true;
            this.eventTimezone.Items.AddRange(new object[] {
            "JST(日本)",
            "GMT(世界標準)"});
            this.eventTimezone.Location = new System.Drawing.Point(297, 566);
            this.eventTimezone.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.eventTimezone.Name = "eventTimezone";
            this.eventTimezone.Size = new System.Drawing.Size(258, 32);
            this.eventTimezone.TabIndex = 64;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(67, 572);
            this.label20.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 24);
            this.label20.TabIndex = 74;
            this.label20.Text = "タイムゾーン";
            // 
            // eventLngBox
            // 
            this.eventLngBox.Location = new System.Drawing.Point(342, 504);
            this.eventLngBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.eventLngBox.Name = "eventLngBox";
            this.eventLngBox.Size = new System.Drawing.Size(212, 31);
            this.eventLngBox.TabIndex = 63;
            // 
            // eventLatBox
            // 
            this.eventLatBox.Location = new System.Drawing.Point(72, 504);
            this.eventLatBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.eventLatBox.Name = "eventLatBox";
            this.eventLatBox.Size = new System.Drawing.Size(212, 31);
            this.eventLatBox.TabIndex = 62;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(338, 474);
            this.label21.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 24);
            this.label21.TabIndex = 73;
            this.label21.Text = "軽度";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(69, 474);
            this.label22.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 24);
            this.label22.TabIndex = 72;
            this.label22.Text = "緯度";
            // 
            // eventPlaceBox
            // 
            this.eventPlaceBox.Location = new System.Drawing.Point(184, 296);
            this.eventPlaceBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.eventPlaceBox.Name = "eventPlaceBox";
            this.eventPlaceBox.Size = new System.Drawing.Size(370, 31);
            this.eventPlaceBox.TabIndex = 59;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(72, 302);
            this.label23.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 24);
            this.label23.TabIndex = 71;
            this.label23.Text = "地名";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(264, 250);
            this.label16.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 24);
            this.label16.TabIndex = 64;
            this.label16.Text = "時";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(392, 250);
            this.label17.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 24);
            this.label17.TabIndex = 63;
            this.label17.Text = "分";
            // 
            // eventHourBox
            // 
            this.eventHourBox.Location = new System.Drawing.Point(184, 244);
            this.eventHourBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.eventHourBox.Name = "eventHourBox";
            this.eventHourBox.Size = new System.Drawing.Size(60, 31);
            this.eventHourBox.TabIndex = 56;
            this.eventHourBox.Text = "12";
            // 
            // eventMinuteBox
            // 
            this.eventMinuteBox.Location = new System.Drawing.Point(314, 244);
            this.eventMinuteBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.eventMinuteBox.Name = "eventMinuteBox";
            this.eventMinuteBox.Size = new System.Drawing.Size(60, 31);
            this.eventMinuteBox.TabIndex = 57;
            this.eventMinuteBox.Text = "0";
            // 
            // eventSecondBox
            // 
            this.eventSecondBox.Location = new System.Drawing.Point(444, 244);
            this.eventSecondBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.eventSecondBox.Name = "eventSecondBox";
            this.eventSecondBox.Size = new System.Drawing.Size(60, 31);
            this.eventSecondBox.TabIndex = 58;
            this.eventSecondBox.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(522, 250);
            this.label18.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 24);
            this.label18.TabIndex = 59;
            this.label18.Text = "秒";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 206);
            this.label15.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 24);
            this.label15.TabIndex = 70;
            this.label15.Text = "イベント時刻";
            // 
            // eventDate
            // 
            this.eventDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.eventDate.Location = new System.Drawing.Point(126, 142);
            this.eventDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.eventDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.eventDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(429, 31);
            this.eventDate.TabIndex = 55;
            this.eventDate.Value = new System.DateTime(2000, 1, 1, 12, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 90);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 24);
            this.label14.TabIndex = 69;
            this.label14.Text = "イベント日";
            // 
            // eventnameBox
            // 
            this.eventnameBox.Location = new System.Drawing.Point(184, 24);
            this.eventnameBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.eventnameBox.Name = "eventnameBox";
            this.eventnameBox.Size = new System.Drawing.Size(370, 31);
            this.eventnameBox.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(56, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 24);
            this.label13.TabIndex = 68;
            this.label13.Text = "イベント名";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(397, 832);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(163, 46);
            this.cancelButton.TabIndex = 67;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(184, 832);
            this.submitButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(163, 46);
            this.submitButton.TabIndex = 66;
            this.submitButton.Text = "決定";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // UserEventEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 902);
            this.Controls.Add(this.googleBtn2);
            this.Controls.Add(this.searchBtn2);
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
            this.Controls.Add(this.eventHourBox);
            this.Controls.Add(this.eventMinuteBox);
            this.Controls.Add(this.eventSecondBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.eventnameBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserEventEditForm";
            this.Text = "UserEventEditForm";
            this.Load += new System.EventHandler(this.UserEventEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button googleBtn2;
        private System.Windows.Forms.Button searchBtn2;
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox eventHourBox;
        private System.Windows.Forms.TextBox eventMinuteBox;
        private System.Windows.Forms.TextBox eventSecondBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker eventDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox eventnameBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
    }
}