using NerdScore.Core.Messages.CommonMessages.DomainEvents;
using System;

namespace NerdScore.Catalogo.Domain.Events
{
    public class CategoriaDeletadaEvent : DomainEvents
    {
        public  string Nome  { get; private set; }
        public CategoriaDeletadaEvent(Guid aggregateId,string nome):base(aggregateId) // aggregateId seria Id da Categoria
        {
            Nome = nome;
        }
    }
}
