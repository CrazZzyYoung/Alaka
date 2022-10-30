using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double q = Math.Round((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a), 1);
            double w = Math.Round((b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a), 1);

            label4.Text = $"Корень = {q.ToString()}";
            label5.Text = $"Корень = {w.ToString()}";

            label4.Visible = true;
            label5.Visible = true;


        }
    }
}
