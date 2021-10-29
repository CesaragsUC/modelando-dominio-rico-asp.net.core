using NerdStore.Core.Data;
using NerdStore.Pagamentos.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Pagamentos.Data.Repository
{
    public interface IPagamentoRepository : IRepository<Pagamento>
    {
        void Adicionar(Pagamento pagamento);

        void AdicionarTransacao(Transacao transacao);
    }
}
