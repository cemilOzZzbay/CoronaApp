
namespace CoronaApp
{
    partial class YuzdeTespitForm
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
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.cbOksuruk = new System.Windows.Forms.CheckBox();
            this.cbBogaz = new System.Windows.Forms.CheckBox();
            this.cbAtes = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.rtbRapor = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gbRapor = new System.Windows.Forms.GroupBox();
            this.gbRapor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Location = new System.Drawing.Point(70, 14);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(362, 22);
            this.tbAdSoyad.TabIndex = 1;
            // 
            // cbOksuruk
            // 
            this.cbOksuruk.AutoSize = true;
            this.cbOksuruk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOksuruk.Location = new System.Drawing.Point(15, 112);
            this.cbOksuruk.Name = "cbOksuruk";
            this.cbOksuruk.Size = new System.Drawing.Size(83, 21);
            this.cbOksuruk.TabIndex = 4;
            this.cbOksuruk.Text = "Öksürük";
            this.cbOksuruk.UseVisualStyleBackColor = true;
            // 
            // cbBogaz
            // 
            this.cbBogaz.AutoSize = true;
            this.cbBogaz.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbBogaz.Location = new System.Drawing.Point(15, 161);
            this.cbBogaz.Name = "cbBogaz";
            this.cbBogaz.Size = new System.Drawing.Size(109, 21);
            this.cbBogaz.TabIndex = 5;
            this.cbBogaz.Text = "Boğaz Ağrısı";
            this.cbBogaz.UseVisualStyleBackColor = true;
            // 
            // cbAtes
            // 
            this.cbAtes.AutoSize = true;
            this.cbAtes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAtes.Location = new System.Drawing.Point(15, 63);
            this.cbAtes.Name = "cbAtes";
            this.cbAtes.Size = new System.Drawing.Size(58, 21);
            this.cbAtes.TabIndex = 3;
            this.cbAtes.Text = "Ateş";
            this.cbAtes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tespit Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.ItemHeight = 16;
            this.lbSonuc.Location = new System.Drawing.Point(18, 256);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(414, 420);
            this.lbSonuc.TabIndex = 8;
            // 
            // rtbRapor
            // 
            this.rtbRapor.Location = new System.Drawing.Point(20, 21);
            this.rtbRapor.Name = "rtbRapor";
            this.rtbRapor.Size = new System.Drawing.Size(620, 638);
            this.rtbRapor.TabIndex = 9;
            this.rtbRapor.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 31);
            this.button3.TabIndex = 11;
            this.button3.Text = "Rapor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbRapor
            // 
            this.gbRapor.Controls.Add(this.rtbRapor);
            this.gbRapor.Location = new System.Drawing.Point(456, 14);
            this.gbRapor.Name = "gbRapor";
            this.gbRapor.Size = new System.Drawing.Size(661, 692);
            this.gbRapor.TabIndex = 12;
            this.gbRapor.TabStop = false;
            this.gbRapor.Text = "Rapor";
            this.gbRapor.Visible = false;
            // 
            // YuzdeTespitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 731);
            this.Controls.Add(this.gbRapor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbOksuruk);
            this.Controls.Add(this.cbBogaz);
            this.Controls.Add(this.cbAtes);
            this.Controls.Add(this.tbAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "YuzdeTespitForm";
            this.Text = "YuzdeTespitForm";
            this.gbRapor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.CheckBox cbOksuruk;
        private System.Windows.Forms.CheckBox cbBogaz;
        private System.Windows.Forms.CheckBox cbAtes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.RichTextBox rtbRapor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gbRapor;
    }
}