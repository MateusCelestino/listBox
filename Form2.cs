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
    public partial class Form2 : Form
    {
        List<string> categorias = new List<string> {
            "Natal",
            "Dia dos Namorados",
            "Dia dos Pais",
            "Dia das Mães",
            "Páscoa",
            "Dia da Rata"
        };
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                return;
            categorias.Add(txtNome.Text);
            txtNome.Clear();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
               "Deseja remover o item?",
               "Remoção de item",
               MessageBoxButtons.YesNo
           );
            if (resultado == DialogResult.No)
                return;
            int indiceItem = lsvItens.SelectedIndex;

            // Remove o item da lista
            categorias.RemoveAt(indiceItem);

            btnRemover.Enabled = false;

            
        }

        private void btnCategoriasDeCesta_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }   

        private void btnListaDeProdutos_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ConfiguraListView();
        }
        void ConfiguraListView()
        {
            lsvItens2.View = View.Details;
            lsvItens2.Columns.Add("ID");
            lsvItens2.Columns.Add("Nome");
            lsvItens2.Columns.Add("Preço");           

   
        }

        private void lsvItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
