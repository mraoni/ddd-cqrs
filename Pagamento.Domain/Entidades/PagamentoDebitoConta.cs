using System;
using Pagamento.Domain.ValueObjects;

namespace Pagamento.Domain.Entities
{
    public class PagamentoDebitoConta : Pagamento
    {
        public PagamentoDebitoConta(int banco,
                                    int agencia,
                                    int contaCorrente,
                                    int digito1,
                                    int digito2,
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
            Banco = banco;
            Agencia = agencia;
            ContaCorrente = contaCorrente;
            Digito1 = digito1;
            Digito2 = digito2;
        }

        public int Banco { get; set; }
        public int Agencia { get; set; }
        public int ContaCorrente { get; set; }
        public int Digito1 { get; set; }
        public int Digito2 { get; set; }
    }
}