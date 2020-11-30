using BlueModasWeb.UI.Web.Request.Cliente;
using BlueModasWeb.UI.Web.Request.Pedido;
using BlueModasWeb.UI.Web.Request.Produto;
using BlueModasWeb.UI.Web.Request.TipoPublicoAlvo;
using BlueModasWeb.UI.Web.Request.Token;
using Microsoft.Extensions.DependencyInjection;

namespace BlueModasWeb.UI.Web.CrossCutting.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenRequest, TokenRequest>();
            services.AddScoped<ITipoPublicoAlvoRequest, TipoPublicoAlvoRequest>();
            services.AddScoped<IProdutoRequest, ProdutoRequest>();
            services.AddScoped<IClienteRequest, ClienteRequest>();
            services.AddScoped<IPedidoRequest, PedidoRequest>();

            return services;
        }
    }
}
