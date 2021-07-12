using System;
using Pagamento.Domain.ValueObjects;

namespace Pagamento.Domain.Entities
{
    public class PagamentoBoleto : Pagamento
    {
        public PagamentoBoleto(string nossoNumero,
                               string codigoBarras,
                               string titular,
                               Documento documento,
                               string endereco,
                               DateTime dtPagamento,
                               DateTime dtVencimento,
                               decimal total,
                               decimal totalPago,
                               Email email) : base(titular,
                                                    documento,
                                                    endereco,
                                                    dtPagamento,
                                                    dtVencimento,
                                                    total,
                                                    totalPago,
                                                    email)
        {
            NossoNumero = nossoNumero;
            CodigoBarras = codigoBarras;
        }

        public string NossoNumero { get; private set; }
        public string CodigoBarras { get; private set; }
    }
}