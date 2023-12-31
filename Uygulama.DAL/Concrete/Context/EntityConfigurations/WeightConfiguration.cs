﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Core.Enums;
using Uygulama.Entities;

namespace Uygulama.DAL.Concrete.Context.EntityConfigurations
{
    /// <summary>
    /// Weight entity'sinin property'lerinin özelliklerinin belirlendiği metot.
    /// </summary>
    public class WeightConfiguration : BaseConfiguration<Weight>
    {
        public override void Configure(EntityTypeBuilder<Weight> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.UserWeight)
                .IsRequired();

            builder.Property(x => x.RecordDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.HasOne<User>(x => x.User)
                .WithMany(x => x.Weights)
                .HasForeignKey(x => x.UserId);

            builder.Property(x => x.UserId).IsRequired(false);
        }
    }
}
