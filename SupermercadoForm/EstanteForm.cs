using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermercadoForm
{
    public partial class EstanteForm : Form
    {
        public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Documents\\Supermercado.mdf;Integrated Security=True;Connect Timeout=30";
        private int IdparaEditar = -1;

        public EstanteForm()
        {
            InitializeComponent();
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (IdparaEditar == -1)
            {
                CadastrarEstante();
            }
            else
            {
                AtualizarEstante();
            }


        }

        private void ListarEstantes()
        {
            //obter texto para pesquisa
            string pesquisa = "%" + textBoxPesquisar.Text.Trim() + "%";//%Nes%

            //conecta com o banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            //definir o comando da consulta das estqantes
            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE nome LIKE @PESQUISA";
            comando.Parameters.AddWithValue("@PESQUISA", pesquisa);

            //cria tabela em memoria e carrega registros da consulta (SELECT) das estantes
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            dataGridViewEstantes.Rows.Clear();

            //percorre cada um dos registros
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                //obter registros (estantes) percorridas
                DataRow registro = tabelaEmMemoria.Rows[i];
                //obter nome, id e sigla da consulta realizada
                int id = Convert.ToInt32(registro["id"]);
                string nome = registro["nome"].ToString();
                string sigla = registro["sigla"].ToString();

                //adiciona uma linha de dataGridView(componente da tabela do form)
                dataGridViewEstantes.Rows.Add(new Object[]
                {
                    id, nome, sigla
                });

            }

        }

        private void CadastrarEstante()
        {
            //obter nome e sigla do form
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;


            //conecta com o banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            //definir o comando da consulta das estqantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO estantes (nome, sigla) VALUES (@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@SIGLA", sigla);

            //Executa o insert armazenando a quantidade de registros afetados
            int quantidadeRegistrosAfetados = comando.ExecuteNonQuery();

            //Verificar que o registro foi persistido com sucesso
            if (quantidadeRegistrosAfetados > 0)
            {
                ListarEstantes();//Atualiza o dataGriView(Tabela) com os registros das estantes do BD
                LimparCampos();//Limpa os campos 
                MessageBox.Show("Estante cadastrada com sucesso");
            }
        }

        private void EstanteForm_Load(object sender, EventArgs e)
        {
            ListarEstantes();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            maskedTextBoxSigla.Clear();
            IdparaEditar = -1; //redefinir para -1 para que seja possivel o usuario fazer o cadastro novamente
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            ApagarEstante();
        }

        private void ApagarEstante()
        {
            //verifica que existe linhas(registros) no dataGridView
            if (dataGridViewEstantes.Rows.Count == 0)
            {
                MessageBox.Show(
                 "Nenhuma Estante cadastrada",
                 "AVISO",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                return;
            }

            //pega alinha que o usuario selecionou
            DataGridViewRow LinhaSelecionada = dataGridViewEstantes.SelectedRows[0];

            //pegar o ID da linha selecionada
            int id = Convert.ToInt32(LinhaSelecionada.Cells[0].Value);
            string nome = LinhaSelecionada.Cells[1].Value.ToString();

            //questionar se deseja realmente apagar o registro
            DialogResult resultadoQuestionamento = MessageBox.Show(
                "Deseja realmente Apagar " + nome + "?",
                "AVISO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            //verifica se deseja manter o registro
            if (resultadoQuestionamento == DialogResult.No)
            {
                return;
            }


            //conectar com banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            //definir o comando da consulta das estantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM estantes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            int quantidadeRegistrosAfetados = comando.ExecuteNonQuery();

            if (quantidadeRegistrosAfetados > 0)
            {
                ListarEstantes();
                MessageBox.Show("Estante apagada com sucesso");

            }

            //fecha a conexao com DB
            conexao.Close();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarEstante();
        }

        private void EditarEstante()
        {
            //verifica que existe linhas(registros) no dataGridView
            if (dataGridViewEstantes.Rows.Count == 0)
            {
                MessageBox.Show(
                 "Nenhuma Estante cadastrada",
                 "AVISO",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                return;
            }

            //pegar alinha que o usuario selecionou
            DataGridViewRow linhaSelecionada = dataGridViewEstantes.SelectedRows[0];

            //pegar o ID da linha selecionada
            IdparaEditar = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            //conecta com o banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            //definir o comando da consulta das estqantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", IdparaEditar);

            //cria tabela em memoria e carrega registros da consulta (SELECT) das estantes
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            //obter a primeira linha em tabelapois filtramos buscando por ID, retornara um unico registro
            DataRow registro = tabelaEmMemoria.Rows[0];

            string nome = registro["nome"].ToString();
            string sigla = registro["sigla"].ToString();

            textBoxNome.Text = nome;
            maskedTextBoxSigla.Text = sigla;

            //Fechar a conexao
            conexao.Close();

        }

        private void AtualizarEstante()
        {
            //obter nome e sigla do form
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;


            //conecta com o banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            //definir o comando da consulta das estqantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE estantes SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@SIGLA", sigla);
            comando.Parameters.AddWithValue("@ID", IdparaEditar);

            //Executa o insert armazenando a quantidade de registros afetados
            int quantidadeRegistrosAfetados = comando.ExecuteNonQuery();

            //Verificar que o registro foi persistido com sucesso
            if (quantidadeRegistrosAfetados > 0)
            {
                ListarEstantes();//Atualiza o dataGriView(Tabela) com os registros das estantes do BD
                LimparCampos();//Limpa os campos 
                MessageBox.Show("Estante alterada com sucesso");
            }
        }

        private void textBoxPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListarEstantes();
            }
        }
    }
}
