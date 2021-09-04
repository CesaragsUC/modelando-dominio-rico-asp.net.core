using Microsoft.EntityFrameworkCore;
using NerdScore.Catalogo.Domain;
using NerdScore.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Data.Repositoty
{
    public class CategoriaRepository : ICategoriaRepository
    {

        private readonly CatalogoContext _context;

        public CategoriaRepository(CatalogoContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Categoria categoria)
        {
            _context.Add(categoria);
        }

        public void Atualizar(Categoria categoria)
        {
            _context.Update(categoria); 
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<Categoria> ObterPorId(Guid id)
        {
            return await _context.Categorias.AsNoTracking().FirstOrDefaultAsync(c=> c.Id == id);
        }

        public async Task<IEnumerable<Categoria>> ObterTodos()
        {
            return await _context.Categorias.AsNoTracking().ToListAsync();
        }

        public  void Remover(Categoria categoria)
        {
            if(categoria != null)
            {
                _context.Remove(categoria);
            }
        }
    }
}
