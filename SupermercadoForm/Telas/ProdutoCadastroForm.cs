using SupermercadoForm.Entidades;
using SupermercadoForm.Repositorios;

namespace SupermercadoForm.Telas
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
            var categoriaRepositorio = new CategoriaRepositorio();

            var categorias = categoriaRepositorio.ObterTodos();

            for (int i = 0; i < categorias.Count; i++)
            {
                var categoria = categorias[i];

                comboBoxCategorias.Items.Add(categoria);
            }

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            var categoria = (Categoria)comboBoxCategorias.SelectedItem;

            var nome = textBoxNome.Text;
            var precoUnitario = Convert.ToDecimal(textBoxPrecoUnitario.Text);
            var idCategotia = 1;

            var repositorio = new ProdutoRepositorio();
            repositorio.Cadastrar(nome, idCategotia, precoUnitario);
            MessageBox.Show("Produtocadastrado com sucesso");
        }

        private void PreencherDadosCategorias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
