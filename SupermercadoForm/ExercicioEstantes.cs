using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermercadoForm
{
    public partial class ExercicioEstantes : Form
    {
        public ExercicioEstantes()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarEstante();
        }

        private void cadastrarEstante()
        {
            string nomeEstante = textBoxCadastrar.Text;

            if (nomeEstante.Length < 3)
            {
                MessageBox.Show("o nome da Estante deve conter no minimo 3 caracteres");
                return;
            }

            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Desktop\\joao\\C#\\C-sharp-n51\\bdEstantes.mdf;Integrated Security=True;Connect Timeout=30";

            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO estantes (nome) VALUES ('" + nomeEstante + "')";

            comando.ExecuteNonQuery();

            textBoxCadastrar.Clear();

            MessageBox.Show("Estante cadastrada com sucesso");

            ExibirEstantes();
        }

        private void buttonExibir_Click(object sender, EventArgs e)
        {
            ExibirEstantes();
        }

        private void ExibirEstantes()
        {
            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Desktop\\joao\\C#\\C-sharp-n51\\bdEstantes.mdf;Integrated Security=True;Connect Timeout=30";

            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome FROM estantes";

            DataTable tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            //limpar campo que contem as categorias
            richTextExibir.Clear();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                DataRow registro = tabelaEmMemoria.Rows[i];
                int id = Convert.ToInt32(registro["id"]);
                string nome = registro["nome"].ToString();

                richTextExibir.AppendText("Cod: " + id + " => " + nome + "\n");
            }

        }



        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            ExcluirEstante();
        }

        private void ExcluirEstante()
        {
            int codigoInformado = Convert.ToInt32(textBoxExcluir.Text);

            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Desktop\\joao\\C#\\C-sharp-n51\\bdEstantes.mdf;Integrated Security=True;Connect Timeout=30";

            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM estantes";

            int quantidadeRegistrosApagados = comando.ExecuteNonQuery();

            if (quantidadeRegistrosApagados == 0)
            {
                MessageBox.Show("Não existe estante com o codigo " + codigoInformado);
                textBoxExcluir.Focus();
                return;
            }

            textBoxExcluir.Clear();

            MessageBox.Show("Estante apagada com sucesso");

            ExibirEstantes();
        }


    }
}

