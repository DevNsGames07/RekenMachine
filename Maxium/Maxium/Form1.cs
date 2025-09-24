using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int GetalEen = Convert.ToInt32(textBox1.Text);
            int GetaldTwee = Convert.ToInt32(textBox2.Text);
            int GetalDrie = Convert.ToInt32(textBox3.Text);

            int Totaleen = Getal(GetalEen);
            int Totaltwee = Antwoord2(GetaldTwee);
            int Antwoordmax = Laatsteantwoord(GetalEen, GetaldTwee, GetalDrie);

            textBox4.Text = Totaleen.ToString();
            textBox5.Text = Totaltwee.ToString();
            textBox6.Text = Antwoordmax();

        }
        int Getal(int GetalEen) {
            return GetalEen * 2;
        }
        int Antwoord2(int GetalTwee)
        {
            return GetalTwee * GetalTwee;
        }
        int Laatsteantwoord(int GetalEen, int GetaldTwee, int GetalDrie) {
            if (GetalEen > GetaldTwee){
                return GetalEen;
            } else if (GetalEen < GetaldTwee) {
                return GetaldTwee;
            } else if (GetalEen > GetalDrie)
            {
                return GetalEen;
            }
            else if (GetalEen < GetalDrie)
            {
                return GetalDrie;
            }
            else if (GetaldTwee > GetalDrie)
            {
                return GetaldTwee;
            }
            else if (GetaldTwee < GetalDrie)
            {
                return GetalDrie;
            }

        }
    }
}
