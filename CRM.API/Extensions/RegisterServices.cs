using CRM.API.Middlewares;
using System;

namespace CRM.API.Extensions
{
    public static class RegisterServices
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddMediatR(Cfg => Cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

            services.AddTransient<ExceptionMiddleware>();

            return services;
        }
    }
}
