using AlgaMoney.Application.DtoModels;
using AlgaMoney.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgaMoney.Application.AutoMapper
{
    public class DomainToApplicationModelProfile : Profile
    {

        public DomainToApplicationModelProfile()
        {
            CreateMap<Categoria, CategoriaModel>();
        }
    }
}
