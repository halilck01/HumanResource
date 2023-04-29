﻿using HumanResource.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResource.Infrastructure.EntitiesConfig
{
    internal class AddressConfig : BaseEntityConfig<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnOrder(1);

            builder.Property(x => x.Description)
                .IsRequired(true)
                .IsUnicode(true)
                .HasColumnType("NVARCHAR(MAX)")
                .HasColumnOrder(2);

            builder.Property(x => x.PostCode)
                .IsRequired(false)
                .HasColumnOrder(3);

            builder.Property(x => x.DistrictId)
                .IsRequired(true)
                .HasColumnOrder(4);

            builder.Property(x => x.AppUserId)
                .IsRequired(true)
                .HasColumnOrder(5);

            //Foreign Key

            builder.HasOne(x => x.AppUser)
                .WithOne(x => x.Address)
                .HasForeignKey<AppUser>(x => x.AddressId)
                .HasPrincipalKey<Address>(x => x.AppUserId);

            base.Configure(builder);
        }
    }
}
