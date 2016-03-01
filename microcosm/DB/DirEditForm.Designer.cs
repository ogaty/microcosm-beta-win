namespace microcosm.DB
{
    partial class DirEditForm
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
            this.dirnameBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "新規名称";
            // 
            // dirnameBox
            // 
            this.dirnameBox.Location = new System.Drawing.Point(33, 56);
            this.dirnameBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dirnameBox.Name = "dirnameBox";
            this.dirnameBox.Size = new System.Drawing.Size(394, 31);
            this.dirnameBox.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(33, 134);
            this.okBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(163, 46);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "決定";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(269, 134);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(163, 46);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "キャンセル";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // DirEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 212);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.dirnameBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirEditForm";
            this.Text = "DirEditForm";
            this.Load += new System.EventHandler(this.DirEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dirnameBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}