
namespace CoronaApp
{
    partial class BelirtiTespitForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.ddlSehir = new System.Windows.Forms.ComboBox();
            this.nudYas = new System.Windows.Forms.NumericUpDown();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbOksuruk = new System.Windows.Forms.CheckBox();
            this.cbBogaz = new System.Windows.Forms.CheckBox();
            this.cbAtes = new System.Windows.Forms.CheckBox();
            this.bTespit = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şehir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yaş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tarih";
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(110, 34);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(296, 22);
            this.tbAd.TabIndex = 0;
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(110, 79);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(296, 22);
            this.tbSoyad.TabIndex = 1;
            // 
            // ddlSehir
            // 
            this.ddlSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSehir.FormattingEnabled = true;
            this.ddlSehir.Location = new System.Drawing.Point(110, 129);
            this.ddlSehir.Name = "ddlSehir";
            this.ddlSehir.Size = new System.Drawing.Size(296, 24);
            this.ddlSehir.TabIndex = 2;
            // 
            // nudYas
            // 
            this.nudYas.Location = new System.Drawing.Point(110, 176);
            this.nudYas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYas.Name = "nudYas";
            this.nudYas.Size = new System.Drawing.Size(296, 22);
            this.nudYas.TabIndex = 3;
            this.nudYas.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Checked = true;
            this.rbKadin.Location = new System.Drawing.Point(110, 221);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(65, 21);
            this.rbKadin.TabIndex = 4;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(194, 221);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(65, 21);
            this.rbErkek.TabIndex = 5;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(110, 284);
            this.dtpTarih.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpTarih.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(192, 22);
            this.dtpTarih.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSoyad);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbKadin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudYas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ddlSehir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbAd);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbOksuruk);
            this.groupBox2.Controls.Add(this.cbBogaz);
            this.groupBox2.Controls.Add(this.cbAtes);
            this.groupBox2.Location = new System.Drawing.Point(25, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Belirtiler";
            // 
            // cbOksuruk
            // 
            this.cbOksuruk.AutoSize = true;
            this.cbOksuruk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOksuruk.Location = new System.Drawing.Point(18, 93);
            this.cbOksuruk.Name = "cbOksuruk";
            this.cbOksuruk.Size = new System.Drawing.Size(83, 21);
            this.cbOksuruk.TabIndex = 1;
            this.cbOksuruk.Text = "Öksürük";
            this.cbOksuruk.UseVisualStyleBackColor = true;
            this.cbOksuruk.CheckedChanged += new System.EventHandler(this.cbOksuruk_CheckedChanged);
            // 
            // cbBogaz
            // 
            this.cbBogaz.AutoSize = true;
            this.cbBogaz.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbBogaz.Location = new System.Drawing.Point(18, 142);
            this.cbBogaz.Name = "cbBogaz";
            this.cbBogaz.Size = new System.Drawing.Size(109, 21);
            this.cbBogaz.TabIndex = 2;
            this.cbBogaz.Text = "Boğaz Ağrısı";
            this.cbBogaz.UseVisualStyleBackColor = true;
            this.cbBogaz.CheckedChanged += new System.EventHandler(this.cbBogaz_CheckedChanged);
            // 
            // cbAtes
            // 
            this.cbAtes.AutoSize = true;
            this.cbAtes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAtes.Location = new System.Drawing.Point(18, 44);
            this.cbAtes.Name = "cbAtes";
            this.cbAtes.Size = new System.Drawing.Size(58, 21);
            this.cbAtes.TabIndex = 0;
            this.cbAtes.Text = "Ateş";
            this.cbAtes.UseVisualStyleBackColor = true;
            this.cbAtes.CheckedChanged += new System.EventHandler(this.cbAtes_CheckedChanged);
            // 
            // bTespit
            // 
            this.bTespit.Location = new System.Drawing.Point(26, 563);
            this.bTespit.Name = "bTespit";
            this.bTespit.Size = new System.Drawing.Size(75, 30);
            this.bTespit.TabIndex = 2;
            this.bTespit.Text = "Tespit";
            this.bTespit.UseVisualStyleBackColor = true;
            this.bTespit.Click += new System.EventHandler(this.bTespit_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(116, 563);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(75, 30);
            this.bTemizle.TabIndex = 3;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // tbSonuc
            // 
            this.tbSonuc.Location = new System.Drawing.Point(25, 599);
            this.tbSonuc.Multiline = true;
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.ReadOnly = true;
            this.tbSonuc.Size = new System.Drawing.Size(478, 127);
            this.tbSonuc.TabIndex = 4;
            // 
            // BelirtiTespitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 748);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bTespit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BelirtiTespitForm";
            this.Text = "BelirtiTespitForm";
            this.Load += new System.EventHandler(this.BelirtiTespitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.ComboBox ddlSehir;
        private System.Windows.Forms.NumericUpDown nudYas;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbOksuruk;
        private System.Windows.Forms.CheckBox cbBogaz;
        private System.Windows.Forms.CheckBox cbAtes;
        private System.Windows.Forms.Button bTespit;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.TextBox tbSonuc;
    }
}