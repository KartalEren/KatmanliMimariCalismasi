﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.DAL.Concrete.Context.EntityConfigurations;
using Uygulama.Entities;

namespace Uygulama.DAL.Concrete.Context
{
    public class VeganFitDbContext:DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Data> Datas { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Weight> Weights { get; set; }




        /// <summary>
        /// Database bağlantı ayarlarının yapılmasını sağlayan metot.
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sql = @"Server=DESKTOP-6EM38CB\SQL2022;Database=VeganFitDB;Trusted_Connection = True";
            optionsBuilder.UseSqlServer(sql);  //SQL BAĞLANTI YOLU!!!
        }


        /// <summary>
        /// Database'de oluşturulacak tabloların ayarlarının yapılmasını sağlayan metot.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration())
                        .ApplyConfiguration(new ProductConfiguration())
                        .ApplyConfiguration(new DataConfiguration())
                        .ApplyConfiguration(new FeedbackConfiguration())
                        .ApplyConfiguration(new WeightConfiguration());
        }












    }
}
