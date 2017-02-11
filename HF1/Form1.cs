using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF1
{
    public partial class Form1 : Form
    {
        int szam;
        int eredmeny;
        int Szamolasi_eset;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //8
            textBox1.Text = textBox1.Text + 8; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1
            textBox1.Text = textBox1.Text + 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //CE
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //+
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //-
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //*
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // /
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //9
            textBox1.Text = textBox1.Text + 9;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //6
            textBox1.Text = textBox1.Text + 6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //3
            textBox1.Text = textBox1.Text + 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //C
            int hossz = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < hossz; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //2
            textBox1.Text = textBox1.Text + 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //5
            textBox1.Text = textBox1.Text + 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //7
            textBox1.Text = textBox1.Text + 7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //4
            textBox1.Text = textBox1.Text + 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //0
            textBox1.Text = textBox1.Text + 0;
        }


        public void szamito()
        {
            switch (Szamolasi_eset)
            {
                case 1:
                    eredmeny = szam + int.Parse(textBox1.Text);
                    textBox1.Text = eredmeny.ToString();             //összeadás
                    break;

                case 2:
                    eredmeny = szam - int.Parse(textBox1.Text);
                    textBox1.Text = eredmeny.ToString();             //kivonás
                    break;

                case 3:
                    eredmeny = szam * int.Parse(textBox1.Text);
                    textBox1.Text = eredmeny.ToString();                //szorzás
                    break;

                case 4:
                    eredmeny = szam / int.Parse(textBox1.Text);
                    textBox1.Text = eredmeny.ToString();                 //osztás
                    break;

                default: break;
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            //8
            textBox1.Text = textBox1.Text + 8;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1
            textBox1.Text = textBox1.Text + 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //CE
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //+
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //-
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //*
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // /
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //9
            textBox1.Text = textBox1.Text + 9;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //6
            textBox1.Text = textBox1.Text + 6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //3
            textBox1.Text = textBox1.Text + 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //C
            int hossz = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < hossz; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //2
            textBox1.Text = textBox1.Text + 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //5
            textBox1.Text = textBox1.Text + 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //7
            textBox1.Text = textBox1.Text + 7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //4
            textBox1.Text = textBox1.Text + 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //0
            textBox1.Text = textBox1.Text + 0;            
        }
    }
}
