﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermercadoForm.Telas
{
    public partial class ProdutoListaForm : Form
    {
        public ProdutoListaForm()
        {
            InitializeComponent();
        }

        private void ProdutoListaForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            //direciona a pagina solicitada
            var formCadastro = new ProdutoCadastroForm();
            //muda o texto da pagina aberta
            formCadastro.Text = "Cadastro do Produto";
            formCadastro.ShowDialog();
        }
    }
}
