using System;
using FluentValidation.Results;
using MediatR;

namespace Compras.Core.Messages
{
    public abstract class Command : Message, IRequest<ValidationResult>
    {
        public DateTime DataOcorrencia { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            DataOcorrencia = DateTime.Now;
        }

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}