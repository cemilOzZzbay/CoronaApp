using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaApp
{
    public partial class YuzdeTespitForm : Form
    {
        public YuzdeTespitForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // button2=Temizle
        {
            tbAdSoyad.Text = "";
            cbAtes.Checked = false;
            cbBogaz.Checked = false;
            cbOksuruk.Checked = false;
            lbSonuc.Items.Clear();
            gbRapor.Visible = false;
        }
        // ateş:70, öksürük:20, boğaz ağrısı:10
        private void button1_Click(object sender, EventArgs e) // button1=Tespit Et
        {
            int yuzde = 0;
            if (cbAtes.Checked)
                yuzde += 70;
            if (cbOksuruk.Checked)
                yuzde += 20;
            if (cbBogaz.Checked)
                yuzde += 10;
            lbSonuc.Items.Add("Sayın " + tbAdSoyad.Text + ", %" + yuzde + " ihtimalle koronasınız.");
                                                                                                
        }

        private void button3_Click(object sender, EventArgs e) // button3=Rapor
        {
            rtbRapor.Text = "";
            if (lbSonuc.Items.Count > 0)
            {
                foreach (var item in lbSonuc.Items) { rtbRapor.Text += item + "\r\n"; }
            }
            gbRapor.Visible = true;

        }
    }
}
