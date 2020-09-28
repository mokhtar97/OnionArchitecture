using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.EntityMapping
{
    class ProductMapping
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(d => d.ID);

            builder.Property(d => d.ProductName)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(150)");

        }
    }
}
