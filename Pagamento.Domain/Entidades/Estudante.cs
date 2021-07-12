using System.Collections.Generic;
using Pagamento.Domain.ValueObjects;

namespace Pagamento.Domain.Entities
{
    public class Estudante
    {
        public Nome Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get; set; }

        private IList<Assinatura> _assinaturas;

        public Estudante(Nome nome,
                         string sobrenome,
                         Documento documento,
                         Email email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Documento = documento;
            Email = email;
            _assinaturas = new List<Assinatura>();
        }

        public void AdicionarAssinatura(Assinatura assinatura)
        {
            foreach (var assin in Assinaturas)
                assinatura.CancelarAssinatura();

            _assinaturas.Add(assinatura);
        }
    }
}