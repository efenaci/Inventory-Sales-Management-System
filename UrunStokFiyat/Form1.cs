using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; 

namespace UrunStokFiyat
{
    public partial class Form1 : Form
    {
        List<string> urunadi = new List<string>();
        List<int> fiyat=new List<int>();
        List<int> stok=new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Lütfen bir ürün giriniz");
            else
            {
                urunadi.Add(textBox1.Text);
                stok.Add((int)numericUpDown1.Value);
                fiyat.Add((int)numericUpDown2.Value);

                textBox1.Clear();
                numericUpDown1.Value = 1;
                numericUpDown2.Value = 1;

                hesaplavelistele();
            }
        }

        void hesaplavelistele()
        {
            // Eklenen Ürün Sayısı
            // Ürünlerin Fiyat Ortalaması
            // En ucuz ve en pahalı ürün isimleri
            // Stokta en az ve en çok olan ürün isimleri

            int urunsayisi=urunadi.Count;

            int toplam = 0;
            comboBox1.Items.Clear();
            listBox2.Items.Clear();
            for(int i=0; i<urunsayisi; i++)
            {
                toplam += fiyat[i];

                comboBox1.Items.Add(urunadi[i]);

                listBox2.Items.Add(urunadi[i] + " - " + stok[i]);
            
            }
            double ortalama = toplam / urunsayisi;

            int enpahali = fiyat.Max();
            string enpahaliurun = urunadi[fiyat.IndexOf(enpahali)];

            int enucuz = fiyat.Min();
            string enucuzurun = urunadi[fiyat.IndexOf(enucuz)];

            int enaz=stok.Min();
            string enazstok = urunadi[stok.IndexOf(enaz)];

            int enfazla=stok.Max();
            string enfazlastok = urunadi[stok.IndexOf(enfazla)];

            listBox1.Items.Clear();
            listBox1.Items.Add("Ürün Sayısı: " + urunsayisi);
            listBox1.Items.Add("Ürün Fiyat Ortalaması:" + ortalama);
            listBox1.Items.Add("En Ucuz Ürün: " + enucuzurun);
            listBox1.Items.Add("En Pahalı Ürün: " + enpahaliurun);
            listBox1.Items.Add("Stokta En az Ürün: " + enazstok);
            listBox1.Items.Add("Stokta En Fazla Ürün: " + enfazlastok);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string secilenurun = comboBox1.Text;

            if (secilenurun == "") MessageBox.Show("Lütfen Ürün Seç");
            else
            {
                int index = urunadi.IndexOf(secilenurun);
                int stoksay = stok[index];

               

                int adet =(int) numericUpDown3.Value;

                if (adet > stoksay) MessageBox.Show("Yeterli Stok Bulunmamaktadır.");
                else
                {
                    stok[index] = stok[index] - adet;
                    MessageBox.Show("Ürün Satıldı");
                    hesaplavelistele();
                }



            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
