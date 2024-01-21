namespace SupermercadoForm
{
    partial class ExercicioEstantes
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
            labelProduto = new Label();
            textBoxCadastrar = new TextBox();
            buttonCadastrar = new Button();
            label1 = new Label();
            richTextExibir = new RichTextBox();
            labelAlterar = new Label();
            comboBoxAlterar = new ComboBox();
            buttonAlterar = new Button();
            textBoxAlterar = new TextBox();
            label2 = new Label();
            buttonExcluir = new Button();
            textBoxExcluir = new TextBox();
            buttonExibir = new Button();
            SuspendLayout();
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(41, 46);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(50, 15);
            labelProduto.TabIndex = 0;
            labelProduto.Text = "Produto";
            // 
            // textBoxCadastrar
            // 
            textBoxCadastrar.Location = new Point(201, 38);
            textBoxCadastrar.Name = "textBoxCadastrar";
            textBoxCadastrar.Size = new Size(394, 23);
            textBoxCadastrar.TabIndex = 1;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(623, 38);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(117, 23);
            buttonCadastrar.TabIndex = 2;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 99);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 3;
            label1.Text = "Lista dos Produtos";
            // 
            // richTextExibir
            // 
            richTextExibir.Location = new Point(201, 99);
            richTextExibir.Name = "richTextExibir";
            richTextExibir.Size = new Size(394, 149);
            richTextExibir.TabIndex = 4;
            richTextExibir.Text = "";

            // 
            // labelAlterar
            // 
            labelAlterar.AutoSize = true;
            labelAlterar.Location = new Point(41, 280);
            labelAlterar.Name = "labelAlterar";
            labelAlterar.Size = new Size(136, 15);
            labelAlterar.TabIndex = 5;
            labelAlterar.Text = "Alterar Lista de Produtos";
            // 
            // comboBoxAlterar
            // 
            comboBoxAlterar.FormattingEnabled = true;
            comboBoxAlterar.Location = new Point(201, 272);
            comboBoxAlterar.Name = "comboBoxAlterar";
            comboBoxAlterar.Size = new Size(49, 23);
            comboBoxAlterar.TabIndex = 6;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(623, 272);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(117, 23);
            buttonAlterar.TabIndex = 7;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // textBoxAlterar
            // 
            textBoxAlterar.Location = new Point(283, 272);
            textBoxAlterar.Name = "textBoxAlterar";
            textBoxAlterar.Size = new Size(312, 23);
            textBoxAlterar.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 367);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 10;
            label2.Text = "Excluir Item";
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(623, 363);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(117, 23);
            buttonExcluir.TabIndex = 11;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // textBoxExcluir
            // 
            textBoxExcluir.Location = new Point(201, 363);
            textBoxExcluir.Name = "textBoxExcluir";
            textBoxExcluir.Size = new Size(394, 23);
            textBoxExcluir.TabIndex = 12;
            // 
            // buttonExibir
            // 
            buttonExibir.Location = new Point(623, 99);
            buttonExibir.Name = "buttonExibir";
            buttonExibir.Size = new Size(117, 149);
            buttonExibir.TabIndex = 13;
            buttonExibir.Text = "Exibir";
            buttonExibir.UseVisualStyleBackColor = true;
            buttonExibir.Click += buttonExibir_Click;
            // 
            // ExercicioEstantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExibir);
            Controls.Add(textBoxExcluir);
            Controls.Add(buttonExcluir);
            Controls.Add(label2);
            Controls.Add(textBoxAlterar);
            Controls.Add(buttonAlterar);
            Controls.Add(comboBoxAlterar);
            Controls.Add(labelAlterar);
            Controls.Add(richTextExibir);
            Controls.Add(label1);
            Controls.Add(buttonCadastrar);
            Controls.Add(textBoxCadastrar);
            Controls.Add(labelProduto);
            Name = "ExercicioEstantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExercicioEstantes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProduto;
        private TextBox textBoxCadastrar;
        private Button buttonCadastrar;
        private Label label1;
        private RichTextBox richTextExibir;
        private Label labelAlterar;
        private ComboBox comboBoxAlterar;
        private Button buttonAlterar;
        private TextBox textBoxAlterar;
        private Label label2;
        private Button buttonExcluir;
        private TextBox textBoxExcluir;
        private Button buttonExibir;
    }
}