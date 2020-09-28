using DomainLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.EntityMapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Context
{
  public class ApplicationDbContext:IdentityDbContext
    {
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(new ProductMapping().Configure);

            modelBuilder.Entity<Category>(new CategoryMapping().Configure);

            modelBuilder.Entity<Product>().HasOne<Category>().WithMany(c => c.Products).HasForeignKey(p => p.Category_ID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
