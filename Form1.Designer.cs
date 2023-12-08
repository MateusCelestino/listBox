namespace listBox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCategoriasDeCesta = new System.Windows.Forms.Button();
            this.btnListaDeProdutos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lsvItens = new System.Windows.Forms.ListView();
            this.btnCesta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Desceração";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total R$";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(299, 217);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // btnCategoriasDeCesta
            // 
            this.btnCategoriasDeCesta.Location = new System.Drawing.Point(11, 262);
            this.btnCategoriasDeCesta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategoriasDeCesta.Name = "btnCategoriasDeCesta";
            this.btnCategoriasDeCesta.Size = new System.Drawing.Size(131, 23);
            this.btnCategoriasDeCesta.TabIndex = 7;
            this.btnCategoriasDeCesta.Text = "Categorias de Cestas";
            this.btnCategoriasDeCesta.UseVisualStyleBackColor = true;
            this.btnCategoriasDeCesta.Click += new System.EventHandler(this.btnCategoriasDeCesta_Click);
            // 
            // btnListaDeProdutos
            // 
            this.btnListaDeProdutos.Location = new System.Drawing.Point(164, 262);
            this.btnListaDeProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaDeProdutos.Name = "btnListaDeProdutos";
            this.btnListaDeProdutos.Size = new System.Drawing.Size(127, 23);
            this.btnListaDeProdutos.TabIndex = 8;
            this.btnListaDeProdutos.Text = "Lista de Produtos";
            this.btnListaDeProdutos.UseVisualStyleBackColor = true;
            this.btnListaDeProdutos.Click += new System.EventHandler(this.btnListaDeProdutos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton7);
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(11, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 152);
            this.panel2.TabIndex = 5;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 109);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(118, 17);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Dia dos Namorados";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 89);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(78, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Casamento";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 70);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(86, 17);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Dia dos pais.";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 50);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(89, 17);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Dia das mães";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 31);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Páscoa";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 11);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Aniversários";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lsvItens
            // 
            this.lsvItens.HideSelection = false;
            this.lsvItens.Location = new System.Drawing.Point(203, 50);
            this.lsvItens.Margin = new System.Windows.Forms.Padding(2);
            this.lsvItens.Name = "lsvItens";
            this.lsvItens.Size = new System.Drawing.Size(170, 154);
            this.lsvItens.TabIndex = 6;
            this.lsvItens.UseCompatibleStateImageBehavior = false;
            this.lsvItens.SelectedIndexChanged += new System.EventHandler(this.Lista_produtos_SelectedIndexChanged);
            // 
            // btnCesta
            // 
            this.btnCesta.Location = new System.Drawing.Point(12, 217);
            this.btnCesta.Name = "btnCesta";
            this.btnCesta.Size = new System.Drawing.Size(130, 20);
            this.btnCesta.TabIndex = 9;
            this.btnCesta.Text = "Cria Cesta";
            this.btnCesta.UseVisualStyleBackColor = true;
            this.btnCesta.Click += new System.EventHandler(this.btnCesta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 292);
            this.Controls.Add(this.btnCesta);
            this.Controls.Add(this.lsvItens);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnListaDeProdutos);
            this.Controls.Add(this.btnCategoriasDeCesta);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Cestas da Prima";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCesta;

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCategoriasDeCesta;
        private System.Windows.Forms.Button btnListaDeProdutos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.ListView lsvItens;
    }
}

