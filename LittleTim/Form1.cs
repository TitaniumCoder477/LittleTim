/**
        MIT License

		Copyright (c) 2017 James Wilmoth

		Permission is hereby granted, free of charge, to any person obtaining a copy
		of this software and associated documentation files (the "Software"), to deal
		in the Software without restriction, including without limitation the rights
		to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
		copies of the Software, and to permit persons to whom the Software is
		furnished to do so, subject to the following conditions:

		The above copyright notice and this permission notice shall be included in all
		copies or substantial portions of the Software.

		THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
		IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
		FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
		AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
		LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
		OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
		SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleTim
{
    public partial class littleTimFrm : Form
    {
        private int seconds = 0;
        private int minutes = 0;
        private int hours = 0;
        private string hSpacer, mSpacer, sSpacer;
        private string title = "LittleTim v1.0, MIT License, Copyright (c) 2017 James Wilmoth";
        private string titleSpacer = "    ";

        public littleTimFrm()
        {
            InitializeComponent();
            //In design view, I have this out of the way, so be sure to center it
            nameTxtBx.Location = new System.Drawing.Point(13,13);
            this.Text = title + titleSpacer;
            titleScrollTmr.Start();
        }        

        //If user double clicks form then assume he wants to rename it
        private void littleTimFrm_DoubleClick(object sender, EventArgs e)
        {
            titleScrollTmr.Stop();
            nameTxtBx.Text = title;
            nameTxtBx.Show();
            nameTxtBx.Focus();
        }

        //If user double clicks text box then assume he wants to blank it
        private void nameTxtBx_DoubleClick(object sender, EventArgs e)
        {
            nameTxtBx.Text = "";
        }

        //If user presses Enter key then save title and hide text box
        private void nameTxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                title = nameTxtBx.Text;
                this.Text = title + titleSpacer;
                nameTxtBx.Hide();
                titleScrollTmr.Start();
            }
        }

        private void timePastLbl_MouseClick(object sender, MouseEventArgs e)
        {
            //Right mouse button equals reset
            if(e.Button == MouseButtons.Right)
            {
                //Stop the timers
                pauseTmr.Stop();
                timePastTmr.Stop();
                //Reset the timer color
                timePastLbl.ForeColor = System.Drawing.Color.Black;                
                //Reset the timer text                
                timePastLbl.Text = "00:00:00";
                //Reset variables
                hours = minutes = seconds = 0;
            }
            //Left mouse button equals pause
            else if(e.Button == MouseButtons.Left)
            {
                //Only pause if timer is actually running and pause timer is not running
                if (timePastTmr.Enabled && !pauseTmr.Enabled)
                {
                    pauseTmr.Start();
                    timePastTmr.Stop();
                }
                //Otherwise, stop the pause timer, reset the timer color, and start it up again
                else
                {
                    pauseTmr.Stop();
                    timePastLbl.ForeColor = System.Drawing.Color.Black;
                    timePastTmr.Start();
                }
            }
                
        }

        //The pause timer alternatives colors
        private void pauseTmr_Tick(object sender, EventArgs e)
        {
            if (timePastLbl.ForeColor == System.Drawing.Color.Black)
                timePastLbl.ForeColor = System.Drawing.Color.Red;
            else
                timePastLbl.ForeColor = System.Drawing.Color.Black;
        }

        private void titleScrollTmr_Tick(object sender, EventArgs e)
        {
            this.Text = scrollText(this.Text, 1);
        }

        //The timer object
        private void timePastTmr_Tick(object sender, EventArgs e)
        {
            if(seconds++ == 60)
            {
                if(minutes++ == 60)
                {
                    hours++;
                    minutes = 0;
                }
                seconds = 0;
            }

            if (hours < 10) hSpacer = "0";
            else hSpacer = "";

            if (minutes < 10) mSpacer = "0";
            else mSpacer = "";

            if (seconds < 10) sSpacer = "0";
            else sSpacer = "";

            timePastLbl.Text = hSpacer + hours + ":" + mSpacer + minutes + ":" + sSpacer + seconds;
        }

        private string scrollText(string text, int num)
        {            
            string newText = text;            
            if (text.Length >= 20)
            {
                string block = text.Substring(0, num);
                newText = text.Substring(num);
                newText += block;
            }
            return newText;
        }
    }
}
