using AutoMapper;
using AutoMapper.QueryableExtensions;
using AlgaMoney.Application.Interfaces;
using AlgaMoney.Application.DtoModels;
using AlgaMoney.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgaMoney.Application.Services
{
    public class CategoriaService : ICategoriaService
    {

        private ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public void Create(CategoriaModel categoriaModel)
        {
            throw new NotImplementedException();
        }

        public CategoriaModel GetCategorias()
        {
            return new CategoriaModel()
            {
                Categorias = _categoriaRepository.GetCategorias()
            };
        }
    }
}
