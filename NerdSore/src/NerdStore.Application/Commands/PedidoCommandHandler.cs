﻿using MediatR;
using NerdScore.Core.Communication.Mediator;
using NerdScore.Core.Messages;
using NerdScore.Core.Messages.CommonMessages.Notifications;
using NerdStore.Application;
using NerdStore.Vendas.Domain;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Application.Commands
{
    public class PedidoCommandHandler : 
        IRequestHandler<AdicionarItemPedidoCommand, bool>
    {

        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMediatorHandler _mediatorHandler;

        public PedidoCommandHandler(IPedidoRepository pedidoRepository,
                                    IMediatorHandler mediatorHandler)
        {
            _pedidoRepository = pedidoRepository;
            _mediatorHandler = mediatorHandler;
        }

        public  async Task<bool> Handle(AdicionarItemPedidoCommand message, CancellationToken cancellationToken)
        {
            if(!ValidarComando(message)) return false;


            var pedido = await _pedidoRepository.ObterPedidoRascunhoPorClienteId(message.ClienteId);
            var pedidoItem = new PedidoItem(message.ProdutoId, message.Nome, message.Quantidade, message.ValorUnitario);

            if (pedido == null)
            {
                pedido = Pedido.PedidoFactory.NovoPedidoRascunho(message.ClienteId);
                pedido.AdicionarItem(pedidoItem);
                _pedidoRepository.Adicionar(pedido);
            }
            else
            {
                var pedidoItemExistente = pedido.PedidoItemExistente(pedidoItem);
                pedido.AdicionarItem(pedidoItem);

                if(pedidoItemExistente)
                {
                    _pedidoRepository.AtualizarItem(pedido.PedidoItems.FirstOrDefault(p => p.ProdutoId == pedidoItem.ProdutoId));
                }
                else
                {
                    _pedidoRepository.AdicionarItem(pedidoItem);
                }
            }


            return await _pedidoRepository.UnitOfWork.Commit();
        }

        private bool ValidarComando(Command message)
        {
            if (message.EhValido()) return true;

            foreach (var error in message.ValidationResult.Errors)
            {
                _mediatorHandler.PublicarNotificacao(new DomainNotification(message.MessageType, error.ErrorMessage));
            }

            return false;
        }
    }
}
