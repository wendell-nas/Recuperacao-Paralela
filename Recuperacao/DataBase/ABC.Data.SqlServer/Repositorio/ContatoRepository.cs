using ABC.Core.Entidades;
using ABC.Core.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC.Data.SqlServer.DataContexto;
using Microsoft.Data.SqlClient;

namespace ABC.Data.SqlServer.Repositorio
{
    public class ContatoRepository : IContatoRepository
    {
        public bool Atualizar(Contato contato, int id)
        {
            throw new NotImplementedException();
        }

        public bool Deletar(int id)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    connection.Open();
                    var sql = @"DELETE FROM Contato
                                WHERE Id = @Id";
                    var parametros = new DynamicParameters();
                    parametros.Add("@Id", id);
                    var linhasAfetadas = connection.Execute(sql, parametros);
                    return linhasAfetadas == 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Contato> FiltrarCategoria(string nome)
        {
            throw new NotImplementedException();
        }

        public bool Incluir(Contato contato)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    if (string.IsNullOrEmpty(contato.Nome))
                    {
                        return false;
                    }
                    var sql = "INSERT INTO Contato (Nome, Telefone,Email, DataNascimento, Cep, Cidade, Bairro, Cargo, Empresa, DataContato, Observacoes) VALUES (@nome, @telefone, @email, @dataNascimento, @cep, @cidade, @bairro, @cargo, @empresa, @dataContato, @observacoes)";

                    //Protege os valores que estão chegando pela Classe Cargo de SqlInjection
                    //E passa para o Dapper Substituir no "var sql" os valores @ pelo valor que chegou
                    //no parametro.
                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", contato.Nome);
                    parametros.Add("@telefone", contato.Telefone);
                    parametros.Add("@email", contato.Email);
                    parametros.Add("@dataNascimento", DateTime.Now);
                    parametros.Add("@cep", contato.Cep);
                    parametros.Add("@cidade", contato.Cidade);
                    parametros.Add("@bairro", contato.Bairro);
                    parametros.Add("@cargo", contato.Cargo);
                    parametros.Add("@empresa", contato.Empresa);
                    parametros.Add("@dataContato", DateTime.Now);
                    parametros.Add("@observacoes", contato.Observacoes);



                    //Executa o comando
                    var linhasAfetadas = connection.Execute(sql, parametros);

                    //Verifica se uma linha foi inserida com sucesso
                    return linhasAfetadas == 1;
                }

            }
            catch (Exception ex)
            {
                // Faça algo com a exceção, como logar ou lançar uma exceção personalizada com uma mensagem descritiva
                throw new Exception("Erro ao incluir cliente.", ex);
            }
        }

        public Contato ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contato> ObterPorNome(string nome)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    var sql = @"SELECT Nome FROM Contato WHERE Nome LIKE @nome;";

                    var parametros = new DynamicParameters();
                    parametros.Add("@Nome", $"%{nome}%");

                    var resultado = connection.Query<Contato>(sql, parametros);

                    return resultado.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<Contato> ObterTodos()
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    var sql = @"SELECT [Id]
      ,[Nome]
      ,[Telefone]
      ,[Email]
      ,[DataNascimento]
      ,[Cep]
      ,[Cidade]
      ,[Bairro]
      ,[Cargo]
      ,[Empresa]
      ,[DataContato]
      ,[Observacoes]
  FROM [dbo].[Contato]";

                    var contatos = connection.Query<Contato>(sql);


                    return contatos.ToList();
                }
            }
            catch (Exception ex)
            {
                // Faça algo com a exceção, como logar ou lançar uma exceção personalizada com uma mensagem descritiva
                throw new Exception("Erro ao obter C.", ex);
            }
        }

        public List<Contato> ObterTodosPorStatus(int status)
        {
            throw new NotImplementedException();
        }
    }
}
