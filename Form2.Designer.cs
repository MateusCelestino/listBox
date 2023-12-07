namespace listBox
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnListaDeProdutos = new System.Windows.Forms.Button();
            this.btnCategoriasDeCesta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lsvItens2 = new System.Windows.Forms.ListView();
            this.lsvItens = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 47);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(169, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(374, 205);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(180, 77);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(61, 21);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(180, 107);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(61, 21);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnListaDeProdutos
            // 
            this.btnListaDeProdutos.Location = new System.Drawing.Point(163, 262);
            this.btnListaDeProdutos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListaDeProdutos.Name = "btnListaDeProdutos";
            this.btnListaDeProdutos.Size = new System.Drawing.Size(127, 23);
            this.btnListaDeProdutos.TabIndex = 12;
            this.btnListaDeProdutos.Text = "Lista de Produtos";
            this.btnListaDeProdutos.UseVisualStyleBackColor = true;
            this.btnListaDeProdutos.Click += new System.EventHandler(this.btnListaDeProdutos_Click);
            // 
            // btnCategoriasDeCesta
            // 
            this.btnCategoriasDeCesta.Location = new System.Drawing.Point(11, 262);
            this.btnCategoriasDeCesta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCategoriasDeCesta.Name = "btnCategoriasDeCesta";
            this.btnCategoriasDeCesta.Size = new System.Drawing.Size(131, 23);
            this.btnCategoriasDeCesta.TabIndex = 11;
            this.btnCategoriasDeCesta.Text = "Categorias de Cestas";
            this.btnCategoriasDeCesta.UseVisualStyleBackColor = true;
            this.btnCategoriasDeCesta.Click += new System.EventHandler(this.btnCategoriasDeCesta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lista de Produtos";
            // 
            // lsvItens2
            // 
            this.lsvItens2.HideSelection = false;
            this.lsvItens2.Location = new System.Drawing.Point(246, 31);
            this.lsvItens2.Name = "lsvItens2";
            this.lsvItens2.Size = new System.Drawing.Size(208, 169);
            this.lsvItens2.TabIndex = 15;
            this.lsvItens2.UseCompatibleStateImageBehavior = false;
            // 
            // lsvItens
            // 
            this.lsvItens.FormattingEnabled = true;
            this.lsvItens.Location = new System.Drawing.Point(8, 72);
            this.lsvItens.Name = "lsvItens";
            this.lsvItens.Size = new System.Drawing.Size(167, 160);
            this.lsvItens.TabIndex = 14;
            this.lsvItens.SelectedIndexChanged += new System.EventHandler(this.lsvItens_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 292);
            this.Controls.Add(this.lsvItens2);
            this.Controls.Add(this.lsvItens);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListaDeProdutos);
            this.Controls.Add(this.btnCategoriasDeCesta);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Gestas da Prima";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnListaDeProdutos;
        private System.Windows.Forms.Button btnCategoriasDeCesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lsvItens2;
        private System.Windows.Forms.ListBox lsvItens;
    }
}