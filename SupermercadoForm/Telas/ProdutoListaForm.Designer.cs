namespace SupermercadoForm.Telas
{
    partial class ProdutoListaForm
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
            dataGridViewProdutos = new DataGridView();
            buttonEditar = new Button();
            buttonApagar = new Button();
            labelQuantidadetotal = new Label();
            labelQuantidadeTotalValor = new Label();
            labelExibir = new Label();
            labelQuantidade = new Label();
            labelPesquisa = new Label();
            buttonPesquisar = new Button();
            buttonLimparFiltros = new Button();
            comboBoxQuantidade = new ComboBox();
            comboBoxExibir = new ComboBox();
            comboBoxPesquisar = new ComboBox();
            buttonNovo = new Button();
            comboBoxOrdenar = new ComboBox();
            labelOrdenar = new Label();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCategoria = new DataGridViewTextBoxColumn();
            ColumnPrecoUnitario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AllowUserToAddRows = false;
            dataGridViewProdutos.AllowUserToDeleteRows = false;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnCategoria, ColumnPrecoUnitario });
            dataGridViewProdutos.Location = new Point(24, 119);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.ReadOnly = true;
            dataGridViewProdutos.Size = new Size(624, 296);
            dataGridViewProdutos.TabIndex = 0;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = SystemColors.ButtonFace;
            buttonEditar.Location = new Point(667, 119);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(667, 161);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(75, 23);
            buttonApagar.TabIndex = 3;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            // 
            // labelQuantidadetotal
            // 
            labelQuantidadetotal.AutoSize = true;
            labelQuantidadetotal.Location = new Point(415, 418);
            labelQuantidadetotal.Name = "labelQuantidadetotal";
            labelQuantidadetotal.Size = new Size(164, 15);
            labelQuantidadetotal.TabIndex = 4;
            labelQuantidadetotal.Text = "Quantidade Total de Produtos";
            // 
            // labelQuantidadeTotalValor
            // 
            labelQuantidadeTotalValor.AutoSize = true;
            labelQuantidadeTotalValor.Location = new Point(610, 418);
            labelQuantidadeTotalValor.Name = "labelQuantidadeTotalValor";
            labelQuantidadeTotalValor.Size = new Size(32, 15);
            labelQuantidadeTotalValor.TabIndex = 5;
            labelQuantidadeTotalValor.Text = "Total";
            // 
            // labelExibir
            // 
            labelExibir.AutoSize = true;
            labelExibir.Location = new Point(151, 17);
            labelExibir.Name = "labelExibir";
            labelExibir.Size = new Size(36, 15);
            labelExibir.TabIndex = 7;
            labelExibir.Text = "Exibir";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(24, 17);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 8;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(415, 20);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(57, 15);
            labelPesquisa.TabIndex = 9;
            labelPesquisa.Text = "Pesquisar";
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(573, 90);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(75, 23);
            buttonPesquisar.TabIndex = 11;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // buttonLimparFiltros
            // 
            buttonLimparFiltros.Location = new Point(442, 90);
            buttonLimparFiltros.Name = "buttonLimparFiltros";
            buttonLimparFiltros.Size = new Size(103, 23);
            buttonLimparFiltros.TabIndex = 10;
            buttonLimparFiltros.Text = "Limpar Filtros";
            buttonLimparFiltros.UseVisualStyleBackColor = true;
            // 
            // comboBoxQuantidade
            // 
            comboBoxQuantidade.FormattingEnabled = true;
            comboBoxQuantidade.Items.AddRange(new object[] { "10 Itens ", "25 Itens", "50 Itens", "100 Itens" });
            comboBoxQuantidade.Location = new Point(24, 38);
            comboBoxQuantidade.Name = "comboBoxQuantidade";
            comboBoxQuantidade.Size = new Size(121, 23);
            comboBoxQuantidade.TabIndex = 12;
            // 
            // comboBoxExibir
            // 
            comboBoxExibir.FormattingEnabled = true;
            comboBoxExibir.Items.AddRange(new object[] { "Código", "Nome", "Categortia", "Preço Unitario" });
            comboBoxExibir.Location = new Point(151, 38);
            comboBoxExibir.Name = "comboBoxExibir";
            comboBoxExibir.Size = new Size(121, 23);
            comboBoxExibir.TabIndex = 13;
            // 
            // comboBoxPesquisar
            // 
            comboBoxPesquisar.FormattingEnabled = true;
            comboBoxPesquisar.Location = new Point(415, 38);
            comboBoxPesquisar.Name = "comboBoxPesquisar";
            comboBoxPesquisar.Size = new Size(233, 23);
            comboBoxPesquisar.TabIndex = 14;
            // 
            // buttonNovo
            // 
            buttonNovo.Location = new Point(667, 12);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(75, 91);
            buttonNovo.TabIndex = 15;
            buttonNovo.Text = "Novo";
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // comboBoxOrdenar
            // 
            comboBoxOrdenar.FormattingEnabled = true;
            comboBoxOrdenar.Items.AddRange(new object[] { "A-Z", "Z-A" });
            comboBoxOrdenar.Location = new Point(278, 38);
            comboBoxOrdenar.Name = "comboBoxOrdenar";
            comboBoxOrdenar.Size = new Size(121, 23);
            comboBoxOrdenar.TabIndex = 17;
            // 
            // labelOrdenar
            // 
            labelOrdenar.AutoSize = true;
            labelOrdenar.Location = new Point(278, 17);
            labelOrdenar.Name = "labelOrdenar";
            labelOrdenar.Size = new Size(50, 15);
            labelOrdenar.TabIndex = 16;
            labelOrdenar.Text = "Ordenar";
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Codigo";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            // 
            // ColumnPrecoUnitario
            // 
            ColumnPrecoUnitario.HeaderText = "Preco Unitario";
            ColumnPrecoUnitario.Name = "ColumnPrecoUnitario";
            ColumnPrecoUnitario.ReadOnly = true;
            // 
            // ProdutoListaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 450);
            Controls.Add(comboBoxOrdenar);
            Controls.Add(labelOrdenar);
            Controls.Add(buttonNovo);
            Controls.Add(comboBoxPesquisar);
            Controls.Add(comboBoxExibir);
            Controls.Add(comboBoxQuantidade);
            Controls.Add(buttonPesquisar);
            Controls.Add(buttonLimparFiltros);
            Controls.Add(labelPesquisa);
            Controls.Add(labelQuantidade);
            Controls.Add(labelExibir);
            Controls.Add(labelQuantidadeTotalValor);
            Controls.Add(labelQuantidadetotal);
            Controls.Add(buttonApagar);
            Controls.Add(buttonEditar);
            Controls.Add(dataGridViewProdutos);
            Name = "ProdutoListaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Produtos";
            Load += ProdutoListaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProdutos;
        private Button buttonEditar;
        private Button buttonApagar;
        private Button button3;
        private Label labelOrdenar;
        private Label labelPesquisa;
        private Label labelExibir;
        private Label labelQuantidade;
        private Label labelQuantidadetotal;
        private Label labelQuantidadeTotalValor;
        private Button buttonPesquisar;
        private Button buttonLimparFiltros;
        private ComboBox comboBoxQuantidade;
        private ComboBox comboBoxExibir;
        private ComboBox comboBoxPesquisar;
        private Button buttonNovo;
        private ComboBox comboBoxOrdenar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnPrecoUnitario;
    }
}