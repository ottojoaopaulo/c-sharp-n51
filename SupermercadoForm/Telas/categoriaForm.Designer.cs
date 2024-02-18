namespace SupermercadoForm.Telas
{
    partial class CategoriaForm
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
            buttonCadastrar = new Button();
            labelNome = new Label();
            textBoxNome = new TextBox();
            buttonListar = new Button();
            richTextBoxCategorias = new RichTextBox();
            buttonApagar = new Button();
            label1 = new Label();
            textBoxCodigoApagar = new TextBox();
            labelCodigoParaAlterar = new Label();
            textBoxCodigoParaAlterar = new TextBox();
            label3 = new Label();
            buttonAlterar = new Button();
            textBoxNomeParaAlterar = new TextBox();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(571, 25);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(191, 23);
            buttonCadastrar.TabIndex = 2;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += button1_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(65, 29);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(155, 21);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(395, 23);
            textBoxNome.TabIndex = 1;
            textBoxNome.KeyDown += textBoxNome_KeyDown;
            textBoxNome.KeyPress += textBoxNome_KeyPress;
            // 
            // buttonListar
            // 
            buttonListar.Location = new Point(571, 93);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(191, 23);
            buttonListar.TabIndex = 3;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // richTextBoxCategorias
            // 
            richTextBoxCategorias.Location = new Point(56, 93);
            richTextBoxCategorias.Name = "richTextBoxCategorias";
            richTextBoxCategorias.ReadOnly = true;
            richTextBoxCategorias.Size = new Size(494, 161);
            richTextBoxCategorias.TabIndex = 4;
            richTextBoxCategorias.TabStop = false;
            richTextBoxCategorias.Text = "";
            richTextBoxCategorias.TextChanged += richTextBoxCategorias_TextChanged;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(571, 231);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(191, 23);
            buttonApagar.TabIndex = 5;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 288);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 6;
            label1.Text = "Codigo";
            // 
            // textBoxCodigoApagar
            // 
            textBoxCodigoApagar.Location = new Point(108, 280);
            textBoxCodigoApagar.Name = "textBoxCodigoApagar";
            textBoxCodigoApagar.Size = new Size(429, 23);
            textBoxCodigoApagar.TabIndex = 4;
            // 
            // labelCodigoParaAlterar
            // 
            labelCodigoParaAlterar.AutoSize = true;
            labelCodigoParaAlterar.Location = new Point(36, 355);
            labelCodigoParaAlterar.Name = "labelCodigoParaAlterar";
            labelCodigoParaAlterar.Size = new Size(46, 15);
            labelCodigoParaAlterar.TabIndex = 8;
            labelCodigoParaAlterar.Text = "Codigo";
            // 
            // textBoxCodigoParaAlterar
            // 
            textBoxCodigoParaAlterar.Location = new Point(121, 348);
            textBoxCodigoParaAlterar.Name = "textBoxCodigoParaAlterar";
            textBoxCodigoParaAlterar.Size = new Size(135, 23);
            textBoxCodigoParaAlterar.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 348);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 10;
            label3.Text = "Nome";
            label3.Click += label3_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(571, 348);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(191, 23);
            buttonAlterar.TabIndex = 8;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // textBoxNomeParaAlterar
            // 
            textBoxNomeParaAlterar.Location = new Point(360, 352);
            textBoxNomeParaAlterar.Name = "textBoxNomeParaAlterar";
            textBoxNomeParaAlterar.Size = new Size(190, 23);
            textBoxNomeParaAlterar.TabIndex = 7;
            // 
            // categoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxNomeParaAlterar);
            Controls.Add(buttonAlterar);
            Controls.Add(label3);
            Controls.Add(textBoxCodigoParaAlterar);
            Controls.Add(labelCodigoParaAlterar);
            Controls.Add(textBoxCodigoApagar);
            Controls.Add(label1);
            Controls.Add(buttonApagar);
            Controls.Add(richTextBoxCategorias);
            Controls.Add(buttonListar);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(buttonCadastrar);
            Name = "categoriaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            Load += categoriaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCadastrar;
        private Label labelNome;
        private TextBox textBoxNome;
        private Button buttonListar;
        private RichTextBox richTextBoxCategorias;
        private Button buttonApagar;
        private Label label1;
        private TextBox textBoxCodigoApagar;
        private Label labelCodigoParaAlterar;
        private TextBox textBoxCodigoParaAlterar;
        private Label label3;
        private Button buttonAlterar;
        private TextBox textBoxNomeParaAlterar;
    }
}