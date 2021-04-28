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
    public partial class Form5 : Form
    {
        Form1 form1;
        Form2 form2;
        Form3 form3;
        Form5 form5;
        Form4 form4;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'defterDataSet1.Table_1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_1TableAdapter.Fill(this.defterDataSet1.Table_1);

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

        private void button10_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textEdit1.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }
    }
}
