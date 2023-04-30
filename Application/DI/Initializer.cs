using Domain.Repository;
using Domain.Service;
using Domain.Service.Interface;
using Infrastructure.Context;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DI
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string conection)
        {

            services.AddDbContext<ServiceContext>(opts => opts.UseMySQL(conection));
            services.AddScoped<IMinerioRepository, MinerioRepository>();
            services.AddScoped<IMinerioService, MinerioService>();
            services.AddScoped<ICargueiroRepository, CargueiroRepository>();
            services.AddScoped<ICargueiroService, CargueiroService>();
            services.AddScoped<ITransporteService, TransporteService>();
            services.AddScoped<ITransporteRepository, TransporteRespository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        }
    }
}
