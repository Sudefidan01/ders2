﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Text = "CheckBox Seçili";
                label1.ForeColor= Color.Green;
            }
            else 
            {
                label1.Text = "CheckBox Seçili Değil";
                label1.ForeColor= Color.Red;
            }
        }
    }
}
