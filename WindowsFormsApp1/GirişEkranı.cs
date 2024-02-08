using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class GirişEkranı : Form
    {
        public GirişEkranı()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Kullanıcı adı ve şifreyi al
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            // Kullanıcı adı ve şifreyi doğrula
            if (DogruKullaniciAdiVeSifre(kullaniciAdi, sifre))
            {
                // Doğru ise, Form1'e yönlendir
                Form1 form1 = new Form1();
                this.Hide(); // Giriş formunu gizle
                form1.Show(); // Form1'i göster
            }
            else
            {
                // Yanlış ise, hata mesajı göster
                MessageBox.Show("Hatalı kullanıcı adı veya şifre. Lütfen tekrar deneyin.");
            }
        }

        // Kullanıcı adı ve şifreyi doğrulamak için ayrı bir metod
        private bool DogruKullaniciAdiVeSifre(string kullaniciAdi, string sifre)
        {
            // Kullanıcı adı ve şifreyi doğrulamak için örnek bir kontrol (örneğin, sabit bir kullanıcı adı ve şifre)
            if (kullaniciAdi == "admin" && sifre == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
            


        }
    }
}
