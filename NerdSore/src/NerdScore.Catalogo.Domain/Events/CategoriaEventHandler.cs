using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace NerdScore.Catalogo.Domain.Events
{
    public class CategoriaEventHandler : INotificationHandler<CategoriaDeletadaEvent>
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaEventHandler(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository; 
        }
        public async Task Handle(CategoriaDeletadaEvent message, CancellationToken cancellationToken)
        {
            var result = await _categoriaRepository.ObterPorId(message.AggregateId);
            // Aqui poderia enviar email avisando que uma categoria "result.Nome" foi removida do sistema.
        }
    }
}
