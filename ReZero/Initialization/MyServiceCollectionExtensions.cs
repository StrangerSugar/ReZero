﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;  
using System;
using System.Runtime.CompilerServices;

namespace ReZero
{
    /// <summary>
    /// Extension methods for configuring ReZero services in IServiceCollection.
    /// </summary>
    public static class MyServiceCollectionExtensions
    {
        /// <summary>
        /// Adds ReZero services to the specified IServiceCollection.
        /// </summary>
        /// <param name="services">The IServiceCollection to which ReZero services are added.</param>
        /// <param name="options">Optional ReZero options.</param>
        /// <returns>The updated IServiceCollection.</returns>
        public static IServiceCollection ReZero(this IServiceCollection services, ReZeroOptions? options = null)
        {
            // If options are not provided, create a new instance of ReZeroOptions.
            options = options ?? new ReZeroOptions();

            // Add services to the IServiceCollection.
            services.AddTransient<IDynamicApi, DynamicApi>();
            services.AddTransient<IReZeroApi, ReZeroApi>();
            services.AddTransient<IStartupFilter, RequestSetOptionsStartupFilter>();

            // Create an instance of ORM with the specified connection configuration and add it as a transient service.
            services.AddTransient<DatabaseReZeroContext>(it => new DatabaseReZeroContext(options.ConnectionConfig));

            InitDataBase(options);

            InitUser(options);

            InitReZeroApi(options);

            // Return the updated IServiceCollection.
            return services;
        }

        private static void InitUser(ReZeroOptions options)
        {
            new UserService().Init(options);
        }

        private static void InitReZeroApi(ReZeroOptions options)
        {
            new BuiltInApi().Init(options);
        }

        private static void InitDataBase(ReZeroOptions options)
        {
            if (options.InitTable == false) 
            {
                return;
            }
            var types=PubMethod.GetTypesDerivedFromDbBase(typeof(DbBase));
            var db = new DatabaseReZeroContext(options.ConnectionConfig).SugarClient;
            db.DbMaintenance.CreateDatabase();
            db.CodeFirst.InitTables(types?.ToArray());
        }
    }
}