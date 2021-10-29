using AutoMapper;
using NerdStore.Catalogo.Domain;
using NerdStore.Catalogo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Application.Mapper
{
    public class DomainToViewModelMappingProdile : Profile
    {
        public DomainToViewModelMappingProdile()
        {


            CreateMap<Categoria, CategoriaViewModel>();

            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(d => d.Largura, o => o.MapFrom(s => s.Dimensoes.Largura))
                .ForMember(d => d.Altura, o => o.MapFrom(s => s.Dimensoes.Altura))
                .ForMember(d => d.Profundidade, o => o.MapFrom(s => s.Dimensoes.Profundidade));


        }
    }
}
