using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_Vardas.Text == "")

            {
                MessageBox.Show("Vardas negali buti tuscias");
                return;
            }

            textBox2.Text = $"Sveikass {tb_Vardas.Text}";
            textBox2.AppendText("\r\nMalonu tave matyti");
        }
    }
}
