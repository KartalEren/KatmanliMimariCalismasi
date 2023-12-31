﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.DAL.Abstract;
using Uygulama.DAL.Concrete.Context;
using Uygulama.DAL.Concrete.Repositories;

namespace Uygulama.DAL.Concrete
{
    public static class EFContextDal
    {
        /// <summary>
        /// UserRepo, ProductRepo, OptionalProductRepo, FeedbackRepo, WeightRepo ve DataRepo için dependency injection yapısını kullanmamızı sağlan metot. (Bu repo'lar bu metot sayesinde parametre olarak çağrıldığı zaman new'lenmeden kullanılabilir.)
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>

        public static IServiceCollection AddScopeDal(this IServiceCollection services)
        {
            services.AddDbContext<VeganFitDbContext>()
                    .AddScoped<IUserRepo, UserRepo>()
                    .AddScoped<IProductRepo, ProductRepo>()
                    .AddScoped<IDataRepo, DataRepo>()
                    .AddScoped<IWeightRepo, WeightRepo>()
                    .AddScoped<IFeedBackRepo, FeedBackRepo>();
                    //AddScoped => Interface ile class'ları birbirine bağlar.
            return services;
        }

    }
}
