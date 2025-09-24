using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Woonplaats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void voornaam_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void woonplaats_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void reistijd_button_Click(object sender, EventArgs e)
        {
            string voornaam = voornaam_textbox.Text;
            string woonplaats = woonplaats_textbox.Text;
            string duur = listBox1.Text;

            anwoord_textbox.Text = $"Ik ben {voornaam}, ik woon in {woonplaats} en mijn reistijd is {duur} dan een half uur.";

        }

        private void anwoord_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

        }
    }
}
