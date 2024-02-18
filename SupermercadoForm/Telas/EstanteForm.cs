using SupermercadoForm.Entidades;
using SupermercadoForm.Repositorios;
using System.Data.SqlClient;

namespace SupermercadoForm.Telas
{
    public partial class EstanteForm : Form
    {
        private IEstanteRepositorio repositorio;
        private int IdparaEditar = -1;

        public EstanteForm()
        {
            repositorio = new EstanteRepositorio();

            InitializeComponent();
            ListarEstantes();
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
            string pesquisa = textBoxPesquisar.Text.Trim();

            dataGridViewEstantes.Rows.Clear();

            var estantes = repositorio.ObterTodos(pesquisa);

            //percorre cada um dos registros
            foreach ( var estante in estantes )
            {
                //adiciona uma linha de dataGridView(componente da tabela do form)
                dataGridViewEstantes.Rows.Add(new Object[]
                {
                    estante.Id, estante.Nome, estante.Sigla
                });

            }

        }

        private void CadastrarEstante()
        {
            //obter nome e sigla do form
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;

            var estante = new Estante();
            estante.Nome = nome;
            estante.Sigla = sigla;

            repositorio.Cadastrar(estante);


            ListarEstantes();//Atualiza o dataGriView(Tabela) com os registros das estantes do BD
            LimparCampos();//Limpa os campos 
            MessageBox.Show("Estante cadastrada com sucesso");

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

            var estante = repositorio.ObterPorId(IdparaEditar);

            textBoxNome.Text = estante.Nome;
            maskedTextBoxSigla.Text = estante.Sigla;

        }

        private void AtualizarEstante()
        {
            //obter nome e sigla do form
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;

            var estante = new Estante();
            estante.Id = IdparaEditar;
            estante.Nome = nome;
            estante.Sigla = sigla;

            repositorio.Atualizar(estante);

            ListarEstantes();//Atualiza o dataGriView(Tabela) com os registros das estantes do BD
            LimparCampos();//Limpa os campos 
            MessageBox.Show("Estante alterada com sucesso");

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
