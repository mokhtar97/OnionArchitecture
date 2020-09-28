using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.EntityMapping
{
    class CategoryMapping
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(d => d.ID);

            builder.Property(d => d.CatName)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(150)");
        }
    }
}
