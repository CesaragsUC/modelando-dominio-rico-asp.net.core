using MediatR;
using NerdScore.Core.Communication.Mediator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoEventHandler :
        INotificationHandler<PedidoRascunhoIniciadoEvent>,
        INotificationHandler<PedidoItemAdicionadoEvent>
    {

        private readonly IMediatorHandler _mediatorHandler;

        public PedidoEventHandler(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        public Task Handle(PedidoRascunhoIniciadoEvent notification, CancellationToken cancellationToken)
        {
            //Aqui dentro poderia ser usando pra fazer alguma coisa com os eventos
            //mandar email, fazer alguma integração etc..
            return Task.CompletedTask;
        }

        public Task Handle(PedidoItemAdicionadoEvent notification, CancellationToken cancellationToken)
        {
            //Aqui dentro poderia ser usando pra fazer alguma coisa com os eventos
            //mandar email, fazer alguma integração etc..
            return Task.CompletedTask;
        }

        //public async Task Handle(PedidoEstoqueRejeitadoEvent message, CancellationToken cancellationToken)
        //{
        //    await _mediatorHandler.EnviarComando(new CancelarProcessamentoPedidoCommand(message.PedidoId, message.ClienteId));
        //}

        //public async Task Handle(PedidoPagamentoRealizadoEvent message, CancellationToken cancellationToken)
        //{
        //    await _mediatorHandler.EnviarComando(new FinalizarPedidoCommand(message.PedidoId, message.ClienteId));
        //}

        //public async Task Handle(PedidoPagamentoRecusadoEvent message, CancellationToken cancellationToken)
        //{
        //    await _mediatorHandler.EnviarComando(new CancelarProcessamentoPedidoEstornarEstoqueCommand(message.PedidoId, message.ClienteId));
        //}
    }
}
