using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperatuur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temp_attextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fahrenheit_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kelvin_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(temp_attextBox1.Text);
            int TFahrenheit = (9 * temp / 5) + 32;
            int TKelvin = temp + 273;

            fahrenheit_textBox1.Text = $"{TFahrenheit}";
            kelvin_textBox2.Text = $"{TKelvin}";

        }
    }
}
