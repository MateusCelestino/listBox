using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar as informações
            if (txtNome.Text == "")
            {
                MessageBox.Show("O nome do produto não pode ficar em branco!");
                txtNome.Focus();
                return;
            }
            if (numPreco.Value == 0)
            {
                MessageBox.Show("O preço do produto não pode ser Zero!");
                numPreco.Focus();
                return;
            }

            if (numID.Value == 0)
            {
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
