namespace microcosm.Help
{
    partial class Version
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
            this.label3 = new System.Windows.Forms.Label();
            this.ogatismLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.swissLabel = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "microcosm for windows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "0.1";
            // 
            // ogatismLabel
            // 
            this.ogatismLabel.AutoSize = true;
            this.ogatismLabel.Location = new System.Drawing.Point(177, 38);
            this.ogatismLabel.Name = "ogatismLabel";
            this.ogatismLabel.Size = new System.Drawing.Size(96, 12);
            this.ogatismLabel.TabIndex = 3;
            this.ogatismLabel.TabStop = true;
            this.ogatismLabel.Text = "http://ogatism.jp/";
            this.ogatismLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ogatismLabel_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "(C) 緒形雄二";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Swiss Ephemeris";
            // 
            // swissLabel
            // 
            this.swissLabel.AutoSize = true;
            this.swissLabel.Location = new System.Drawing.Point(177, 87);
            this.swissLabel.Name = "swissLabel";
            this.swissLabel.Size = new System.Drawing.Size(120, 12);
            this.swissLabel.TabIndex = 6;
            this.swissLabel.TabStop = true;
            this.swissLabel.Text = "http://www.astro.com/";
            this.swissLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.swissLabel_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "(C) Astrodienst AG";
            // 
            // Version
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 117);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.swissLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ogatismLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Version";
            this.Text = "Version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel ogatismLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel swissLabel;
        private System.Windows.Forms.Label label6;
    }
}