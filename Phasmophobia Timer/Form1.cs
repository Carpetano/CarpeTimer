using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpeTimer
{
    public partial class Form1 : Form
    {

        Stopwatch stopwatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Function to run on every tick
        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan ts = new TimeSpan(0,0,0,0, (int) stopwatch.ElapsedMilliseconds);

            labelMS.Text = ts.Milliseconds.ToString().Length > 3? "0" + ts.Milliseconds.ToString() : ts.Milliseconds.ToString();
            labelSS.Text = ts.Seconds.ToString().Length > 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            labelMM.Text = ts.Minutes.ToString().Length > 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            labelHH.Text = ts.Hours.ToString().Length > 2 ? "0" + ts.Hours.ToString() : ts.Hours.ToString();

        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            timer1.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            timer1.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            timer1.Enabled = false;
        }

    }
}
