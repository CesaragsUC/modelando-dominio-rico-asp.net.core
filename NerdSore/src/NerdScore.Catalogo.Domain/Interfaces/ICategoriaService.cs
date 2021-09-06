using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NerdScore.Catalogo.Domain.Interfaces
{
    public interface ICategoriaService
    {
        Task<bool> DeletarCategoria(Guid id);
    }
}
