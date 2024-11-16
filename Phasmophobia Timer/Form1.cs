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

        private void button1_Click(object sender, EventArgs e)
        {

            stopwatch.Start();
            timer1.Enabled = true;

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = new TimeSpan(0, 0, 0, 0, (int) stopwatch.ElapsedMilliseconds);

            txtSeconds.Text = span.Seconds.ToString().Length < 2 ? "0" + span.Seconds.ToString() : span.Seconds.ToString();
            txtMinutes.Text = span.Minutes.ToString().Length < 2 ? "0" + span.Minutes.ToString() : span.Minutes.ToString();
            txtHours.Text = span.Hours.ToString().Length < 2 ? "0" + span.Hours.ToString() : span.Hours.ToString();

        }
    }
}
