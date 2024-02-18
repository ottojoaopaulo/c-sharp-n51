using SupermercadoForm.Modelos;
using SupermercadoRepositorios.BancoDados;
using SupermercadoRepositorios.Entidades;
using System.Data;

namespace SupermercadoForm.Repositorios
{
    public class ProdutoRepositorio
    {

        public void Cadastrar(string nome, int idCategoria, decimal precoUnitario)
        {
            var conexao = new ConexaoBancoDados();

            var comando = conexao.Conectar();

            comando.CommandText = "INSERT INTO produtos (nome, id_categoria, preco_unitario) VALUES (@NOME, @ID_CATEGORIA, @PRECO_UNITARIO )";

            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@ID_CATEGORIA", idCategoria);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public List<Produto> ObterTodos(ProdutoFiltros produtoFiltros)
        {
            var conexao = new ConexaoBancoDados();

            var comando = conexao.Conectar();

            comando.CommandText = $"""
                SELECT 
                produtos.id,
                produtos.nome,
                produtos.id_categoria AS 'categoriaId',
                produtos.preco_unitario,
                categorias.nome AS 'categoriaNome'

             FROM produtos

                -- JOIN:consulta de multi tabelas;
                INNER JOIN categorias ON (produtos.id_categoria = categorias.id)

                WHERE produtos.nome LIKE @PESQUISA
                ORDER BY {produtoFiltros.OrdenacaoCampo} {produtoFiltros.OrdenacaoOrdem}
                OFFSET @POSICAO_PAGINACAO ROWS -- determinar qual sera a pagina
                FETCH NEXT @QUANTIDADE ROWS ONLY -- determinar a quantidade de registros consultados

             """;

            comando.Parameters.AddWithValue("@PESQUISA", produtoFiltros.Pesquisa);
            comando.Parameters.AddWithValue("@QUANTIDADE", produtoFiltros.Quantidade);
            comando.Parameters.AddWithValue("@POSICAO_PAGINACAO", produtoFiltros.Pagina);

            //instanciando uma tabela em memoria para armazenar os registros retornados pelo BD na consulta SELECT
            var tabelaEmMemoria = new DataTable();

            //executar a consulta SELECT carregando os dados da tabela em memoria
            tabelaEmMemoria.Load(comando.ExecuteReader());

            //fechar conexao com BD
            comando.Connection.Close();

            //instanciando uma lista para armazenar as categorias
            var produtos = new List<Produto>();

            //percorrer os registros armazenados na tabela em memoria
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var produto = new Produto();
                produto.Id = Convert.ToInt32(registro["id"]);
                produto.Nome = registro["nome"].ToString();
                produto.PrecoUnitario = Convert.ToDecimal(registro["preco_unitario"]);

                var categoria = new Categoria();
                categoria.Id = Convert.ToInt32(registro["categoriaId"]);
                categoria.Nome = registro["categoriaNome"].ToString();

                produto.Categoria = categoria;

                produtos.Add(produto);
            }

            return produtos;
        }

        public int ObterQuantidadeTotalRegistros()
        {
            //instancia um objeto que realiza a conexao com banco de dados
            var conexao = new ConexaoBancoDados();
            //criando o comando utilizando a conexao
            var comando = conexao.Conectar();
            //definir o comando de criar produto na tabela de produtos
            comando.CommandText = "SELECT COUNT(id) FROM produtos";
            //ExecuteScalar executara o comando no banco de dados com o objetivo de obter um numero inteiro
            var registroQuantidade = Convert.ToInt32(comando.ExecuteScalar());
            //fechar a conexao
            comando.Connection.Close();
            return registroQuantidade;
        }
    }
}
