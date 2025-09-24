using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dubblefunctie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bereken_button1_Click(object sender, EventArgs e)
        {

            int GetalEen = Convert.ToInt32(getal1_textBox1.Text);
            int GetalTwee = Convert.ToInt32(getal2_textBox2.Text);
            int GetalDrie = Convert.ToInt32(getal3_textBox3.Text)

            int TotalGetaleen = Verdubbel(GetalEen);
            int totalGetaltwee = Driedubbel(GetalTwee);


            vedubbel_textBox3.Text = TotalGetaleen.ToString();
            driedubbel_textBox4.Text = totalGetaltwee.ToString();


        }
        int Verdubbel(int GetalEen)
        {
            return GetalEen * 2;

        }
        int Driedubbel(int GetalTwee)
        {
            return GetalTwee * 3;    
        }
    }
}
