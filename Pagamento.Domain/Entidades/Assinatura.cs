using System;
using System.Collections.Generic;
using Pagamento.Shared.Entidades;

namespace Pagamento.Domain.Entities
{
    public class Assinatura : Entidade
    {
        private readonly IList<Pagamento> _pagamentos = null;
        public Assinatura(DateTime? dtExpiracao)
        {
            DtInclusao = DateTime.Now;
            DtAtualizacao = DateTime.Now;
            DtExpiracao = dtExpiracao;
            Ativo = true;
            Pagamentos = new List<Pagamento>();
        }

        private DateTime DtInclusao { get; set; }
        private DateTime DtAtualizacao { get; set; }
        public DateTime? DtExpiracao { get; set; }
        private bool Ativo { get; set; }
        public IReadOnlyCollection<Pagamento> Pagamentos { get; set; }

        public void AdicionarPagamento(Pagamento pagamento)
        {
            _pagamentos.Add(pagamento);
        }

        public void AtivarAssinatura()
        {
            Ativo = true;
            DtAtualizacao = DateTime.Now;
        }

        public void CancelarAssinatura()
        {
            Ativo = false;
            DtAtualizacao = DateTime.Now;
        }
    }
}