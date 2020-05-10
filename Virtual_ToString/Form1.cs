using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_ToString
{
    public partial class Form1 : Form
    {
        public Form1() // Constructor
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Kisi ks = new Kisi();
            ks.ad = "Negan";
            ks.soyad = "Lucille";
            ks.yas = 52;

            MessageBox.Show(ks.ToString()); // ks nesnesini string çevir ve göster.
            listBox1.Items.Add(ks); // ks nesnesini kişi tipinde ekle.
            listBox1.Items.Add(ks.ToString()); // ks nesnesini string'e çevir ve ekle.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Kisi)
            {
                Kisi k1 = (Kisi)listBox1.SelectedItem;
                MessageBox.Show(k1.ad);
            }
        }
    }
}
// InitializeComponent(): Çalışma anında form üzerindeki ve toolbox'taki araçları veya kontrolleri hazırlayan methoddur.