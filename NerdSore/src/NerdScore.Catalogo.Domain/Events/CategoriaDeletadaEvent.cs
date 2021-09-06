using NerdScore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

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
