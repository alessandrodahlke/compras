using System;
using MediatR;

namespace Compras.Core.Messages
{
    public abstract class Event : Message, INotification
    {
        public DateTime DataOcorrencia { get; private set; }

        protected Event()
        {
            DataOcorrencia = DateTime.Now;
        }
    }
}