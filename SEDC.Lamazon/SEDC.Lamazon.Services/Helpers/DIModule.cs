﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SEDC.Lamazon.DataAccess;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.DataAccess.Repositories;
using SEDC.Lamazon.Domain.Models;

namespace SEDC.Lamazon.Services.Helpers
{
    public static class DIModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<LamazonDbContext>(options =>
                                                    options.UseSqlServer(connectionString));



            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<Product>, ProductRepository>();



            return services;
        }
    }
}
