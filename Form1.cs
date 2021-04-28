using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniDefterii
{
    public partial class Form1 : Form
    {
        Form2 form2;
        Form3 form3;
        Form4 form4;
        Form5 form5;
        Form1 form1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
