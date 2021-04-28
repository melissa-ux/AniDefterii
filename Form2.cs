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
    public partial class Form2 : Form
    {
        Form3 form3;
        Form4 form4;
        Form2 form2;
        Form5 form5;
        Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6BDNKN2\SQLEXPRESS;Initial Catalog=Defter;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();

            for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
            {
                textBox2.Text = openFileDialog1.FileName;
                textBox3.Text = openFileDialog1.SafeFileName;

                listBox1.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                listBox2.Items.Add(openFileDialog1.FileNames[i].ToString());

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox2.SelectedIndex = listBox1.SelectedIndex;
            axWindowsMediaPlayer1.URL = listBox2.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_2 (Fotograf,Sarki_ad,Sarki_url,Soz,Tarih) values (@p1, @p2, @p3, @p4, @p5)", baglanti);


            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", textBox2.Text);
            komut.Parameters.AddWithValue("@p4", textEdit1.Text);
            komut.Parameters.AddWithValue("@p5", textBox4.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fotoğrafların ve Duyguların emin ellerde.");

        }

        private void button4_Click(object sender, EventArgs e)
        {

            form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
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
