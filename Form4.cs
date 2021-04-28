using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace AniDefterii
{
    
    public partial class Form4 : Form
    {
    Form3 form3;
    Form2 form2;
    Form4 form4;
        Form5 form5;
        Form1 form1;


        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6BDNKN2\SQLEXPRESS;Initial Catalog=Defter;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_1 (Tarih,Günlük) values (@p1, @p2)", baglanti);

            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textEdit1.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Günlük duyguların emin ellerde.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            form5 = new Form5();
            form5.Show();
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
