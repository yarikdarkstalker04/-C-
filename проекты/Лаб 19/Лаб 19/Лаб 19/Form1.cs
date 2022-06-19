using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            double x = double.Parse(textBox1.Text);
            // Вывод значения X в окно
            textBox4.Text +=
            " X = " +x.ToString();
            // Считывание значения Y
            double y = double.Parse(textBox2.Text);
            // Вывод значения Y в окно
            textBox4.Text += Environment.NewLine +
            " Y = " +y.ToString();
            // Считывание значения Z
            double z = double.Parse(textBox3.Text);
            // Вывод значения Z в окно
            textBox4.Text += Environment.NewLine +
            " Z = " +z.ToString();
            // Вычисляем арифметическое выражение
            double a = Math.Pow((8+Math.Abs(x-y)* Math.Abs(x - y)+1),1.0/3.0);
            double b = x * x + y * y + 2;
            double c = Math.Exp(Math.Abs(x-y));
            double d = Math.Pow((Math.Tan(z)* Math.Tan(z)+1),x);
            double u = a/b-c*d;
            // Выводим результат в окно
            textBox4.Text += Environment.NewLine +
            " Результат U = " +u.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-4,5";
            textBox2.Text = "0,000075";
            textBox3.Text = "84,5";
        }
    }
}
