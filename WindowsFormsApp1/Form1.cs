using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string filmTurleri = ""; /*Bir dize değişkeni oluşturuluyor ve boş bir değer atanıyor. 
                                      * Bu değişken, seçilen film türlerini tutacak.*/

            // Film türlerini kontrol ederek seçilenleri belirle
            
            if (checkBox1.Checked)
                filmTurleri += "Korku "; /*Eğer birinci onay kutusu (checkBox1) işaretlenmişse, 
                                          * "Korku" türünün adı `filmTurleri` dizesine eklenir.*/
           
            if (checkBox2.Checked)
                filmTurleri += "Komedi "; /*Eğer ikinci onay kutusu (checkBox2) işaretlenmişse, 
                                           * "Komedi" türünün adı `filmTurleri` dizesine eklenir.*/
           
            if (checkBox3.Checked)
                filmTurleri += "Dram "; /*Eğer üçüncü onay kutusu (checkBox3) işaretlenmişse, 
                                         * "Dram" türünün adı `filmTurleri` dizesine eklenir.*/

            
            if (checkBox4.Checked)
                filmTurleri += "Bilim Kurgu "; /*Eğer dördüncü onay kutusu (checkBox4) işaretlenmişse, 
                                                * "Bilim Kurgu" türünün adı `filmTurleri` dizesine eklenir.*/


            // Cinsiyeti belirle
            
            string cinsiyet = ""; /*Bir cinsiyet dizesi oluşturulur ve boş bir değer atanır. 
                                   * Bu değişken, seçilen cinsiyeti tutacak. */ 
            
            
            if (radioButton1.Checked) /*"Erkek";`: Eğer birinci radyo düğmesi (radioButton1) işaretlenmişse, 
                                       * cinsiyet değişkeni "Erkek" olarak ayarlanır.*/
                cinsiyet = "Erkek";
           
            
            else if (radioButton2.Checked) /*Eğer birinci radyo düğmesi (radioButton1) işaretlenmemiş ve 
                                            * ikinci radyo  düğmesi (radioButton2) işaretlenmişse,
                                             cinsiyet değişkeni "Kadın" olarak ayarlanır.*/
                cinsiyet = "Kadın";

          
            string isim = textBox1.Text; //string isim değişkenş oluştr. trxt box 1 deki değeri aldık

            int yas = Convert.ToInt32(textBox2.Text); //tür dönüşümü yapıp üstteki işlemi tekrar ettik

            //Özetle, bu satır, textBoxIsim kontrolünden alınan metni isim adlı bir dize değişkenine atar.
            // .text Bu özellik, TextBox'a girilen metni içerir

            //Dolayısıyla, bu satır, textBoxYas kontrolünden alınan metni
            //yas adlı bir dize değişkenine atar.



            // Film türlerini ve cinsiyeti Listbox'a ekle
            //listBox1.Items.Add("Seçilen Film Türleri:" + filmTurleri + " " +  "Cinsiyet:" + cinsiyet + " ");  

            listBox1.Items.Add("İsim soyisim:"+ isim);

            listBox1.Items.Add("Yaş:"+ yas);


            listBox1.Items.Add("Seçilen Film Türleri:" + filmTurleri + " " );

            listBox1.Items.Add("Cinsiyet:" + cinsiyet + " ");



            /* ListBox kontrolüne bir öğe eklenir. Bu öğe, seçilen film türlerini (`filmTurleri`) ve 
             * cinsiyeti (`cinsiyet`) içerir. Film türleri bir araya getirilir ve "Seçilen Film Türleri:" 
             * ifadesiyle birlikte eklenir, ardından cinsiyet de eklenir */
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}


