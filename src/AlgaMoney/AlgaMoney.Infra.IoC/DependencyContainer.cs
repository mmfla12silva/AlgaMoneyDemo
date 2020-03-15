using AlgaMoney.Application.Interfaces;
using AlgaMoney.Application.Services;
using AlgaMoney.Domain.Interfaces;
using AlgaMoney.Infra.Data.Context;
using AlgaMoney.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgaMoney.Infra.IoC
{
    public class DependencyContainer
    {

        public static void RegisterServices(IServiceCollection services)
        {
            //Application layer
            services.AddScoped<ICategoriaService, CategoriaService>();

            //Infra.Data layer
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<AlgaMoneyApiDbContext>();

        }
    }
}
