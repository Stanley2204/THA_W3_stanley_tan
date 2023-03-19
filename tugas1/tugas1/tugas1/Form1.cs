using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas1
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public bool check = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check == true && textBox1.Text != " " && textBox2.Text != " ")
            {
                form2.Change(textBox1.Text, textBox2.Text);
            }
            else
            {
                MessageBox.Show("Please enter the correct input");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.Show(this);
            check = true;
        }
    }
}
