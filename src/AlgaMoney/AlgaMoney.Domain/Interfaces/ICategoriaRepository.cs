using AlgaMoney.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgaMoney.Domain.Interfaces
{
    public interface ICategoriaRepository
    {

        IEnumerable<Categoria> GetCategorias();
    }
}
