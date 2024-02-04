using SupermercadoForm.Repositorios;

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
            PreencherDataGridViewComProdutos();
        }

        private void PreencherDataGridViewComProdutos()
        {
            dataGridViewProdutos.Rows.Clear();

            var categoriaRepositorio = new ProdutoRepositorio();

            var produtos = categoriaRepositorio.ObterTodos();

            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];
                dataGridViewProdutos.Rows.Add(new object[]
                {
                    produto.Id,
                    produto.Nome,
                    produto.Categoria.Nome,
                    produto.PrecoUnitario
                });
            }
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
