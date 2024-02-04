namespace SupermercadoForm.Telas
{
    partial class CadastroEstoqueForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxQuantidade = new TextBox();
            buttonCadastrarProduto = new Button();
            comboBoxProduto = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 40);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 151);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Quantidade";
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(38, 182);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(100, 23);
            textBoxQuantidade.TabIndex = 2;
            // 
            // buttonCadastrarProduto
            // 
            buttonCadastrarProduto.Location = new Point(38, 272);
            buttonCadastrarProduto.Name = "buttonCadastrarProduto";
            buttonCadastrarProduto.Size = new Size(215, 23);
            buttonCadastrarProduto.TabIndex = 4;
            buttonCadastrarProduto.Text = "Cadastrar Produto";
            buttonCadastrarProduto.UseVisualStyleBackColor = true;
            buttonCadastrarProduto.Click += buttonCadastrarProduto_Click;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(38, 86);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(310, 23);
            comboBoxProduto.TabIndex = 5;
            comboBoxProduto.ValueMember = "Nome";
            // 
            // CadastroEstoqueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 450);
            Controls.Add(comboBoxProduto);
            Controls.Add(buttonCadastrarProduto);
            Controls.Add(label2);
            Controls.Add(textBoxQuantidade);
            Controls.Add(label1);
            Name = "CadastroEstoqueForm";
            Text = "CadastroEstoqueForm";
            Load += CadastroEstoqueForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBoxQuantidade;
        private Button buttonCadastrarProduto;
        private ComboBox comboBoxProduto;
    }
}