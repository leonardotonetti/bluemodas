using BlueModasApi.Business.Interfaces.Business.Service;
using BlueModasApi.Business.Interfaces.Data.UnitOfWork;
using BlueModasApi.Business.Services;
using BlueModasApi.Business.Util.Notification;
using BlueModasApi.Data.Context;
using BlueModasApi.Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlueModasApi.CrossCutting.IoC
{
    public static class DependencyInjectionUtil
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration config)
        {
            //Context
            services.AddDbContext<BlueModasApiContext>(options => options.UseSqlServer(config.GetConnectionString("SqlServer")));

            //Notificacao
            services.AddScoped<NotificationContext>();

            //Unit of Work
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #region Services

            services.AddScoped<ITokenService, TokenService>();

            #endregion

            #region Repositories

            #endregion

            return services;
        }
    }
}
