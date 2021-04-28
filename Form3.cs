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

namespace AniDefterii
{
    public partial class Form3 : Form
    {
        Form2 form2;
        Form4 form4;
        Form3 form3;
        Form1 form1;
        Form5 form5;
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6BDNKN2\SQLEXPRESS;Initial Catalog=Defter;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'defterDataSet.Table_2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_2TableAdapter.Fill(this.defterDataSet.Table_2);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textEdit1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            listBox2.Items.Add(textBox3.Text);
            listBox3.Items.Add(textBox2.Text);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox3.SelectedIndex;
            axWindowsMediaPlayer1.URL = listBox2.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
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

        private void button9_Click(object sender, EventArgs e)
        {
            form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
