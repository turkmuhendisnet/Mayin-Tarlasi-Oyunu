using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int[] Mayınlar = new int[20];
        int Mavi;
        int Yesil;
        int Kirmizi;
        int ButonNumarası;
        int Puan=0;
        private void Form1_Load(object sender, EventArgs e)
        {            
            for (int i = 1; i < 166; i++)
            {
                Kirmizi = rnd.Next(0, 255);
                Yesil = rnd.Next(0, 255);
                Mavi = rnd.Next(0, 255);
                ButonNumarası = rnd.Next(0, 166);
                Button buton = new Button();
                buton.BackColor = Color.FromArgb(Kirmizi, Yesil, Mavi);
                buton.BackColor = Color.FromArgb(Kirmizi, Yesil, Mavi);
                buton.Width = 30;
                buton.Height = 30;
                buton.Text = ButonNumarası.ToString();
                buton.Click += new EventHandler(buton_Click);
                FlpPanel.Controls.Add(buton);
            }
            tmrZaman.Start();
            int sayi = 0;
            while (sayi < Mayınlar.Length)
            {
                int rastgeleMayın = rnd.Next(1, 166);
                // Mayınlara Rastgele sayı değeri atandı
                if (Mayınlar.Contains(rastgeleMayın) == false)
                {
                    Mayınlar[sayi] = rastgeleMayın;
                    sayi++;
                }
            }

        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            foreach (Control item in FlpPanel.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor!=Color.White)
                    {
                        Kirmizi = rnd.Next(1, 256);
                        Yesil = rnd.Next(1, 256);
                        Mavi = rnd.Next(1, 256);
                        item.BackColor = Color.FromArgb(Kirmizi, Yesil, Mavi);
                        item.ForeColor = Color.FromArgb(Kirmizi, Yesil, Mavi);
                    }
                }
            }
        }
        private void buton_Click(object sender, EventArgs e)
        {
            int tiklanan = Convert.ToInt32((sender as Button).Text);

            if (Mayınlar.Contains(tiklanan))
            {
                (sender as Button).BackColor = Color.Black;               
                tmrZaman.Stop();
                this.BackColor = Color.Red;
                MessageBox.Show("Mayına Dokundunuz\n"+"Puanınız:"+Puan);
                FlpPanel.Enabled = true;
            }
            else
            {
                (sender as Button).BackColor = Color.White;
                Puan += 5;                
            }
        }
       // formu yeniden yüklemek için
        private void btnYeniden_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[0] == this)//Uygulamanin main form'u
            {
                //uygulamanin ana formunu kapatirsaniz uygulama kapanir, ana formu yeniden baslatmak uygulamayi yeniden baslatmak demektir.
                Application.Restart();
            }
 
        }
    }
}
