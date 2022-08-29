using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int a;
        public int b;
        public bool flag = false;
        Timer timer2 = new Timer();

        public Form1()
        {
            InitializeComponent();
            timer2.Enabled = true;
            timer2.Interval = 200;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            textBox1.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b++;
            textBox2.Text = b.ToString();
            Thread.Sleep(1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == false)
            {
                pictureBox1.BackColor = Color.Red;
                flag = true;
            }
            else
            {
                pictureBox1.BackColor = Color.Green;
                flag = false;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (flag == false)
            {
                pictureBox2.BackColor = Color.Red;
                flag = true;
            }
            else
            {
                pictureBox2.BackColor = Color.Green;
                flag = false;
                
            }
            
        }
    }
}
