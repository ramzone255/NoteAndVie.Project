using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Note_Vie.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Persistence.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection
            services, IConfiguration configuration)
        {
            services.AddDbContext<Note_VieDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ConnectionDbString"),
            b => b.MigrationsAssembly(typeof(Note_VieDbContext).Assembly.FullName)), ServiceLifetime.Transient);
            services.AddScoped<INote_VieDbContext>(provider =>
            provider.GetService<Note_VieDbContext>());
            return services;
        }
    }
}
