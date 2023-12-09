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
        Listas lista;
  
        public Form3()
        {
            InitializeComponent();
            lista = new Listas();
            
            AtualizaItensListView();
            ConfiguraListView();
        }
       void AtualizaItensListView()
        {
            
            listView1.Items.Clear();

            
            foreach (Produto produto in lista.lista_produtos)
            {
                AdicionarItemListView(produto);
            }
        }
        void AdicionarItemListView(Produto produto)
        {
            // Cria um item vazio
            ListViewItem item = new ListViewItem(produto.Id.ToString());

            item.SubItems.Add(produto.Nome);
            item.SubItems.Add(produto.Preco.ToString("c"));

            // Adiciona o item na listView
            listView1.Items.Add(item);
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
            int id = ((int)numID.Value);
            Produto? produto = BuscaProdutoId(id);

            if (produto != null)
            {
                int index = lista.lista_produtos.FindIndex(item => object.Equals(item, produto));
                Produto produto_editado = new Produto
                    { Id = (int)numID.Value, Nome = txtNome.Text, Preco = numPreco.Value };
                lista.lista_produtos[index] = produto_editado;
            }
            else
            {
                    Produto novo_produto = new Produto
                    {
                        Id = (int)numID.Value,
                        Nome = txtNome.Text,
                        Preco = numPreco.Value
                    };
                    lista.lista_produtos.Add(novo_produto);

            }
            FechaFormulario();
            AtualizaItensListView();
        }
        private Produto? BuscaProdutoId(int Id)
        {
            Produto produto = lista.lista_produtos.Find(prod => prod.Id == Id);

            if (produto.Id == 0)
                return null;

            return produto;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int id = int.Parse(item.Text);

                Produto produto = lista.lista_produtos.Find(prod => prod.Id == id);

                numID.Value = produto.Id;
                txtNome.Text = produto.Nome;
                numPreco.Value = produto.Preco;
                
                break;
            }

            if (numID.Value == 0)
                return;
            
            grbFormulario.Visible = true;
            
            txtNome.Focus();
            
            btnNovoItems.Enabled = false;
            btnEditar.Enabled = false;
            btnApagar.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        { 
            ConfiguraListView();
        }

        void ConfiguraListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Nome");
            listView1.Columns.Add("Preço");
            AtualizaItensListView();
        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FechaFormulario();
        }
        void FechaFormulario()
        {
            // Esconde o formulário
            grbFormulario.Visible = false;

            // Habilita os botões
            btnNovoItems.Enabled = true;
            btnEditar.Enabled = true;
            btnApagar.Enabled = true;

            // Limpa os campos
            txtNome.Clear();
            numID.Value = 0;
            numPreco.Value = 0;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int id = int.Parse(item.Text);
                Produto produto = lista.lista_produtos.Find(prod => prod.Id == id);
                lista.lista_produtos.Remove(produto);
            }

            AtualizaItensListView();
        }

        private void btnNovoItems_Click(object sender, EventArgs e)
        {
            grbFormulario.Visible = true;
            txtNome.Focus();
            btnNovoItems.Enabled = false;
            btnEditar.Enabled = false;
            btnApagar.Enabled = false;
            numID.Value = PegarUltimoIdLista() + 1;
        }
        private int PegarUltimoIdLista()
        {
            return lista.lista_produtos.Max(produto => produto.Id);
        }
        
    }
    }

