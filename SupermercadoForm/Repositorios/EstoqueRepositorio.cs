using SupermercadoForm.BancoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoForm.Repositorios
{
    internal class EstoqueRepositorio
    {
        public void Cadastrar(int quantidade, int idProduto)
        {
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();

            comando.CommandText = "INSERT INTO estoques (quantidade, id_produto) VALUES (@QUANTIDADE, @ID_PRODUTO)";

            comando.Parameters.AddWithValue("@QUANTIDADE", quantidade);
            comando.Parameters.AddWithValue("@ID_PRODUTO", idProduto);
            comando.ExecuteNonQuery();
            comando.Connection.Close();

        }
    }
}
