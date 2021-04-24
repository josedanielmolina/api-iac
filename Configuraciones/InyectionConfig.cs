namespace Configuraciones
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    using Repositorio;
    using Utilidades;

    public static class InyectionConfig
    {
        public static IServiceCollection RegisterServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddScoped<TblPruebasRepositorio>();
            service.AddScoped<TblListasPersonalizadasRepositorio>();
            service.AddScoped<TblVehiculosRepositorio>();
            service.AddScoped<DefectosRepositorio>();
            service.AddScoped<TblEquiposRepositorio>();
            service.AddScoped<TblObservacionesRepositorio>();

            return service;
        }
    }
}