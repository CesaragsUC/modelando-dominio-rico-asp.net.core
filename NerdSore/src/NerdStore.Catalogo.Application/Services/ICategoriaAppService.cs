using NerdStore.Catalogo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Application.Services
{
    public interface ICategoriaAppService : IDisposable
    {
        Task<CategoriaViewModel> ObterPorId(Guid id);
        Task<IEnumerable<CategoriaViewModel>> ObterTodos();

        Task AdicionarCategoria(CategoriaViewModel categoriaViewModel);
        Task AtualizarCategoria(CategoriaViewModel categoriaViewModel);
        Task RemoverCategoria(CategoriaViewModel categoriaViewModel);

    }
}
