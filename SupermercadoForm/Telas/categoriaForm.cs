using SupermercadoForm.Entidades;
using SupermercadoForm.Repositorios;

namespace SupermercadoForm.Telas
{
    public partial class CategoriaForm : Form
    {
        private CategoriaRepositorio repositorio;

        public CategoriaForm()
        {
            InitializeComponent();
            repositorio = new CategoriaRepositorio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CRUD
            //Create => INSERT
            CriarCategoria();
            //Read => SELECT
            //Update
            //Delete
        }

        private void CriarCategoria()
        {
            string nomeCategoria = textBoxNome.Text;

            if (nomeCategoria.Length < 3)
            {
                MessageBox.Show("o nome da categoria deve conter no minimo 3 caracteres");
                return;
            }

            var categoria = new Categoria();
            categoria.Nome = nomeCategoria;

            repositorio.Cadastrar(categoria);

            //limpa o nome da categoria
            textBoxNome.Clear();

            //Mensagem para o susario
            MessageBox.Show("Categoria criada com sucesso");

            ListarCategorias();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            //READ => SELECT
            ListarCategorias();
        }

        private void ListarCategorias()
        {
            //limpar campo que contem as categorias
            richTextBoxCategorias.Clear();

            var categorias = repositorio.ObterTodos();

            for (int i = 0; i < categorias.Count; i++)
            {
                var categoria = categorias[i];

                richTextBoxCategorias.AppendText("Cod: " + categoria.Id + "=>" + categoria.Nome + "\n");
            }
        }

        private void richTextBoxCategorias_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            ApagarCategoria();
        }

        private void ApagarCategoria()
        {
            //obter o codigo que o usuario informou que deseja apagar
            int codigoInformado = Convert.ToInt32(textBoxCodigoApagar.Text);

            repositorio.Apagar(codigoInformado);

            //if (quantidadeRegistrosApagados == 0)
            //{
            //    MessageBox.Show("Não existe categoria com o codigo " + codigoInformado);
            //    textBoxCodigoApagar.Focus();
            //    return;
            //}

            //limpar campo do codigo para apagar
            textBoxCodigoApagar.Clear();

            MessageBox.Show("Registro apagado com sucesso");

            ListarCategorias();
        }

        private void categoriaForm_Load(object sender, EventArgs e)
        {
            //preencher a lista decategorias com os registros de tabelas de categorias
            ListarCategorias();

            //coloca o cursos piscando no campo do nome para cadastro
            textBoxNome.Focus();
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxNome_KeyDown(object sender, KeyEventArgs e)
        {
            //verifica se a tecla utilizada e enter
            if (e.KeyCode == Keys.Enter)
            {
                CriarCategoria();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            AlterarCategoria();
        }

        private void AlterarCategoria()
        {
            int codigoParaAlterar = Convert.ToInt32(textBoxCodigoParaAlterar.Text);
            string nome = textBoxNomeParaAlterar.Text;

            var categoria = new Categoria();
            categoria.Id = codigoParaAlterar;
            categoria.Nome = nome;

            repositorio.Atualizar(categoria);


            //if( quantidadeAlterada == 0 )
            //{
            //    MessageBox.Show("não existe categoria com o codigo " + codigoParaAlterar);
            //    textBoxCodigoApagar.Focus();
            //    return;
            //}

            textBoxCodigoParaAlterar.Clear();
            textBoxNomeParaAlterar.Clear();

            MessageBox.Show("Categoria atualizada com sucesso");

            ListarCategorias();
        }
    }
}
