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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string metin = txtEkle.Text;
            if (string.IsNullOrEmpty(metin))
            {
                label1.Text = "Metin Alanı Boş Bırakılamaz";
                label1.ForeColor = Color.Red;
                txtEkle.Focus();
            }
            //ListBox içerisine yeni bir öğe ekleyelim
            //Syntax
            //<listBoxName>.Items.Add(<deger>);
            else
            {
                listBox1.Items.Add(metin);
                txtEkle.Clear();
                label1.Text = "'" + metin + "' değeri başarı ile eklendi ";
                label1.ForeColor = Color.Green;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //Seçili olan listbox item'ının index numarasına ulaşmak için SelectedIndex property sini kullanabilirsiniz

            int seciliIndex = listBox1.SelectedIndex;

            //Listbox içerisindeki öğelerden seçili index numarasına bağlı olan öğeyi txtDuzenle texbox ı içerisine aktaralım
            if (seciliIndex ==-1)
            {
                label1.Text = "Hiçbir Eleman Seçmediniz";
                label1.ForeColor = Color.Red;
            }
            else
            {
                txtDuzenle.Text = listBox1.Items[seciliIndex].ToString();

                btnHepsiniSil.Enabled = false;
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
                btnSil.Enabled = false;
                btnSirala.Enabled = false;
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int seciliIndex=listBox1.SelectedIndex;
            string metin = txtDuzenle.Text;
            if (!string.IsNullOrEmpty(metin)) 
            {
                listBox1.Items[seciliIndex] = metin;
                label1.Text = "Güncelleme İşlemi Başarılı";
                label1.ForeColor = Color.Green;
                txtDuzenle.Clear();

                btnHepsiniSil.Enabled = true;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
                btnSil.Enabled = true;
                btnSirala.Enabled = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int seciliIndex = listBox1.SelectedIndex;
                string metin = listBox1.Items[seciliIndex].ToString();
                listBox1.Items.RemoveAt(seciliIndex);
                label1.Text = string.Format("'{0}' Değeri Başarı İle Silindi",metin);
                label1.ForeColor=Color.Green;
            }
            catch 
            {
                label1.Text = "Silme işlemi esnasında bir hata meydana geldi";
                label1.ForeColor = Color.Red;
                
            }
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            //Listbox içerisindeki tüm verileri silmek için 
            listBox1.Items.Clear();

            label1.Text = "Tüm veriler Silindi";
            label1.ForeColor = Color.Green;
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = !listBox1.Sorted;
            if (listBox1.Sorted)
            {
                btnSirala.BackColor = Color.Green;
            }
            else
            {
                btnSirala.BackColor = Color.Red;
            }
        }
    }
}
