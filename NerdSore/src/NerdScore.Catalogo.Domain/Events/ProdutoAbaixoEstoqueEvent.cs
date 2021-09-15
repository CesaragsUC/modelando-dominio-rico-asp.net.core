using NerdScore.Core.DomainObjects;
using NerdScore.Core.Messages.CommonMessages.DomainEvents;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdScore.Catalogo.Domain.Events
{
    public class ProdutoAbaixoEstoqueEvent: DomainEvents
    {
        public int QuantidadeRestante { get; private set; }

        public ProdutoAbaixoEstoqueEvent(Guid aggregateId,int quantidadeRestante) : base(aggregateId)
        {
            QuantidadeRestante = quantidadeRestante;
        }
    }
}
