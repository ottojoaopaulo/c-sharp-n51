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

            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Desktop\\joao\\C#\\C-sharp-n51\\bdEstantes.mdf;Integrated Security=True;Connect Timeout=30";

            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO estantes (nome) VALUES ('" + nomeEstante + "')";

            comando.ExecuteNonQuery();

            textBoxCadastrar.Clear();

            MessageBox.Show("Estante cadastrada com sucesso");

            //listarEstantes
        }
    }
}
