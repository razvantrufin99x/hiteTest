using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace hiteTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "DOWN";
            while (Text != "HIT")
            {
                if (mingea1.Top + mingea1.Height >= bara1.Top)
                {
                    Text = "HIT";
                }
                else
                {
                    mingea1.Top += 1;
                }
                Thread.Sleep(10);
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = "UP";
            while (Text != "HIT")
            {
                if (mingea1.Top <= bara2.Top + bara2.Height)
                {
                    Text = "HIT";
                }
                else
                {
                    mingea1.Top -= 1;
                }
                Thread.Sleep(10);
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text = "LEFT";
            while (Text != "HIT")
            {
                if (mingea1.Left <= bara3.Left + bara3.Width)
                {
                    Text = "HIT";
                }
                else
                {
                    mingea1.Left -= 1;
                }
                Thread.Sleep(10);
            };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Text = "Rigth";
            while (Text != "HIT")
            {
                if (mingea1.Left+mingea1.Width >= bara4.Left)
                {
                    Text = "HIT";
                }
                else
                {
                    mingea1.Left+=1;
                }
                Thread.Sleep(10);
            };
        }
    }
}
