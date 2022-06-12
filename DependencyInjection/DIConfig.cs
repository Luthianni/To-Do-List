using Microsoft.Extensions.DependencyInjection;
using PraHoje.Interface;
using PraHoje.Repository;
using PraHoje.Services;

namespace PraHoje.DependencyInjection
{
    public class DIConfig
    {
        public static void Register(IServiceCollection service)
        {
            service.AddTransient<ITarefasListaService, TarefasListaService>();
            service.AddTransient<ITarefasListaRepository, TarefasListaRepository>();
        }
    }
}
