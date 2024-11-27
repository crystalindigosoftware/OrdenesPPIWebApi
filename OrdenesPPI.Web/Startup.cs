using Microsoft.EntityFrameworkCore;
using OrdenesPPI.Core.Interfaces.Repository;
using OrdenesPPI.Core.Interfaces;
using OrdenesPPI.Infrastructure.Data;
using OrdenesPPI.Infrastructure.Repositories;
using OrdenesPPI.Core.Interfaces.Services;
using OrdenesPPI.Services;

namespace OrdenesPPI.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // ...
            //Para desplegar Docker o ejecutar en IIS
            string ConnectionString = Configuration.GetConnectionString("Default"); //?? Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(ConnectionString,
            x => x.MigrationsAssembly("OrdenesPPI.Infrastructure")));

            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            services.AddScoped(typeof(ITipoactivoRepository), typeof(TipoactivoRepository));
            services.AddScoped(typeof(IActivoRepository), typeof(ActivoRepository));
            services.AddScoped(typeof(IEstadoRepository), typeof(EstadoRepository));
            services.AddScoped(typeof(ICuentaRepository), typeof(CuentaRepository));
            services.AddScoped(typeof(IOrdenRepository), typeof(OrdenRepository));

            services.AddScoped(typeof(ITipoactivoService), typeof(TipoactivoService));
            services.AddScoped(typeof(IActivoService), typeof(ActivoService));
            services.AddScoped(typeof(IEstadoService), typeof(EstadoService));
            services.AddScoped(typeof(ICuentaService), typeof(CuentaService));
            services.AddScoped(typeof(IOrdenService), typeof(OrdenService));

        }

        public void Configure(IApplicationBuilder app, IHostApplicationLifetime lifetime)
        {
            // ...
        }
    }
}
