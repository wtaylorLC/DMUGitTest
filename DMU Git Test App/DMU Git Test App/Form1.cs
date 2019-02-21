using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMU_Git_Test_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am a Happy Monkey!");
        }

        private void buttonChangeColour_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            byte randR = (byte)rnd.Next(255);
            byte randG = (byte)rnd.Next(255);
            byte randB = (byte)rnd.Next(255);

            this.BackColor = Color.FromArgb(randR, randG, randB);
        }
    }
}
