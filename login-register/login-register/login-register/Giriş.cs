using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace login_register
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void txtBox_Name_Click(object sender, EventArgs e)
        {
            if (txtBox_Name.Text == "Kullanıcı Adı") txtBox_Name.Text = "";
            if (txtBox_Pass.Text == "")
            {
                txtBox_Pass.PasswordChar = '\0';
                txtBox_Pass.Text = "Şifre";
            }
        }

        private void txtBox_Pass_Click(object sender, EventArgs e)
        {
            if (txtBox_Pass.Text == "Şifre")
            {
                txtBox_Pass.PasswordChar = '*';
                txtBox_Pass.Text = "";
            }
            if (txtBox_Name.Text == "") txtBox_Name.Text = "Kullanıcı Adı";
        }

        private void btn_Kayıt_Click(object sender, EventArgs e)
        {
            Kayıt kayıt = new Kayıt();
            kayıt.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) txtBox_Pass.PasswordChar = '\0';
            else txtBox_Pass.PasswordChar = '*';
        }

        private void txtBox_Name_Leave(object sender, EventArgs e)
        {
            if (txtBox_Pass.Text == "Şifre")
            {
                txtBox_Pass.PasswordChar = '*';
                txtBox_Pass.Text = "";
            }
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_Name.Text) || txtBox_Name.Text=="Kullanıcı Adı" )
            {
                MessageBox.Show("Kullanıcı Adı Boş Bırakılamaz", "Kullanıcı Adı Giriniz");
                errorProvider1.SetError(txtBox_Name, "Boş Bırakılamaz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBox_Pass.Text) || txtBox_Pass.Text == "Şifre")
            {
                MessageBox.Show("Şifre Boş Bırakılamaz", "Şifre Adı Giriniz");
                errorProvider1.SetError(txtBox_Pass, "Boş Bırakılamaz.");
                return;
            }
            errorProvider1.Clear();
            Ekleme ekleme = new Ekleme()
            {
                Name = txtBox_Name.Text,
                Pass = txtBox_Pass.Text

            };
            if (File.Exists("KullanıcıListesi.txt"))
            {
                StreamReader streamReader = new StreamReader("KullanıcıListesi.txt");
                string fark = "";
                while ((fark = streamReader.ReadLine()) != null)
                    if (ekleme.Name == fark.Split(':')[0])
                    {
                        if (ekleme.Pass == fark.Split(':')[1])
                        {
                            streamReader.Close();
                            Oyun oyun = new Oyun();
                            oyun.ShowDialog();
                        }
                        else
                        {
                            break;
                        }

                    }
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                streamReader.Close();
            }
            else
                MessageBox.Show("Kayıtlı hiçbir kullanıcı yok lütfen kayıt olunuz", "Lütfen Kayıt Olunuz");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Salih-Ozarslan");
        }
    }
}
