using Pagamento.Domain.Enums;

namespace Pagamento.Domain.ValueObjects
{
    public class Documento
    {
        public Documento(string numero, TipoDocumento tipoDocumento)
        {
            Numero = numero;
            TipoDocumento = tipoDocumento;
        }

        public string Numero { get; private set; }

        public TipoDocumento TipoDocumento { get; private set; }
    }
}