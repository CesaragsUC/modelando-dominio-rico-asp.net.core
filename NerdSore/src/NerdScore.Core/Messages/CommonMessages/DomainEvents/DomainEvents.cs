using NerdScore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdScore.Core.Messages.CommonMessages.DomainEvents
{
    public class DomainEvents :Event
    {
        public DomainEvents(Guid aggregateId)
        {
            AggregateId = aggregateId;  
        }

    }
}
