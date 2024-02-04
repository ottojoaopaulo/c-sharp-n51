using SupermercadoForm.BancoDados;
using SupermercadoForm.Entidades;
using System.Data;

namespace SupermercadoForm.Repositorios
{
    internal class CategoriaRepositorio
    {
        public List<Categoria> ObterTodos()
        {
            //instancia um objeto que realiza a conexao com banco de dados
            var conexao = new ConexaoBancoDados();

            //Cria o comando utilizando a conexao
            var comando = conexao.Conectar();

            //definir o comando que sera executado para buscar as categorias
            comando.CommandText = "SELECT id, nome FROM categorias ORDER BY nome ASC";

            //instanciando uma tabela em memoria para armazenar os registros retornados pelo BD na consulta SELECT
            var tabelaEmMemoria = new DataTable();

            //executar a consulta SELECT carregando os dados da tabela em memoria
            tabelaEmMemoria.Load(comando.ExecuteReader());

            //fechar conexao com BD
            comando.Connection.Close();

            //instanciando uma lista para armazenar as categorias
            var categorias = new List<Categoria>();

            //Percorer cada um dos registros da consulta SELECT
            for (var i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                //obter o registro percorrido
                var registro = tabelaEmMemoria.Rows[i];
                var id = Convert.ToInt32(registro["idCategoria"]);
                var nome = registro["nome"].ToString();

                //instanciado um objeto de categoria para que seja possivel adicionar na lista de categorias
                var categoria = new Categoria();
                categoria.Id = id;
                categoria.Nome = nome;

                //adicionar a categoria na lista categorias
                categorias.Add(categoria);
            }
            //retornar a lista de categorias obtida na consulta SELECT
            return categorias;
        }
    }
}
