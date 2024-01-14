using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupermercadoForm
{
    public partial class categoriaForm : Form
    {
        public categoriaForm()
        {
            InitializeComponent();
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
            string nomeCatgoria = textBoxNome.Text;

            if (nomeCatgoria.Length < 3)
            {
                MessageBox.Show("o nome da categoria deve conter no minimo 3 caracteres");
                return;
            }

            //Instancia um objeto
            SqlConnection conexao = new SqlConnection();

            //Definido o caminho onde encontra-se o banco de dados
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\74639\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";

            //Abre a conexao com banco de dados
            conexao.Open();

            //criado um objeto para executar o comando do INSERT da tabela de categorias
            SqlCommand comando = conexao.CreateCommand();



            //Informa o comando que sera executado, ou seja INSERT
            comando.CommandText = "INSERT INTO categorias (nome) VALUES ('" + nomeCatgoria + "')";

            //Executar INSERT na tabela categorias
            comando.ExecuteNonQuery();

            //limpa o nome da categoria
            textBoxNome.Clear();

            //Mensagem para o susario
            MessageBox.Show("Categoria criada com sucesso");

            listarCategorias();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            //READ => SELECT
            listarCategorias();
        }
        private void listarCategorias()
        {
            //instanciar um objeto para abrir uma conexão ccmo banco de dados
            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\74639\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";

            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome FROM categorias";

            DataTable tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            //limpar campo que contem as categorias
            richTextBoxCategorias.Clear();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                DataRow registro = tabelaEmMemoria.Rows[i];
                int id = Convert.ToInt32(registro["id"]);
                string nome = registro["nome"].ToString();

                richTextBoxCategorias.AppendText("Cod: " + id + " => " + nome + "\n");
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
            //obter o codigo que o usuario informou que sejeja apagar
            int codigoInformado = Convert.ToInt32(textBoxCodigoApagar.Text);

            //instanciar um objeto para abrir a conexao com banco de dados
            SqlConnection conexao = new SqlConnection();

            //definir a connectString (onde o bd se encontra)
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\74639\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";

            //Abrir a conexao com banco de dados
            conexao.Open();

            //criar o objeto que sera utilizado para definir o comando
            SqlCommand comando = conexao.CreateCommand();

            //definir o comando que sera executado
            comando.CommandText = "DELETE FROM categorias WHERE id = " + codigoInformado;

            //executar o comando para apagar a castegoria
            int quantidadeRegistrosApagados = comando.ExecuteNonQuery();

            if (quantidadeRegistrosApagados == 0)
            {
                MessageBox.Show("Não existe categoria com o codigo " + codigoInformado);
                textBoxCodigoApagar.Focus();
                return;
            }

            //limpar campo do codigo para apagar
            textBoxCodigoApagar.Clear();

            MessageBox.Show("Registro apagado com sucesso");

            listarCategorias();
        }

        private void categoriaForm_Load(object sender, EventArgs e)
        {
            //preencher a lista decategorias com os registros de tabelas de categorias
            listarCategorias();

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
            int codigoParaAlterar = Convert .ToInt32(textBoxCodigoParaAlterar.Text);
            string nome = textBoxNomeParaAlterar.Text;

            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\74639\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";

            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "UPDATE categorias SET nome = '" + nome + "' WHERE id = " + codigoParaAlterar;

            int quantidadeAlterada = comando.ExecuteNonQuery();

            if( quantidadeAlterada == 0 )
            {
                MessageBox.Show("não existe categoria com o codigo " + codigoParaAlterar);
                textBoxCodigoApagar.Focus();
                return;
            }

            textBoxCodigoParaAlterar.Clear();
            textBoxNomeParaAlterar.Clear();

            MessageBox.Show("Categoria atualizada com sucesso");

            listarCategorias();

        }
    }
}
