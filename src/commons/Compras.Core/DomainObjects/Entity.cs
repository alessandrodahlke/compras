using System;
using System.Collections.Generic;
using Compras.Core.Messages;

namespace Compras.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

    }
}