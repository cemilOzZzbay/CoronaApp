
namespace CoronaApp
{
    partial class YardimForm
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
            this.lbSaglikBakanligi = new System.Windows.Forms.LinkLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lbSaglikBakanligi
            // 
            this.lbSaglikBakanligi.AutoSize = true;
            this.lbSaglikBakanligi.Location = new System.Drawing.Point(13, 13);
            this.lbSaglikBakanligi.Name = "lbSaglikBakanligi";
            this.lbSaglikBakanligi.Size = new System.Drawing.Size(133, 17);
            this.lbSaglikBakanligi.TabIndex = 0;
            this.lbSaglikBakanligi.TabStop = true;
            this.lbSaglikBakanligi.Text = "T.C.Sağlık Bakanlığı";
            this.lbSaglikBakanligi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSaglikBakanligi_LinkClicked);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(16, 56);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1102, 630);
            this.webBrowser1.TabIndex = 1;
            // 
            // YardimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 716);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lbSaglikBakanligi);
            this.Name = "YardimForm";
            this.Text = "Yardım";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbSaglikBakanligi;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}