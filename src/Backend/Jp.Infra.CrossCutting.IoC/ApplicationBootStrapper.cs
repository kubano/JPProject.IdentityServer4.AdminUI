﻿using Jp.Application.Interfaces;
using Jp.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Jp.Infra.CrossCutting.IoC
{
    internal class ApplicationBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IApiResourceAppService, ApiResourceAppService>();
            services.AddScoped<IScopesAppService, ScopesAppService>();
            services.AddScoped<IIdentityResourcesAppService, IdentityResourcesAppService>();
            services.AddScoped<IApiResourceAppService, ApiResourceAppService>();
            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<IUserManageAppService, UserManagerAppService>();
            services.AddScoped<IClientAppService, ClientAppService>();

        }
    }
}
