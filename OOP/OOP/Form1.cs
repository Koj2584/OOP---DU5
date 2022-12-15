using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Veteran atlet;
        private void button1_Click(object sender, EventArgs e)
        {
            atlet = new Veteran(textBox1.Text, (short)numericUpDown3.Value);
            label2.Text = "Unava: " + atlet.ZjistitUnavu();
            label3.Text = atlet.Jmeno;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atlet.Behej((int)numericUpDown1.Value);
            label2.Text = "Unava: " + atlet.ZjistitUnavu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            atlet.Spi((int)numericUpDown2.Value);
            label2.Text = "Unava: " + atlet.ZjistitUnavu();
        }
    }
}
