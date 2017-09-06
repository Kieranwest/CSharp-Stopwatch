using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Some_Counter_Thing
{
    public partial class Form1 : Form
    {

        int ms, s, m, h; //Milliseconds | Seconds | Minutes | Hours

        public Form1()
        {
            InitializeComponent();
            ms = 0; //On First Load Milliseconds = 0
        }

        private void button1_Click(object sender, EventArgs e) //When 'Start' is clicked
        {
            timer1.Start(); //Start the timer
        }

        private void button2_Click(object sender, EventArgs e) //When 'Stop' is clicked
        {
            timer1.Stop(); //Stop the timer
        }

        private void button3_Click(object sender, EventArgs e) //When 'Reset' is clicked
        {
            //Stop the timer and reset all variables/text to 0
            timer1.Enabled = false;
            ms = 0;
            h = 0;
            s = 0;
            m = 0;
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
        }

        private void timer1_Tick(object sender, EventArgs e) //Timer Loop
        {
            ms = ms + 1; //Add 1 millisecond to previous millisecond value. 
            if (ms == 9) //If Miliiseconds = 9
            {
                ms = 0; //Set milliseconds back to 0
                s = s + 1; //Add 1 second to previous second value
                label3.Text = s.ToString(); //Change 'Second' label text to the new seconds value
                if (s == 59) //If seconds = 59
                {
                    s = 0; //Set seconds back to 0
                    m = m + 1; //Add 1 minute to previous minute value
                    label2.Text = m.ToString(); //Change 'Minute' label text to the new minute value
                    if (m == 59) //If minutes = 59
                    {
                        m = 0; //Set miniutes back to 0
                        h = h + 1; //Add 1 hour to previous hour value
                        label1.Text = h.ToString(); //Change 'Hour' label text to the new hour value
                    }
                }
            }
        }
    }
}
