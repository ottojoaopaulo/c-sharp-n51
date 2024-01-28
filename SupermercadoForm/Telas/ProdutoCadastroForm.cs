using SupermercadoForm.Repositorios;
using System;
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
    public partial class ProdutoCadastroForm : Form
    {
        public ProdutoCadastroForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var precoUnitario = Convert.ToDecimal(textBoxPrecoUnitario.Text);
            var idCategotia = 1;

            var repositorio = new ProdutoRepositorio();
            repositorio.Cadastrar(nome, idCategotia, precoUnitario);
            MessageBox.Show("Produtocadastrado com sucesso");
        }
    }
}
