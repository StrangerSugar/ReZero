﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ReZero
{
 
    /// <summary>
    /// 应用程序的主要类，用于管理依赖注入和服务定位。
    /// </summary>
    public class ApplicationServiceProvider
    {
        private readonly IApplicationBuilder _app;

        /// <summary>
        /// 构造函数，接受一个 <see cref="IServiceProvider"/> 实例。
        /// </summary>
        /// <param name="serviceProvider">依赖注入容器。</param>
        public ApplicationServiceProvider(IApplicationBuilder serviceProvider)
        {
            _app = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        /// <summary>
        /// 获取指定类型的服务实例。
        /// </summary>
        /// <typeparam name="T">要获取的服务类型。</typeparam>
        /// <returns>指定类型的服务实例。</returns>
        public T GetService<T>()
        {
            // 获取IOC容器（服务提供程序）
            var serviceProvider = _app.ApplicationServices;

            // 使用IOC容器执行操作
#pragma warning disable CS8714 // 类型不能用作泛型类型或方法中的类型参数。类型参数的为 Null 性与 "notnull" 约束不匹配。
            var myService = serviceProvider.GetRequiredService<T>();
#pragma warning restore CS8714 // 类型不能用作泛型类型或方法中的类型参数。类型参数的为 Null 性与 "notnull" 约束不匹配。
            return myService;
        }
    }
}