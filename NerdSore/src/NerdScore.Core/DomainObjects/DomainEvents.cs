using NerdScore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdScore.Core.DomainObjects
{
    public class DomainEvents :Event
    {
        public DomainEvents(Guid aggregateId)
        {
            AggregateId = aggregateId;  
        }

    }
}
