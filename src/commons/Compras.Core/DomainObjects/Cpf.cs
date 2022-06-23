using Compras.Core.Utils;

namespace Compras.Core.DomainObjects
{
    public class Cpf
    {
        public const int CpfMaxLength = 11;
        public string Numero { get; private set; }

        protected Cpf() { }

        public Cpf(string numero)
        {
            if (!Validar(numero))
                throw new DomainException("CPF inválido");

            Numero = numero;
        }

        public static bool Validar(string cpf)
        {
            //Implementar validação de CPF

            return true;
        }
    }
}