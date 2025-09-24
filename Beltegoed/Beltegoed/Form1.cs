using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beltegoed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void antwoord_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tegoed_button1_Click(object sender, EventArgs e)
        {

            double Beltegoed = Convert.ToInt32(beltegoed_textBox1.Text);

            if (Beltegoed == 0)
            {
                antwoord_textBox1.Text = "Je beltegoed is op.";
            } else if (Beltegoed < 10)
            {
                antwoord_textBox1.Text = "Je beltegoed moet opgewaardeerd worden.";
            } else if (Beltegoed >= 10)
            {
                antwoord_textBox1.Text = "Je hebt voldoende Beltegoed.";
            } else
            {
                antwoord_textBox1.Text = "-";
            }
        }
    }
}
