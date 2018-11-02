using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teewer
{
    public partial class Form1 : Form
    {
        private bool uzwer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Text = "URL Opener";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_uzwer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (uzwer)
            {
                pnl1_1.Visible = true;
                timer1.Stop();
                uzwer = false;
            }
            else
            {
                pnl1_1.Visible = false;
                timer1.Stop();
                uzwer = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (uzwer)
            {
                pnl1_2.Visible = true;
                timer2.Stop();
                uzwer = false;
            }
            else
            {
                pnl1_2.Visible = false;
                timer2.Stop();
                uzwer = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (uzwer)
            {
                comboBox1.Visible = true;
                timer3.Stop();
                uzwer = false;
            }
            else
            {
                comboBox1.Visible = false;
                timer3.Stop();
                uzwer = true;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }
    }
}
