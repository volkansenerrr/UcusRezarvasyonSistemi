using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcusRezarvasyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + " Nereden:" + comboBox1.Text + " >>>>> " + " Nereye:" + comboBox2.Text + " -- " + " Tarih:" + dateTimePicker1.Text + " -- " + " Saat:" + maskedTextBox1.Text + " -- " + " Yolcu Adı:" + textBox1.Text + " -- " + " Yolcu Soyadı:" + textBox2.Text + " -- " + " Telefon Numarası:" + maskedTextBox3.Text + " -- " + " TC Kimlik Numarası:" + maskedTextBox2.Text);
            MessageBox.Show("Yolcu kaydı yapıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox1.Text; // label10 benim geçiş etiketim.comboBox1 içinde ki metni buraya yazdırdım.
            comboBox1.Text = comboBox2.Text; // comboBox2 içindeki metni comboBox1 içine yazdırdım.
            comboBox2.Text = label10.Text; // Label10 içindeki metin comboBox1'in ilk metniydi bunuda comboBox2'ye yazdırdım.
            //Bu döngü sayesinde nereden ve nereye metinlerini uygulamada değiştirebiliyorum.
            //label10 visible yani görünürlüğünü false yapınca programda görünmeyecek.
        }
    }
}
