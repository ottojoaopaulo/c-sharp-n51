namespace SupermercadoForm.Telas
{
    partial class EstanteForm
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
            labelSigla = new Label();
            buttonSalvar = new Button();
            maskedTextBoxSigla = new MaskedTextBox();
            textBoxNome = new TextBox();
            dataGridViewEstantes = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnSigla = new DataGridViewTextBoxColumn();
            labeEstantes = new Label();
            buttonEditar = new Button();
            buttonApagar = new Button();
            label1 = new Label();
            textBoxPesquisar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstantes).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(26, 52);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // labelSigla
            // 
            labelSigla.AutoSize = true;
            labelSigla.Location = new Point(26, 120);
            labelSigla.Name = "labelSigla";
            labelSigla.Size = new Size(32, 15);
            labelSigla.TabIndex = 2;
            labelSigla.Text = "Sigla";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(124, 203);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 3;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // maskedTextBoxSigla
            // 
            maskedTextBoxSigla.Location = new Point(26, 148);
            maskedTextBoxSigla.Mask = "AAA";
            maskedTextBoxSigla.Name = "maskedTextBoxSigla";
            maskedTextBoxSigla.Size = new Size(173, 23);
            maskedTextBoxSigla.TabIndex = 2;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(26, 77);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(173, 23);
            textBoxNome.TabIndex = 1;
            // 
            // dataGridViewEstantes
            // 
            dataGridViewEstantes.AllowUserToAddRows = false;
            dataGridViewEstantes.AllowUserToDeleteRows = false;
            dataGridViewEstantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstantes.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnSigla });
            dataGridViewEstantes.Location = new Point(221, 58);
            dataGridViewEstantes.Name = "dataGridViewEstantes";
            dataGridViewEstantes.ReadOnly = true;
            dataGridViewEstantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEstantes.Size = new Size(475, 369);
            dataGridViewEstantes.TabIndex = 6;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Código";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            ColumnNome.Width = 230;
            // 
            // ColumnSigla
            // 
            ColumnSigla.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnSigla.HeaderText = "Sigla";
            ColumnSigla.Name = "ColumnSigla";
            ColumnSigla.ReadOnly = true;
            // 
            // labeEstantes
            // 
            labeEstantes.AutoSize = true;
            labeEstantes.Location = new Point(221, 37);
            labeEstantes.Name = "labeEstantes";
            labeEstantes.Size = new Size(50, 15);
            labeEstantes.TabIndex = 7;
            labeEstantes.Text = "Estantes";
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(713, 120);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 5;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(713, 76);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(75, 23);
            buttonApagar.TabIndex = 4;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 37);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 10;
            label1.Text = "Pesquisa";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(545, 29);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(151, 23);
            textBoxPesquisar.TabIndex = 11;
            textBoxPesquisar.KeyDown += textBoxPesquisar_KeyDown;
            // 
            // EstanteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPesquisar);
            Controls.Add(label1);
            Controls.Add(buttonApagar);
            Controls.Add(buttonEditar);
            Controls.Add(labeEstantes);
            Controls.Add(dataGridViewEstantes);
            Controls.Add(textBoxNome);
            Controls.Add(maskedTextBoxSigla);
            Controls.Add(buttonSalvar);
            Controls.Add(labelSigla);
            Controls.Add(labelNome);
            Name = "EstanteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estantes";
            Load += EstanteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNome;
        private Label labelSigla;
        private Button buttonSalvar;
        private MaskedTextBox maskedTextBoxSigla;
        private TextBox textBoxNome;
        private DataGridView dataGridViewEstantes;
        private Label labeEstantes;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label label1;
        private TextBox textBoxPesquisar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnSigla;
    }
}