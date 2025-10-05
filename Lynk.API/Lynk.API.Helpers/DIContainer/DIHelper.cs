﻿using Lynk.API.DataAccess.Repositories.Abstractions;
using Lynk.API.DataAccess.Repositories.Implementations;
using Lynk.API.Services.Abstractions;
using Lynk.API.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Lynk.API.Helpers.DIContainer
{
    public class DIHelper
    {
        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }

        public static void InjectServices(IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
