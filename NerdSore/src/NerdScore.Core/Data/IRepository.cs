using NerdScore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdScore.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
