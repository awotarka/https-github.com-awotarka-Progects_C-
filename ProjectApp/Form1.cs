using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            learning1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            books1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            targets1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ideas1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
        }
    }
}
