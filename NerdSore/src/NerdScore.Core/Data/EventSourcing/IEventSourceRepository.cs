using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core.Data.EventSourcing
{
    public interface IEventSourceRepository 
    {
        Task SalvarEvento<TEvent>(TEvent evento) where TEvent : Event;

        Task<IEnumerable<StoreEvent>> ObterEventos(Guid aggregateId);
    }
}
