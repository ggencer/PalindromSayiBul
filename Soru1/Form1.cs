using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // formdan girilecek değişkenler ve polindrom hesablaması icin gerekli geçici değişkenler tanımlandı
        int sayi1, sayi2, reverse = 0, sayac = 0;

        //tbx_sayi1' girilen değerin sayı olduğunun kontrolü
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Kullanıcı sayı dışında bir karakter girişi yaparsa uyarı veriyor.
            if (System.Text.RegularExpressions.Regex.IsMatch(tbx_sayi1.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen sadece sayı giriniz.");
                tbx_sayi1.Text = tbx_sayi1.Text.Remove(tbx_sayi1.Text.Length - 1);
                tbx_sayi1.Clear();
            }
            //sayı 4900'dan büyükse uyarı veriyor
            else if (System.Text.RegularExpressions.Regex.IsMatch(tbx_sayi1.Text, "[^a-zA-Z]") && Convert.ToInt32(tbx_sayi1.Text) > 4900)

            {
                MessageBox.Show("Lütfen sadece 1 - 4900 arası sayı giriniz.");
                tbx_sayi1.Clear();
            }
          
        }
        //tbx_sayi2' girilen değerin sayı olduğunun kontrolü
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbx_sayi2.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen sadece sayı giriniz.");
                tbx_sayi2.Text = tbx_sayi2.Text.Remove(tbx_sayi2.Text.Length - 1);
                tbx_sayi2.Clear();
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(tbx_sayi2.Text, "[^a-zA-Z]") && Convert.ToInt32(tbx_sayi2.Text) > 4900)

            {
                MessageBox.Show("Lütfen sadece 1 - 4900 arası sayı giriniz.");
                tbx_sayi2.Clear(); 
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Yeniden butona basıldığında Listbox 'da bulunan değerler ve reverse sıfırlanıyor....
            listBox1.Items.Clear();
            reverse = 0;
            sayac = 0;
            //kullanıcılan alınan değerler değişkenlere aktarılıyor.
            sayi1 = Convert.ToInt32(tbx_sayi1.Text);
            sayi2 = Convert.ToInt32(tbx_sayi2.Text);


            //girilen iki sayı aralığında işlem yapılıyor.
            for (int i = sayi1; i <= sayi2; i++)
            {
                int gnumber = i;
                //Sayının Polindrom olduğunu bulan algoritma..
                while (gnumber != 0)
                {
                    reverse = reverse * 10;
                    reverse = reverse + gnumber % 10;
                    gnumber = gnumber / 10;
                }
                //eğer değer polindromsa listbox'a ekleniyor.
                if (reverse == i)
                {
                    listBox1.Items.Add(reverse);
                    listBox1.Text = reverse.ToString();
                    sayac++;
                    lbl_Sonuc.Visible = true;
                    lbl_Sonuc.Text = sayi1 + " ve " + sayi2 + " arasında " + sayac + " adet Polindrom sayı vardır.".ToString();
                }
                else
                {
                    //bir sonraki sayı için polindrom değeri sıfırlanıyor.
                    reverse = 0;

                }
            }

        }


    }
}
