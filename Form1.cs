using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
      
        }

        DataEncryptionStandard p = new DataEncryptionStandard();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
                if (textBox1.Text[i] != '1' && textBox1.Text[i] != '0') return;
            if (textBox1.Text.Length == 64)
            {
                textBox3.Text = p.Des(Convert.ToString(textBox4.Text), Convert.ToUInt64(textBox1.Text, 2), true);
                
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for(int i=0; i< textBox1.Text.Length; i++)
            if (textBox1.Text[i] != '1' && textBox1.Text[i] != '0') return;
            if (textBox1.Text.Length == 64)
            {
                textBox3.Text = p.Des(textBox4.Text, Convert.ToUInt64(textBox1.Text, 2), false);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {

        }
    }




}


