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
    public class UserConfiguration : BaseConfiguration<User>
    {
        /// <summary>
        /// User entity'sinin property'lerinin özelliklerinin belirlendiği metot.
        /// </summary>
        /// <param name="builder"></param>
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Firstname)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Lastname)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Password)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(250)
                .IsRequired();

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.Property(x => x.BirthDate)
                .IsRequired();

            builder.Property(x => x.Role)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<Role>());

            builder.HasData(new User
            {
                Id = 1,
                Firstname = "Eren",
                Lastname = "Kartal",
                Password = "Ek1.",
                Email = "admin@gmail.com",
                BirthDate = DateTime.Parse("03/12/1992"),
                Role = Role.Admin,
                CreatedDate = DateTime.Now,
                State = State.Created
            });
            builder.HasData(new User
            {
                Id = 2,
                Firstname = "Pelin",
                Lastname = "Uru",
                Password = "1234",
                Email = "pelin@gmail.com",
                BirthDate = DateTime.Parse("11/06/1999"),
                Role = Role.StandartUser,
                CreatedDate = DateTime.Now,
                State = State.Created
            });

        }
    }
}
