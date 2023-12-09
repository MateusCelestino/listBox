﻿using System;
using System.Windows.Forms;

namespace listBox
{
    public partial class Form2 : Form
    {
        Listas lista;
        
        public Form2()
        {
            InitializeComponent();
            lista = new Listas();
            
            ConfiguraListView();
            AtualizaItensListView();
        }
        
        void AtualizaItensListView()
        {
            // Limpa o list view
            lsvProdutos.Items.Clear();
            lsvCestaMontada.Items.Clear();
            

            // Percorre cada item adicionado dentro do listView
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
            lsvProdutos.Items.Add(item);
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

            // foreach (ListViewItem outerItem in listView1.SelectedItems)
            // {
            //     int id = int.Parse(item.Text);
            //     Produto produto = lista.lista_produtos.Find(prod => prod.Id == id);
            //     
            //     lista.listView1.Add(produto);
            //     lista.lista_produtos.Remove(produto);
            //     CalcularCesta(produto);
            // }
            //
            // string CalcularCesta(Produto produto)
            // {
            //     decimal somaDosValores = 0;
            //     foreach (Produto item in lista.listView1)
            //     {
            //         somaDosValores += item.Preco;
            //     }
            //
            //     // Atualize o campo textValor com a soma dos valores dos produtos
            //     return this.CalcularCesta.Text = somaDosValores.ToString("c");
            // }
         

            
            // Pegar o item do lsvProdutos
            foreach (ListViewItem itemSelecionado in lsvProdutos.SelectedItems)
            {
                // Criar um novo item de Cesta
                var item = new ItemsCesta()
                {
                    Id = 1,
                    Produto = int.Parse(itemSelecionado.Text),
                    Quantidade = 1
                };
                
                var item = new lista_produtos()
                {
                    Id = 1,
                    Nome = 
                }
                string CalcularCesta(Produto produto)
                {
                    decimal somaDosValores = 0;
                    foreach (ListViewItem item2 in lsvCestaMontada.Items)
                    {
                        somaDosValores += decimal.Parse(item2.SubItems[3].Text);
                    }
                    // Atualize o campo textValor com a soma dos valores dos produtos
                    return this.CalcularCesta.Text = somaDosValores.ToString("c");
                }
                
                // Produto é o ID do produto. Você precisa buscar o nome e o valor.
                // Pode ser criando uma função.
                
                
                
                
                // Cria o item do listView
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Id.ToString();
                listViewItem.SubItems.Add(item.Produto.ToString());
                listViewItem.SubItems.Add(item.Quantidade.ToString());
                listViewItem.SubItems.Add(item.Preco)
                // Adicionar ao lsvCestaMontada
                lsvCestaMontada.Items.Add(listViewItem);
            }

            
            
            // Faz o calculo do valor

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvProdutos.SelectedItems)
            {
                int id = int.Parse(item.Text);
                Produto produto = lista.lista_produtos.Find(prod => prod.Id == id);
                lista.lista_produtos.Remove(produto);
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
        
        void ConfiguraListView()
        {
            lsvProdutos.View = View.Details;
            lsvProdutos.Columns.Add("ID");
            lsvProdutos.Columns.Add("Nome");
            lsvProdutos.Columns.Add("Preço");
            
            lsvCestaMontada.View = View.Details;
            lsvCestaMontada.Columns.Add("Item");
            lsvCestaMontada.Columns.Add("Produto");
            lsvCestaMontada.Columns.Add("Valor");
            lsvCestaMontada.Columns.Add("Quantidade");
            
        }

        private void lsvItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
