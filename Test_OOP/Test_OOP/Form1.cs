using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_OOP
{
    public partial class Form1 : Form
    {
        Pcsestava pcsestava;
        Zakladnideska zakladnideska;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        bool jekomplet = false;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pcsestava = new Pcsestava(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
                zakladnideska = new Zakladnideska(textBox11.Text);
                jekomplet = true;
                MessageBox.Show("Byl vytvořen tvůj PC!", "Vytvořeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Nezadal jsi žádnou nebo jsi zadal špatnou hodnotu, zkus to ještě jednou!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pcsestava.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double cena = Double.Parse(textBox7.Text + textBox8.Text + textBox9.Text + textBox10.Text + textBox11.Text);
                MessageBox.Show("Cena celého PC je: " + cena, "CENA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Nezadal jsi žádnou nebo jsi zadal špatnou hodnotu, zkus to ještě jednou!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(jekomplet == true)
            {
                MessageBox.Show("Tvůj počítač je funkční!","Je Funkční", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("Tvůj počítač není funkční!", "Není Funkční", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
