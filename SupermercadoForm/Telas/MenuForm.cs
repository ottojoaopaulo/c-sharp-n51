namespace SupermercadoRepositorio.Telas
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            //instancia um objeto do form de estante
            CategoriaForm form = new CategoriaForm();
            //tornar um form visivel
            form.ShowDialog();
        }

        private void buttonEstantes_Click(object sender, EventArgs e)
        {
            //instancia um objeto do form de estante
            EstanteForm form = new EstanteForm();
            //tornar um form visivel
            form.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            var form = new ProdutoListaForm();
            form.ShowDialog();
        }
    }
}
