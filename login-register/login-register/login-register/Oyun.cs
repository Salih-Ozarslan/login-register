using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_register
{
    public partial class Oyun : Form
    {
        public Oyun()
        {
            InitializeComponent();
        }
        int a;
        int sayac;
        string mesaj;
        private void btn_Başla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Random r1 = new Random();
            int r = r1.Next(255);
            int g = r1.Next(255);
            int b = r1.Next(255);
            ++a;
            Random randomx = new Random();
            Random randomy = new Random();
            int x = randomx.Next(20, 900);
            int y = randomy.Next(80, 600);
            btn_Başla.Location = new Point(x, y);
            btn_Başla.BackColor = Color.FromArgb(r, g, b);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac < 10)
            {
                sayac++;
                progressBar1.Value = sayac;
                label4.Text = a.ToString();
                label3.Text = sayac.ToString();
            }
            else
            {
                if (a > 15)
                    mesaj = "Çok İyiydi";

                else
                    mesaj = "Daha İyisini Yapabilirsin.";
                sayac = 0;
                timer1.Stop();
                MessageBox.Show("Skorun: " + a.ToString(), mesaj);
                a = 0;
                btn_Başla.Location = new Point(498, 331);
            }
            if (a >= 5 && a < 8)
            {
                label5.Text = "BEŞTE BEŞ";
                label5.ForeColor = Color.Black;
            }
            else
                label5.ForeColor = Color.White;

        }

        private void Oyun_Click(object sender, EventArgs e)
        {
            sayac = 0;
            timer1.Stop();
            MessageBox.Show("Yandın Skorun: " + a.ToString(), "İyi Denemeydi");
            a = 0;
            btn_Başla.Location = new Point(498, 331);
        }

        private void Oyun_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Oyuna Hoş Geldin... Oyunun amacı 10 saniye içerisinde en çok sayıda butona basmak unutma başka bir yere basarsan yanarsın.", "İyi Oyunlar");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Salih-Ozarslan");
        }
    }

}
