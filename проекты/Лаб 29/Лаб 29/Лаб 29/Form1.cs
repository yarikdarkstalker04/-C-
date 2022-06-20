using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            int[,] a = new int[3, 3];
            int i, j;
            int sum = 0;
            int proiz = 1;
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    a[i,j]=Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
            for (i = 0; i < 3; i++)
            {
                sum+=a[1, i];
            }

            for (i = 0; i < 3; i++)
            {
                proiz += a[i, 0];
            }
            textBox1.Text = "Сумма второй строки:"+Convert.ToString(sum)+";"+Environment.NewLine+"Произведение второго столбца:"+Convert.ToString(proiz);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            int[,] a = new int[3, 3];
            int i, j;

            Random rand = new Random();
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    a[i, j] = rand.Next(-100, 100);

            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            int[,] a = new int[3, 3];
            int i, j;

            Random rand = new Random();
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    a[i, j] = rand.Next(-100, 100);

            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
        }
    }
}
