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
    public partial class RadioButton : Form
    {
        public RadioButton()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "1.Seçenek Seçili";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "2.Seçenek Seçili";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "3.Seçenek Seçili";
            }
            else if (radioButton4.Checked)
            {
                label1.Text = "4.Seçenek Seçili";
            }
            else
            {
                label1.Text = "Seçim Yapmadınız";
            }
        }

 
    }
}
