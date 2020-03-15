using AlgaMoney.Application.DtoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgaMoney.Application.Interfaces
{
    public interface ICategoriaService
    {
        CategoriaModel GetCategorias();

        void Create(CategoriaModel categoriaModel);
    }
}
