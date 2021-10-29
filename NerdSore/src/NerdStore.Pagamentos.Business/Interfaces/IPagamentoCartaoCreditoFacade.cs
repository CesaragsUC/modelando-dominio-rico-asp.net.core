using NerdStore.Pagamentos.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Pagamentos.Business.Interfaces
{
    public interface IPagamentoCartaoCreditoFacade
    {
        Transacao RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
