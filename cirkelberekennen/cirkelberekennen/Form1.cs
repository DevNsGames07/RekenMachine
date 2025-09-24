using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cirkelberekennen
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

        private void omtrek_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void oppervlakte_textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int straal = int.Parse(aantal_textBox1.Text);
            double π = 3.141;
            double oppervlakte = π * straal * straal;
            double omtrek = 2 * π * straal;

            oppervlakte_textBox3.Text = $"{oppervlakte}";
            omtrek_textBox2.Text = $"{omtrek}";

        }
    }
}
