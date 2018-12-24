namespace Pereodic_Table
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.infoLabel = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.closeInfoBtn = new System.Windows.Forms.Button();
            this.showVideoBtn = new System.Windows.Forms.Button();
            this.moreVideoBtn1 = new System.Windows.Forms.Button();
            this.moreVideoBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.MaximumSize = new System.Drawing.Size(600, 650);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 23);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(817, 556);
            this.webBrowser1.TabIndex = 1;
            // 
            // closeInfoBtn
            // 
            this.closeInfoBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeInfoBtn.Location = new System.Drawing.Point(12, 569);
            this.closeInfoBtn.Name = "closeInfoBtn";
            this.closeInfoBtn.Size = new System.Drawing.Size(382, 32);
            this.closeInfoBtn.TabIndex = 2;
            this.closeInfoBtn.Text = "Закрыть информацию";
            this.closeInfoBtn.UseVisualStyleBackColor = true;
            this.closeInfoBtn.Click += new System.EventHandler(this.closeInfoBtn_Click);
            // 
            // showVideoBtn
            // 
            this.showVideoBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showVideoBtn.Location = new System.Drawing.Point(400, 569);
            this.showVideoBtn.Name = "showVideoBtn";
            this.showVideoBtn.Size = new System.Drawing.Size(405, 32);
            this.showVideoBtn.TabIndex = 3;
            this.showVideoBtn.Text = "Посмотреть видео об элементе";
            this.showVideoBtn.UseVisualStyleBackColor = true;
            this.showVideoBtn.Click += new System.EventHandler(this.showVideoBtn_Click);
            // 
            // moreVideoBtn1
            // 
            this.moreVideoBtn1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moreVideoBtn1.Location = new System.Drawing.Point(12, 607);
            this.moreVideoBtn1.Name = "moreVideoBtn1";
            this.moreVideoBtn1.Size = new System.Drawing.Size(382, 32);
            this.moreVideoBtn1.TabIndex = 4;
            this.moreVideoBtn1.UseVisualStyleBackColor = true;
            this.moreVideoBtn1.Click += new System.EventHandler(this.moreVideoBtn1_Click);
            // 
            // moreVideoBtn2
            // 
            this.moreVideoBtn2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moreVideoBtn2.Location = new System.Drawing.Point(400, 607);
            this.moreVideoBtn2.Name = "moreVideoBtn2";
            this.moreVideoBtn2.Size = new System.Drawing.Size(405, 32);
            this.moreVideoBtn2.TabIndex = 5;
            this.moreVideoBtn2.UseVisualStyleBackColor = true;
            this.moreVideoBtn2.Click += new System.EventHandler(this.moreVideoBtn2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(817, 641);
            this.Controls.Add(this.moreVideoBtn2);
            this.Controls.Add(this.moreVideoBtn1);
            this.Controls.Add(this.showVideoBtn);
            this.Controls.Add(this.closeInfoBtn);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Информация об элементе";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button closeInfoBtn;
        private System.Windows.Forms.Button showVideoBtn;
        private System.Windows.Forms.Button moreVideoBtn1;
        private System.Windows.Forms.Button moreVideoBtn2;
    }
}