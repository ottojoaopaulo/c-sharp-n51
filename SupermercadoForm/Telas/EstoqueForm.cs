namespace SupermercadoForm.Telas
{
    public partial class EstoqueForm : Form
    {
        public EstoqueForm()
        {
            InitializeComponent();
        }

        private void buttonExibirEstoque_Click(object sender, EventArgs e)
        {
            var form = new CadastroEstoqueForm();
            form.ShowDialog();
        }
    }
}
