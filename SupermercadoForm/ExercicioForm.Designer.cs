namespace SupermercadoForm
{
    partial class ExercicioForm
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
            textBoxNomeAluno = new TextBox();
            labelNomeAluno = new Label();
            labelIdade = new Label();
            numericUpDown1 = new NumericUpDown();
            labelNota1 = new Label();
            textBoxNota1 = new TextBox();
            textBoxNota2 = new TextBox();
            labelNota2 = new Label();
            textBoxNota3 = new TextBox();
            labelNota3 = new Label();
            buttonClacularMedia = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(335, 32);
            label1.Name = "label1";
            label1.Size = new Size(222, 28);
            label1.TabIndex = 0;
            label1.Text = "Calculo de Media";
            // 
            // textBoxNomeAluno
            // 
            textBoxNomeAluno.Location = new Point(104, 135);
            textBoxNomeAluno.Name = "textBoxNomeAluno";
            textBoxNomeAluno.Size = new Size(100, 23);
            textBoxNomeAluno.TabIndex = 1;
            textBoxNomeAluno.TextChanged += textBoxNomeAluno_TextChanged;
            // 
            // labelNomeAluno
            // 
            labelNomeAluno.AutoSize = true;
            labelNomeAluno.Location = new Point(104, 102);
            labelNomeAluno.Name = "labelNomeAluno";
            labelNomeAluno.Size = new Size(92, 15);
            labelNomeAluno.TabIndex = 2;
            labelNomeAluno.Text = "Nome do Aluno";
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.Location = new Point(104, 203);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(88, 15);
            labelIdade.TabIndex = 3;
            labelIdade.Text = "Idade do Aluno";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(104, 248);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // labelNota1
            // 
            labelNota1.AutoSize = true;
            labelNota1.Location = new Point(368, 102);
            labelNota1.Name = "labelNota1";
            labelNota1.Size = new Size(94, 15);
            labelNota1.TabIndex = 5;
            labelNota1.Text = "Informe a nota 1";
            // 
            // textBoxNota1
            // 
            textBoxNota1.Location = new Point(368, 135);
            textBoxNota1.Name = "textBoxNota1";
            textBoxNota1.Size = new Size(100, 23);
            textBoxNota1.TabIndex = 3;
            // 
            // textBoxNota2
            // 
            textBoxNota2.Location = new Point(368, 230);
            textBoxNota2.Name = "textBoxNota2";
            textBoxNota2.Size = new Size(100, 23);
            textBoxNota2.TabIndex = 4;
            // 
            // labelNota2
            // 
            labelNota2.AutoSize = true;
            labelNota2.Location = new Point(368, 197);
            labelNota2.Name = "labelNota2";
            labelNota2.Size = new Size(94, 15);
            labelNota2.TabIndex = 7;
            labelNota2.Text = "Informe a nota 2";
            // 
            // textBoxNota3
            // 
            textBoxNota3.Location = new Point(368, 328);
            textBoxNota3.Name = "textBoxNota3";
            textBoxNota3.Size = new Size(100, 23);
            textBoxNota3.TabIndex = 5;
            // 
            // labelNota3
            // 
            labelNota3.AutoSize = true;
            labelNota3.Location = new Point(368, 295);
            labelNota3.Name = "labelNota3";
            labelNota3.Size = new Size(94, 15);
            labelNota3.TabIndex = 9;
            labelNota3.Text = "Informe a nota 3";
            // 
            // buttonClacularMedia
            // 
            buttonClacularMedia.Location = new Point(563, 135);
            buttonClacularMedia.Name = "buttonClacularMedia";
            buttonClacularMedia.Size = new Size(208, 194);
            buttonClacularMedia.TabIndex = 6;
            buttonClacularMedia.Text = "Calcula Media";
            buttonClacularMedia.UseVisualStyleBackColor = true;
            buttonClacularMedia.Click += buttonClacularMedia_Click;
            // 
            // ExercicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClacularMedia);
            Controls.Add(textBoxNota3);
            Controls.Add(labelNota3);
            Controls.Add(textBoxNota2);
            Controls.Add(labelNota2);
            Controls.Add(textBoxNota1);
            Controls.Add(labelNota1);
            Controls.Add(numericUpDown1);
            Controls.Add(labelIdade);
            Controls.Add(labelNomeAluno);
            Controls.Add(textBoxNomeAluno);
            Controls.Add(label1);
            Name = "ExercicioForm";
            Text = "ExercicioForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNomeAluno;
        private Label labelNomeAluno;
        private Label labelIdade;
        private NumericUpDown numericUpDown1;
        private Label labelNota1;
        private TextBox textBoxNota1;
        private TextBox textBoxNota2;
        private Label labelNota2;
        private TextBox textBoxNota3;
        private Label labelNota3;
        private Button buttonClacularMedia;
    }
}