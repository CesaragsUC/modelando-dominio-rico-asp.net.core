using MediatR;
using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.Messages.CommonMessages.DomainEvents
{
    public abstract class DomainEvents : Message, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected DomainEvents(Guid agregationId)
        {
            AggregateId = agregationId;
            Timestamp = DateTime.Now;
        }

    }
}
