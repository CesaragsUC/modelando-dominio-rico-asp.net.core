using NerdScore.Catalogo.Domain.Events;
using NerdScore.Catalogo.Domain.Interfaces;
using NerdScore.Core.Communication.Mediator;
using System;
using System.Threading.Tasks;

namespace NerdScore.Catalogo.Domain.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMediatorHandler _bus;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMediatorHandler bus)
        {
            _bus = bus;
            _categoriaRepository = categoriaRepository;
        }
        public async Task<bool> DeletarCategoria(Guid id)
        {
            var categoria = await _categoriaRepository.ObterPorId(id);
            if (categoria == null) return false;

            //aqui via Mediator vamos enviar um evento pra ser enviado um email
            await _bus.PublicarEvento(new CategoriaDeletadaEvent(categoria.Id,categoria.Nome));

            _categoriaRepository.Remover(categoria);

            return  await _categoriaRepository.UnitOfWork.Commit(); //return bolean

        }
    }
}
