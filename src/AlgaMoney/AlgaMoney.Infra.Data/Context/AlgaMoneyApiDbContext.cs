using AlgaMoney.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgaMoney.Infra.Data.Context
{
    public class AlgaMoneyApiDbContext : DbContext
    {
        public AlgaMoneyApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<TipoLancamento> TipoLancamentos { get; set; }
    }
}
