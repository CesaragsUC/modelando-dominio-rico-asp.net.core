using AutoMapper;
using NerdScore.Catalogo.Domain;
using NerdStore.Catalogo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Application.Services
{
    public class CategoriaAppService : ICategoriaAppService
    {

        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaAppService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;   
        }

        public async Task AdicionarCategoria(CategoriaViewModel categoriaViewModel)
        {
            var categoria = _mapper.Map<Categoria>(categoriaViewModel);
            _categoriaRepository.Adicionar(categoria);

            await _categoriaRepository.UnitOfWork.Commit();

        }

        public async Task AtualizarCategoria(CategoriaViewModel categoriaViewModel)
        {
            var categoria = _mapper.Map<Categoria>(categoriaViewModel);
            _categoriaRepository.Atualizar(categoria);

            await _categoriaRepository.UnitOfWork.Commit();
        }

        public async Task RemoverCategoria(CategoriaViewModel categoriaViewModel)
        {
            var categoria = _mapper.Map<Categoria>(categoriaViewModel);
            _categoriaRepository.Remover(categoria);

            await _categoriaRepository.UnitOfWork.Commit();
        }
        
        public void Dispose()
        {
            _categoriaRepository?.Dispose();
        }

        public async Task<CategoriaViewModel> ObterPorId(Guid id)
        {
            return   _mapper.Map<CategoriaViewModel>( await _categoriaRepository.ObterPorId(id));
        }

        public async Task<IEnumerable<CategoriaViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<CategoriaViewModel>>(await _categoriaRepository.ObterTodos());
        }
    }
}
