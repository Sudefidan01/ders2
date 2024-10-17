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
    public partial class CheckBoxOrnek : Form
    {
        public CheckBoxOrnek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat = 0, tutar=0;
            try
            {
                fiyat=double.Parse(textBox1.Text);
            }
            catch 
            {
                lblSonuc.Text = "Lütfen Geçerli Bir Değer Giriniz";
                lblSonuc.ForeColor = Color.Red;
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            tutar = fiyat;
            if (checkBox1.Checked)
            {
             //   label1.Text = (fiyat - (fiyat * 0.25)).ToString();
                tutar = fiyat - (fiyat * 0.25);
            }

            lblSonuc.Text="Tutar = "+ tutar.ToString();
            lblSonuc.ForeColor= Color.Green;






        }
    }
}
