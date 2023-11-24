using ABC.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.Repository
{
    public interface IContatoRepository
    {
        bool Incluir(Contato contato);

        bool Atualizar(Contato contato, int id);

        bool Deletar(int id);

        List<Contato> ObterTodos();

        List<Contato> FiltrarCategoria(string nome);

        List<Contato> ObterTodosPorStatus(int status);
        Contato ObterPorId(int id);
        List<Contato> ObterPorNome(string nome);
    }
}
