using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders2
{
    public partial class RadioButtonOrnek : Form
    {
        public RadioButtonOrnek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tutar=0 , fiyat=0;
            try
            {
                fiyat=double.Parse(textBox1.Text);
            }
            catch 
            {
                lblSonuc.Text = "Geçerli Bir Değer Giriniz";
                lblSonuc.ForeColor = Color.Red;
                textBox1.Clear();
                textBox1.Focus();
                return;
                
            }
            if(radioButton1.Checked)
            {
                lblSonuc.Text="Tutar = " + fiyat.ToString();
                lblSonuc.ForeColor = Color.Green;
            }
            else if (radioButton2.Checked)
            {
                tutar = fiyat - (fiyat * 0.25);
                lblSonuc.Text = "Tutar = " + tutar.ToString();
                lblSonuc.ForeColor = Color.Green;
            }
            else if (radioButton3.Checked)
            {
                tutar = fiyat - (fiyat * 0.50);
                lblSonuc.Text = "Tutar = " + tutar.ToString();
                lblSonuc.ForeColor = Color.Green;
            }
        }
    }
}
