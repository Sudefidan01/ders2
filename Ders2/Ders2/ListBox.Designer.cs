﻿namespace Ders2
{
    partial class ListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.txtDuzenle = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 251);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtEkle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(221, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekleme İşlemi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(38, 65);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 43);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(38, 29);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(156, 30);
            this.txtEkle.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnDuzenle);
            this.groupBox2.Controls.Add(this.txtDuzenle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(221, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Düzenleme İşlemi";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(38, 65);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 43);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // txtDuzenle
            // 
            this.txtDuzenle.Location = new System.Drawing.Point(38, 29);
            this.txtDuzenle.Name = "txtDuzenle";
            this.txtDuzenle.Size = new System.Drawing.Size(156, 30);
            this.txtDuzenle.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(22, 303);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 52);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.Location = new System.Drawing.Point(182, 303);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(113, 52);
            this.btnHepsiniSil.TabIndex = 4;
            this.btnHepsiniSil.Text = "Hepsini Sil";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnSirala
            // 
            this.btnSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirala.Location = new System.Drawing.Point(353, 303);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(95, 52);
            this.btnSirala.TabIndex = 5;
            this.btnSirala.Text = "Sırala";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 79);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.btnHepsiniSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.ListBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.TextBox txtDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Label label1;
    }
}