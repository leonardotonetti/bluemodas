using BlueModasWeb.UI.Web.Request.TipoPublicoAlvo;
using BlueModasWeb.UI.Web.Request.Token;
using Microsoft.Extensions.DependencyInjection;

namespace BlueModasWeb.UI.Web.CrossCutting.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<ITokenRequest, TokenRequest>();
            services.AddTransient<ITipoPublicoAlvoRequest, TipoPublicoAlvoRequest>();

            return services;
        }
    }
}
