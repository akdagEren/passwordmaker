using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordmaker
{
    public partial class Form1 : Form
    {
        private static readonly string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                int uzunluk = (int)numUzunluk.Value;
                txtParola.Text = ParolaOlustur(uzunluk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ParolaOlustur(int uzunluk)
        {
            StringBuilder parola = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < uzunluk; i++)
            {
                parola.Append(karakterler[rnd.Next(karakterler.Length)]);
            }

            return parola.ToString();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtParola.Text))
            {
                Clipboard.SetText(txtParola.Text);
                MessageBox.Show("Parola panoya kopyalandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Önce bir parola oluşturun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


}
