using SupermercadoRepositorio.Repositorios;
using SupermercadoRepositorios.Entidades;

namespace SupermercadoRepositorio.Telas
{
    public partial class ProdutoCadastroForm : Form
    {
        public ProdutoCadastroForm()
        {
            InitializeComponent();
            PreencherDadosCategorias();
        }

        private void PreencherDadosCategorias()
        {
            var categoria = (Categoria)comboBoxCategorias.SelectedItem;

            var nome = textBoxNome.Text;

            var precoUnitario = Convert.ToDecimal(textBoxPrecoUnitario.Text);

            var repositorio = new ProdutoRepositorio();

            Produto produto;

            if (IdProdutoEditar == -1)
            {
                produto = new Produto()
                {
                    Nome = nome,
                    PrecoUnitario = precoUnitario,
                    Categoria = categoria
                };

                repositorio.Cadastrar(produto);
                MessageBox.Show("Produto cadastrado com sucesso");
                return;
            }

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var categoria = (Categoria)comboBoxCategorias.SelectedItem;

            var nome = textBoxNome.Text;
            var precoUnitario = Convert.ToDecimal(textBoxPrecoUnitario.Text);
            var idCategotia = 1;

            var repositorio = new ProdutoRepositorio();
            repositorio.Cadastrar(produto);
            MessageBox.Show("Produtocadastrado com sucesso");
        }

        private void PreencherDadosCategorias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
