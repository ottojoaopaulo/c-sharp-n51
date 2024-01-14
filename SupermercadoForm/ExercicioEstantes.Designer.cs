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
            richTextBox1 = new RichTextBox();
            labelAlterar = new Label();
            comboBox1 = new ComboBox();
            buttonAlterar = new Button();
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(201, 99);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(394, 149);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(201, 272);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(394, 23);
            comboBox1.TabIndex = 6;
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
            // ExercicioEstantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAlterar);
            Controls.Add(comboBox1);
            Controls.Add(labelAlterar);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(buttonCadastrar);
            Controls.Add(textBoxCadastrar);
            Controls.Add(labelProduto);
            Name = "ExercicioEstantes";
            Text = "ExercicioEstantes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProduto;
        private TextBox textBoxCadastrar;
        private Button buttonCadastrar;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label labelAlterar;
        private ComboBox comboBox1;
        private Button buttonAlterar;
    }
}