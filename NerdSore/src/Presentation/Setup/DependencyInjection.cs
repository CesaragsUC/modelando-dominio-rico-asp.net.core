using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NerdScore.Catalogo.Domain;
using NerdScore.Catalogo.Domain.Events;
using NerdScore.Catalogo.Domain.Interfaces;
using NerdScore.Catalogo.Domain.Service;
using NerdScore.Core.Bus;
using NerdStore.Application;
using NerdStore.Catalogo.Application.Services;
using NerdStore.Catalogo.Data;
using NerdStore.Catalogo.Data.Repositoty;
using NerdStore.Vendas.Application.Commands;
using NerdStore.Vendas.Data;
using NerdStore.Vendas.Data.Repository;
using NerdStore.Vendas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Catalogo Context

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<ICategoriaAppService, CategoriaAppService>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<CatalogoContext>();

            services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();
            services.AddScoped<INotificationHandler<CategoriaDeletadaEvent>, CategoriaEventHandler>();


            //Vendas Context
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<VendasContext>();

            services.AddScoped<IRequestHandler<AdicionarItemPedidoCommand,bool>, PedidoCommandHandler>();
        }
    }
}
