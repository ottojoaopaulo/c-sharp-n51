namespace SupermercadoForm.Telas
{
    partial class ProdutoCadastroForm
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
            labelNome = new Label();
            labelCategoria = new Label();
            labelPrecoUnitario = new Label();
            buttonSalvar = new Button();
            textBoxNome = new TextBox();
            textBoxPrecoUnitario = new TextBox();
            comboBoxCategorias = new ComboBox();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(29, 36);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(29, 114);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(58, 15);
            labelCategoria.TabIndex = 1;
            labelCategoria.Text = "Categoria";
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(29, 199);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(82, 15);
            labelPrecoUnitario.TabIndex = 2;
            labelPrecoUnitario.Text = "Preço Unitario";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(258, 278);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(96, 23);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(29, 67);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(325, 23);
            textBoxNome.TabIndex = 7;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(29, 241);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(325, 23);
            textBoxPrecoUnitario.TabIndex = 9;
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.DisplayMember = "Nome";
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(29, 149);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(325, 23);
            comboBoxCategorias.TabIndex = 10;
            comboBoxCategorias.ValueMember = "Nome";
            // 
            // ProdutoCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 335);
            Controls.Add(comboBoxCategorias);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(textBoxNome);
            Controls.Add(buttonSalvar);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelCategoria);
            Controls.Add(labelNome);
            Name = "ProdutoCadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProdutoCadastroForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelCategoria;
        private Label labelPrecoUnitario;
        private Button buttonSalvar;
        private TextBox textBoxNome;
        private TextBox textBoxPrecoUnitario;
        private ComboBox comboBoxCategorias;
    }
}