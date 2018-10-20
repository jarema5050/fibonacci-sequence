using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacciForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public long an;
        public long anmin1;
        public long anplus1;
        private void button1_Click(object sender, EventArgs e)
        {
            ////Left <<<====
            long copy;
            copy = anplus1;
                anplus1 = an;
                an = copy - an;
                anmin1 = anplus1 - an;//= an-(anplus1-an)=2an-anplus1
                textBox1.Text = anmin1.ToString();
                textBox2.Text = an.ToString();
                textBox3.Text = anplus1.ToString();
            if (2 * an - anplus1 <= 0)
            {
                button1.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////Right ====>>>
            anmin1 = an;
            an = anplus1;
            anplus1 = anmin1 + an;
            textBox1.Text=anmin1.ToString();
            textBox2.Text = an.ToString();
            textBox3.Text = anplus1.ToString();
            if (2*an-anplus1 > 0)
            {
                button1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ///Insertion
            try
            {
                anmin1 = long.Parse(textBox1.Text);
                an = long.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input format!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Insert data!");
            }
            else if(anmin1>an)
            {
                MessageBox.Show("A(n) has to be greater or equal than A(n-1).");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            { 
                anplus1 = anmin1 + an;
                textBox3.Text = anplus1.ToString();
                button3.Hide();
                button4.Show();
                button1.Show();
                if (2*an-anplus1 <= 0)
                {
                    button1.Hide();
                }
                button2.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            ///Clearing buffer
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            an = 0;
            anmin1 = 0;
            anplus1 = 0;
            button3.Show();
            button4.Hide();
            button1.Hide();
            button2.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
