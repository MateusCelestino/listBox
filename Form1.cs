﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox
{
    public partial class Form1 : Form
    {
        Listas lista;

        public Form1()
        {
            InitializeComponent();
            lista = new Listas();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //foreach (Produto prod in lista.lista_produtos)
            //{

            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCategoriasDeCesta_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lista_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Executa quando o formulário carrega
            ConfiguraListView();
        }

        void ConfiguraListView()
        {
            lsvItens.View = View.Details;
            lsvItens.Columns.Add("ID");
            lsvItens.Columns.Add("Nome");
            lsvItens.Columns.Add("Preço");
        }

        private void btnListaDeProdutos_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void btnCesta_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
