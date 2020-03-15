using AlgaMoney.Domain.Interfaces;
using AlgaMoney.Domain.Models;
using AlgaMoney.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgaMoney.Infra.Data.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {

        private AlgaMoneyApiDbContext _ctx;

        public CategoriaRepository(AlgaMoneyApiDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Categoria> GetCategorias()
        {
            return _ctx.Categorias;
        }
    }
}
