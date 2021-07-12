using System;
using Pagamento.Domain.ValueObjects;

namespace Pagamento.Domain.Entities
{
    public abstract class Pagamento
    {
        protected Pagamento(string titular,
                            Documento documento,
                            string endereco,
                            DateTime dtPagamento,
                            DateTime dtVencimento,
                            decimal total,
                            decimal totalPago,
                            Email email)
        {
            Id = Guid.NewGuid();
            Titular = titular;
            Documento = documento;
            Endereco = endereco;
            DtPagamento = dtPagamento;
            DtVencimento = dtVencimento;
            Total = total;
            TotalPago = totalPago;
            Email = email;
        }

        private Guid Id { get; set; }
        public string Titular { get; private set; }
        public Documento Documento { get; private set; }
        public string Endereco { get; private set; }
        public DateTime DtPagamento { get; private set; }
        public DateTime DtVencimento { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPago { get; private set; }
        public Email Email { get; private set; }
    }
}