using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3functies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int getaleen = Convert.ToInt32(getal1_textBox1.Text);
            int getaltwee = Convert.ToInt32(getal2_textBox2.Text);
            int getaldrie = Convert.ToInt32(getal3_textBox3.Text);



            int Totaleen = Getaleen(getaleen);
            int Totaltwee = Getaltwee(getaltwee);
            int Maxgetal = GrootsteGetal(Totaleen, Totaltwee, getaldrie);

            antwoord1_textBox4.Text = Totaleen.ToString();
            antwoord2_textBox5.Text = Totaltwee.ToString();
            antwoord3_textBox6.Text = Maxgetal.ToString();


        }

        int Getaleen(int getaleen)
        {
            return getaleen * 2;
        }
        int Getaltwee(int getaltwee)
        {
            return getaltwee * getaltwee;
        }
        int GrootsteGetal(int Totaleen, int Totaltwee, int getaldrie)
        {
            // Ik ga gewoon de functie uit c# gebruiken ik was uit eindelijk helemaal klaar met de if statements
            return Math.Max(Totaleen, Math.Max(Totaltwee, getaldrie));
        }


    }
}
