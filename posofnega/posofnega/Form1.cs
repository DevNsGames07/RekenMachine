using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posofnega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_button1_Click(object sender, EventArgs e)
        {
            int check = Convert.ToInt32(getal_textBox1.Text);

            string antwoordposi = checkwaarde(check);

            antwoord_textBox1.Text = antwoordposi.ToString();

        }
        string checkwaarde(int check)
        {
            if (check >= 1)
            {
                return "Positief";
            }
            else if (check <= -1)
            {
                return "Negatief";
            }
            else if (check == 0) 
            {
                return "Nul";
            }
        }
    }
}
