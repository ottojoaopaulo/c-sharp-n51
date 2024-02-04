using SupermercadoForm.Repositorios;

namespace SupermercadoForm.Telas
{
    public partial class CadastroEstoqueForm : Form
    {
        public CadastroEstoqueForm()
        {
            InitializeComponent();
        }

        private void CadastroEstoqueForm_Load(object sender, EventArgs e)
        {
            DadosProduto();
        }

        private void DadosProduto()
        {
            var produtoRepositorio = new ProdutoRepositorio();

            var produtos = produtoRepositorio.ObterTodos();

            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];

                comboBoxProduto.Items.Add(produto);

            }

        }

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {

        }
    }
}
