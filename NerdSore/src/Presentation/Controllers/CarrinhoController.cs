﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdScore.Core.Communication.Mediator;
using NerdScore.Core.Messages.CommonMessages.Notifications;
using NerdStore.Application;
using NerdStore.Catalogo.Application.Services;
using System;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class CarrinhoController : ControllerBase
    {

        private readonly IProdutoAppService _produtoAppService;
       // private readonly IPedidoQueries _pedidoQueries;
        private readonly IMediatorHandler _mediatorHandler;

        public CarrinhoController(INotificationHandler<DomainNotification> notifications, 
                                    IProdutoAppService produtoAppService,
                                    IMediatorHandler mediatorHandler):base(notifications,mediatorHandler)
        {
            _produtoAppService = produtoAppService;
            _mediatorHandler = mediatorHandler; 
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("meu-carrinho")]
        public async Task<IActionResult> AdicionarItem(Guid id, int quantidade)
        {
            var produto = await _produtoAppService.ObterPorId(id);
            if (produto == null) return BadRequest();

            if (produto.QuantidadeEstoque < quantidade)
            {
                TempData["Erro"] = "Produto com estoque insuficiente";
                return RedirectToAction("ProdutoDetalhe", "Vitrine", new { id });
            }

            var command = new AdicionarItemPedidoCommand(ClienteId, produto.Id, produto.Nome, quantidade, produto.Valor);
            await _mediatorHandler.EnviarComando(command);

            if (OperacaoValida())
            {
                return RedirectToAction("Index");
            }

            TempData["Erros"] = ObterMensagensErro();
            return RedirectToAction("ProdutoDetalhe", "Vitrine", new { id });
        }

    }
}
