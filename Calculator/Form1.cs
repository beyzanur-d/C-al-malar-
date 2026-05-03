using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beyzaWindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int s1, s2, sonuc, islem = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "9";
        }
        private void button14_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //+
            s1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            islem = 1;
            label2.Text = s1 + "+";
            textBox1.Focus();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //-
            s1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            islem = 2;
            label2.Text = s1 + "-";
            textBox1.Focus();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //*
            s1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            islem = 3;
            label2.Text = s1 + "*";
            textBox1.Focus();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            // /
            s1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            islem = 4;
            label2.Text = s1 + "/";
            textBox1.Focus();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            //c
            label2.Text = "...";
            label1.Text = "...";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            //=
            if (textBox1.Text == "")
            {
                label1.Text = "Hata";
                MessageBox.Show("Lütfen sayı giriniz.");
                goto git;
                label1.Text = "Hata";
            }
            s2 = Convert.ToInt32(textBox1.Text);
            if (islem == 1)
            {
                sonuc = s1 + s2;
                label1.Text = Convert.ToString(sonuc);
                textBox1.Clear();
                label2.Text = s1.ToString() + "+" + s2.ToString() + "=" + sonuc;
            }
            else if (islem == 2)
            {
                sonuc = s1 - s2;
                label1.Text = Convert.ToString(sonuc);
                textBox1.Clear();
                label2.Text = s1.ToString() + "-" + s2.ToString() + "=" + sonuc;
            }
            else if (islem == 3)
            {
                sonuc = s1 * s2;
                label1.Text = Convert.ToString(sonuc);
                textBox1.Clear();
                label2.Text = s1.ToString() + "*" + s2.ToString() + "=" + sonuc;
            }
            else if (islem == 4)
            {
                sonuc = s1 / s2;
                label1.Text = Convert.ToString(sonuc);
                textBox1.Clear();
                label2.Text = s1.ToString() + "/" + s2.ToString() + "=" + sonuc;
                MessageBox.Show("Uyarı!Bölme işlemimizde hesap makinemiz sonucun tam kısmını vermektedir.");
                islem = 0;
            }
            git:
            textBox1.Focus();
        }
    }
}
