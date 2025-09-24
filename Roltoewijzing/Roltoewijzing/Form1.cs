using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roltoewijzing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void melding_button1_Click(object sender, EventArgs e)
        {
            int coderole = Convert.ToInt32(code_textBox.Text);

            string rolenaamoutput = regelnaam(coderole);

            antwoordrol_textBox1.Text = rolenaamoutput.ToString();
        }
        string regelnaam(int coderole)
        {

            string geenrol = "Geen rol bekend bij ons";
            if (coderole == 0)
            {
                return "Administrator";
            }
            else if (coderole == 1)
            {

              return "Gebruiker";

            } 
              return geenrol;
        }
    }
}
