namespace SupermercadoForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPrimeiraTela = new Label();
            buttonConcatenar = new Button();
            labelNome = new Label();
            labelSobrenome = new Label();
            textBoxNome = new TextBox();
            textBoxSobrenome = new TextBox();
            labelOperacao = new Label();
            comboBoxOperacao = new ComboBox();
            labelNumero2 = new Label();
            textBoxNumero2 = new TextBox();
            textBoxNumero1 = new TextBox();
            labelNumero1 = new Label();
            richTextBoxHistorico = new RichTextBox();
            buttonCalcular = new Button();
            buttonLimpar = new Button();
            labelHistorico = new Label();
            SuspendLayout();
            // 
            // labelPrimeiraTela
            // 
            labelPrimeiraTela.AutoSize = true;
            labelPrimeiraTela.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrimeiraTela.ForeColor = Color.Maroon;
            labelPrimeiraTela.Location = new Point(67, 37);
            labelPrimeiraTela.Name = "labelPrimeiraTela";
            labelPrimeiraTela.Size = new Size(120, 22);
            labelPrimeiraTela.TabIndex = 0;
            labelPrimeiraTela.Text = "Primeira Tela";
            // 
            // buttonConcatenar
            // 
            buttonConcatenar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonConcatenar.ForeColor = SystemColors.ActiveCaptionText;
            buttonConcatenar.Location = new Point(62, 318);
            buttonConcatenar.Name = "buttonConcatenar";
            buttonConcatenar.Size = new Size(125, 97);
            buttonConcatenar.TabIndex = 1;
            buttonConcatenar.Text = "Concatenar";
            buttonConcatenar.UseVisualStyleBackColor = true;
            buttonConcatenar.Click += buttonConcatenar_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNome.ForeColor = SystemColors.ActiveCaptionText;
            labelNome.Location = new Point(62, 101);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(53, 21);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // labelSobrenome
            // 
            labelSobrenome.AutoSize = true;
            labelSobrenome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSobrenome.ForeColor = SystemColors.ActiveCaptionText;
            labelSobrenome.Location = new Point(62, 183);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(91, 21);
            labelSobrenome.TabIndex = 3;
            labelSobrenome.Text = "Sobrenome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(62, 138);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 4;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Location = new Point(62, 225);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(100, 23);
            textBoxSobrenome.TabIndex = 5;
            // 
            // labelOperacao
            // 
            labelOperacao.AutoSize = true;
            labelOperacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOperacao.ForeColor = SystemColors.ActiveCaptionText;
            labelOperacao.Location = new Point(254, 106);
            labelOperacao.Name = "labelOperacao";
            labelOperacao.Size = new Size(77, 21);
            labelOperacao.TabIndex = 6;
            labelOperacao.Text = "Operacao";
            // 
            // comboBoxOperacao
            // 
            comboBoxOperacao.FormattingEnabled = true;
            comboBoxOperacao.Items.AddRange(new object[] { "Dividir", "Multiplicar", "Somar", "Subtrair" });
            comboBoxOperacao.Location = new Point(256, 138);
            comboBoxOperacao.Name = "comboBoxOperacao";
            comboBoxOperacao.Size = new Size(279, 23);
            comboBoxOperacao.TabIndex = 7;
            // 
            // labelNumero2
            // 
            labelNumero2.AutoSize = true;
            labelNumero2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumero2.ForeColor = SystemColors.ActiveCaptionText;
            labelNumero2.Location = new Point(435, 189);
            labelNumero2.Name = "labelNumero2";
            labelNumero2.Size = new Size(81, 21);
            labelNumero2.TabIndex = 8;
            labelNumero2.Text = "Numero 2";
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(435, 225);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(100, 23);
            textBoxNumero2.TabIndex = 9;
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(254, 225);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(100, 23);
            textBoxNumero1.TabIndex = 11;
            // 
            // labelNumero1
            // 
            labelNumero1.AutoSize = true;
            labelNumero1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumero1.ForeColor = SystemColors.ActiveCaptionText;
            labelNumero1.Location = new Point(254, 189);
            labelNumero1.Name = "labelNumero1";
            labelNumero1.Size = new Size(81, 21);
            labelNumero1.TabIndex = 10;
            labelNumero1.Text = "Numero 1";
            // 
            // richTextBoxHistorico
            // 
            richTextBoxHistorico.Location = new Point(254, 318);
            richTextBoxHistorico.Name = "richTextBoxHistorico";
            richTextBoxHistorico.Size = new Size(281, 96);
            richTextBoxHistorico.TabIndex = 14;
            richTextBoxHistorico.Text = "";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCalcular.ForeColor = SystemColors.ActiveCaptionText;
            buttonCalcular.Location = new Point(620, 138);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(131, 183);
            buttonCalcular.TabIndex = 15;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLimpar.ForeColor = SystemColors.ActiveCaptionText;
            buttonLimpar.Location = new Point(620, 352);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(131, 63);
            buttonLimpar.TabIndex = 16;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // labelHistorico
            // 
            labelHistorico.AutoSize = true;
            labelHistorico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHistorico.ForeColor = SystemColors.ActiveCaptionText;
            labelHistorico.Location = new Point(254, 281);
            labelHistorico.Name = "labelHistorico";
            labelHistorico.Size = new Size(72, 21);
            labelHistorico.TabIndex = 17;
            labelHistorico.Text = "Historico";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelHistorico);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonCalcular);
            Controls.Add(richTextBoxHistorico);
            Controls.Add(textBoxNumero1);
            Controls.Add(labelNumero1);
            Controls.Add(textBoxNumero2);
            Controls.Add(labelNumero2);
            Controls.Add(comboBoxOperacao);
            Controls.Add(labelOperacao);
            Controls.Add(textBoxSobrenome);
            Controls.Add(textBoxNome);
            Controls.Add(labelSobrenome);
            Controls.Add(labelNome);
            Controls.Add(buttonConcatenar);
            Controls.Add(labelPrimeiraTela);
            ForeColor = Color.Red;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrimeiraTela;
        private Button buttonConcatenar;
        private Label labelNome;
        private Label labelSobrenome;
        private TextBox textBoxNome;
        private TextBox textBoxSobrenome;
        private Label labelOperacao;
        private ComboBox comboBoxOperacao;
        private Label labelNumero2;
        private TextBox textBoxNumero2;
        private TextBox textBoxNumero1;
        private Label labelNumero1;
        private RichTextBox richTextBoxHistorico;
        private Button buttonCalcular;
        private Button buttonLimpar;
        private Label labelHistorico;
    }
}
