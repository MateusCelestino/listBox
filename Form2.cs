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
        List<Produto> lista_produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Chocolate", Preco = 19.9m },
            new Produto { Id = 2, Nome = "Vinho", Preco = 29.5m },
            new Produto { Id = 3, Nome = "Flores", Preco = 15.0m },
            new Produto { Id = 4, Nome = "Cartão de Aniversário", Preco = 5.99m },
            new Produto { Id = 5, Nome = "Cesta de Frutas", Preco = 25.0m },
            new Produto { Id = 6, Nome = "Perfume", Preco = 49.99m },
            new Produto { Id = 7, Nome = "Caneca Personalizada", Preco = 12.5m },
            new Produto { Id = 8, Nome = "Bolo Decorado", Preco = 34.99m },
            new Produto { Id = 9, Nome = "Chá Especial", Preco = 9.0m },
            new Produto { Id = 10, Nome = "Kit de Velas Perfumadas", Preco = 18.75m },
            new Produto { Id = 11, Nome = "Livro de Poesias", Preco = 22.8m },
            new Produto { Id = 12, Nome = "Bouquet de Balões", Preco = 8.5m },
            new Produto { Id = 13, Nome = "Kit de Massagem", Preco = 42.0m },
            new Produto { Id = 14, Nome = "Caneta de Luxo", Preco = 30.25m },
            new Produto { Id = 15, Nome = "Café Gourmet", Preco = 14.99m },
            new Produto { Id = 16, Nome = "Kit de Maquiagem", Preco = 55.0m },
            new Produto { Id = 17, Nome = "Almofada Personalizada", Preco = 16.5m },
            new Produto { Id = 18, Nome = "Queijo Especial", Preco = 27.75m },
            new Produto { Id = 19, Nome = "Relógio Decorativo", Preco = 38.0m },
            new Produto { Id = 20, Nome = "Jogo de Toalhas Bordadas", Preco = 19.0m },
            new Produto { Id = 21, Nome = "Conjunto de Taças", Preco = 32.5m },
            new Produto { Id = 22, Nome = "Caixa de Bombons Finos", Preco = 23.49m },
            new Produto { Id = 23, Nome = "Cesta de Café da Manhã", Preco = 44.99m },
            new Produto { Id = 24, Nome = "Kit de Plantas Ornamentais", Preco = 28.0m },
            new Produto { Id = 25, Nome = "Porta-Retrato Personalizado", Preco = 10.0m },
            new Produto { Id = 26, Nome = "Sabonetes Artesanais", Preco = 13.25m },
            new Produto { Id = 27, Nome = "Kit de Jogos de Tabuleiro", Preco = 36.75m },
            new Produto { Id = 28, Nome = "Garrafa de Champagne", Preco = 49.5m },
            new Produto { Id = 29, Nome = "Kit de Pintura", Preco = 20.99m },
            new Produto { Id = 30, Nome = "Copo Térmico", Preco = 15.0m }
        };
        
        // Executa quando o formulário carrega
        public Form2()
        {
            InitializeComponent();
            ConfiguraListView();
            AtualizaItensListView();
            
        }
        void AtualizaItensListView()
        {
            // Limpa o list view
            listView1.Items.Clear();

            // Percorre cada item adicionado dentro do listView
            foreach (Produto produto in lista_produtos)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            txtNome.Focus();
            btnAdicionar.Enabled = false;
            btnRemover.Enabled = false;

            foreach (ListViewItem outerItem in listView1.Items)
            {
                ListView innerListView1 = (ListView)outerItem.SubItems[1].Tag;
            }

            foreach (ListViewItem innerListView1 in lsvItens2.SelectedItems)
            {
                double price = double.Parse(innerListView1.SubItems[0].Text);
                totalPrice += price;
            }
            

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int id = int.Parse(item.Text);
                Produto produto = lista_produtos.Find(prod => prod.Id == id);
                lista_produtos.Remove(produto);
            }

            AtualizaItensListView();
            
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
            listView1.View = View.Details;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Nome");
            listView1.Columns.Add("Preço");           
            
            lsvItens2.View = View.Details;
            lsvItens2.Columns.Add("ID");
            lsvItens2.Columns.Add("Nome");
            lsvItens2.Columns.Add("Preço");           
        }

        private void lsvItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
