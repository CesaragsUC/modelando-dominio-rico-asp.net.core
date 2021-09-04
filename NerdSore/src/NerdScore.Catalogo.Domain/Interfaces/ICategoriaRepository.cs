using NerdScore.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NerdScore.Catalogo.Domain
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        Task<IEnumerable<Categoria>> ObterTodos();
        Task<Categoria> ObterPorId(Guid id);

        void Adicionar(Categoria categoria);
        void Atualizar(Categoria categoria);

        void Remover(Categoria categoria);

    }
}
