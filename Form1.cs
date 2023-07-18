using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hour, min, sec = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sec = 0;

            label2.Text = "0";
            label3.Text = "0";
            min = 0;           
            hour = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            label1.Text = sec.ToString();

            if (sec == 60 )
            {
                min++;
                label2.Text = min.ToString();
                sec = 0;
                
                if (min == 3 )
                {
                    hour++;
                    label3.Text = hour.ToString();
                }
            }
        }
    }
}
