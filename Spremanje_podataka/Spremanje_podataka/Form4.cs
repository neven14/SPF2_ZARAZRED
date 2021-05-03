using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spremanje_podataka
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frmPocetna = new Form3();
            frmPocetna.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text.Contains('@'))
                {
                    Ucenik objUcenik = new Ucenik(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    MessageBox.Show("Podaci su uneseni.", "Unos OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Greska");
            }
        }
    }
}
