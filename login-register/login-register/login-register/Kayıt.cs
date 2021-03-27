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
    public partial class Kayıt : Form
    {
        public Kayıt()
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
            if (txtBox_Pass.Text == "Şifre" || txtBox_Pass.Text == "")
            {
                txtBox_Pass.PasswordChar = '*';
                txtBox_Pass.Text = "";
            }
            if (txtBox_Name.Text == "") txtBox_Name.Text = "Kullanıcı Adı";
        }

        private void btn_Kayıt_Click(object sender, EventArgs e)
        {
            string userName = txtBox_Name.Text;
            string password = txtBox_Pass.Text;
            if (string.IsNullOrWhiteSpace(txtBox_Name.Text) || txtBox_Name.Text == "Kullanıcı Adı")
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
            Ekleme ekleme = new Ekleme
            {
                Name = userName,
                Pass = password
            };
            if (!File.Exists("KullanıcıListesi.txt"))
            {
                FileStream fileStream = File.Create("KullanıcıListesi.txt");
                fileStream.Close();
            }
            StreamReader streamReader = new StreamReader("KullanıcıListesi.txt");
            string fark = "";
            while ((fark = streamReader.ReadLine()) != null)
                if (ekleme.Name == fark.Split(':')[0])
                {
                    MessageBox.Show("Kullanıcı Adı Sistemde Kayıtlı." , "Program");
                    streamReader.Close();
                    return;
                }
            streamReader.Close();

            if (DosyayaYazma(ekleme))
                MessageBox.Show("Kayıt İşlemi Başarılı");
            else
                MessageBox.Show("Kayıt İşlemi Başarısız");
            txtBox_Name.Text = "Kullanıcı Adı";
            txtBox_Pass.Text = "";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) txtBox_Pass.PasswordChar = '\0';
            else txtBox_Pass.PasswordChar = '*';
        }
        private static bool DosyayaYazma(Ekleme ekleme)
        {
            try
            {
                StreamWriter writer = new StreamWriter("KullanıcıListesi.txt",true);
                writer.WriteLine(ekleme.ToString());
                writer.Flush();
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void txtBox_Name_Leave(object sender, EventArgs e)
        {
            if (txtBox_Pass.Text == "Şifre" || txtBox_Pass.Text == "")
            {
                txtBox_Pass.PasswordChar = '*';
                txtBox_Pass.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Salih-Ozarslan");
        }
    }
    public class Ekleme
    {
        public string Name { get; set; }

        public string Pass { get; set; }
        public override string ToString()
        {
            return $"{Name}:{Pass}";
        }
    }
}
