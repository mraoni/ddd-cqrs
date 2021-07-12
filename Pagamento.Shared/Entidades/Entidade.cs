using System;

namespace Pagamento.Shared.Entidades
{
    public abstract class Entidade
    {
        public Entidade()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; private set; }
    }
}