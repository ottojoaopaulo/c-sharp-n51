namespace SupermercadoForm.Telas
{
    partial class EstoqueForm
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
            dataGridView1 = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            PrecoUnitario = new DataGridViewTextBoxColumn();
            buttonExibirEstoque = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Produto, PrecoUnitario });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(553, 356);
            dataGridView1.TabIndex = 0;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            // 
            // PrecoUnitario
            // 
            PrecoUnitario.HeaderText = "Preco Unitario";
            PrecoUnitario.Name = "PrecoUnitario";
            // 
            // buttonExibirEstoque
            // 
            buttonExibirEstoque.Location = new Point(614, 48);
            buttonExibirEstoque.Name = "buttonExibirEstoque";
            buttonExibirEstoque.Size = new Size(143, 50);
            buttonExibirEstoque.TabIndex = 1;
            buttonExibirEstoque.Text = "Exibir Estoque";
            buttonExibirEstoque.UseVisualStyleBackColor = true;
            buttonExibirEstoque.Click += buttonExibirEstoque_Click;
            // 
            // EstoqueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExibirEstoque);
            Controls.Add(dataGridView1);
            Name = "EstoqueForm";
            Text = "EstoqueForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn PrecoUnitario;
        private Button buttonExibirEstoque;
    }
}