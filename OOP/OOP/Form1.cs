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
        bool loaded;
        public Form1()
        {
            InitializeComponent();
            loaded = false;
        }
        Zamestnanec zam;
        Vedouci ved;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bool all = true;
            foreach (TextBox t in panel2.Controls)
            {
                if (t.Text.Length == 0)
                    all = false;
            }
            if (all)
            {
                try
                {
                    zam = new Zamestnanec(textBox1.Text, textBox2.Text, DateTime.Now, short.Parse(textBox3.Text));
                }
                catch
                {
                    if (radioButton1.Checked)
                        MessageBox.Show("Nesprávné hodnoty!!");
                    radioButton1.Checked = false;
                }
            }
            else
            {
                if (radioButton1.Checked)
                    MessageBox.Show("Nejsou vyplněny potřebné hodnoty!!");
                radioButton1.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bool all = true;
            foreach (TextBox t in panel2.Controls)
            {
                if (t.Text.Length == 0)
                    all = false;
            }
            foreach (TextBox t in panel1.Controls)
            {
                if (t.Text.Length == 0)
                    all = false;
            }
            if (all)
            {
                try
                {
                    ved = new Vedouci(textBox1.Text, textBox2.Text, DateTime.Now, short.Parse(textBox3.Text), short.Parse(textBox4.Text), textBox5.Text);
                }
                catch
                {
                    if (radioButton2.Checked)
                        MessageBox.Show("Nesprávné hodnoty!!");
                    radioButton2.Checked = false;
                }
            }
            else
            {
                if(radioButton2.Checked)
                    MessageBox.Show("Nejsou vyplněny potřebné hodnoty!!");
                radioButton2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    zam.OdpracujHodiny(short.Parse(textBox6.Text));
                    MessageBox.Show(zam.Vypis(),"Zaměstnanec",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Nesprávné hodnoty!!");
                }
            }
            else if (radioButton2.Checked)
            {
                try
                {
                    ved.OdpracujHodiny(short.Parse(textBox6.Text));
                    MessageBox.Show(ved.Vypis(), "Vedoucí", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Nesprávné hodnoty!!");
                }
            }
            else
                MessageBox.Show("Prvně musíte vytvořit objekt!!");
        }
    }
}
