using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Ders2
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form= new Form1();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckBoxOrnek form = new CheckBoxOrnek();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RadioButton form_RadiButton = new RadioButton();
            form_RadiButton.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RadioButtonOrnek form_RadioButtonOrnek= new RadioButtonOrnek();
            form_RadioButtonOrnek.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListBox form= new ListBox();
            form.Show();
        }
    }
}
