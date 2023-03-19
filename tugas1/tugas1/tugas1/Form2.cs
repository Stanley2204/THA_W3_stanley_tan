using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace tugas1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                button1.Enabled = true;
            }
            if (checkBox1.Checked == false || checkBox2.Checked == false)
            {
                button1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                button1.Enabled = true;
            }
            if (checkBox1.Checked == false || checkBox2.Checked == false)
            {
                button1.Enabled = false;
            }
        }

        public void Change(string textbox1, string textbox2)
        {
            label3.Text = ("Hi, my name is " + textbox1 + " and my favorite artist is " + textbox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            bool backgroundcolor = true;
            bool fontcolor = true;
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false)
            {
                backgroundcolor = false;
            }
            if (radioButton9.Checked == false && radioButton10.Checked == false && radioButton11.Checked == false)
            {
                fontcolor = false;
            }

            if (backgroundcolor == false || fontcolor == false)
            {
                MessageBox.Show("Pick your favorite color from the radio button!");
            }
            if (backgroundcolor == true && fontcolor == true)
            {
                if (radioButton1.Checked)
                {
                    form1.BackColor = Color.Red;
                }
                else if (radioButton2.Checked)
                {
                    form1.BackColor = Color.Orange;
                }
                else if (radioButton3.Checked)
                {
                    form1.BackColor = Color.Yellow;
                }
                else if (radioButton4.Checked)
                {
                    form1.BackColor = Color.Green;
                }
                else if (radioButton5.Checked)
                {
                    form1.BackColor = Color.Blue;
                }

                if (radioButton9.Checked)
                {
                    form1.ForeColor = Color.Red;
                }
                else if (radioButton10.Checked)
                {
                    form1.ForeColor = Color.Orange;
                }
                else if (radioButton11.Checked)
                {
                    form1.ForeColor = Color.Yellow;
                }
            }
        }
    }
}
