using DomainLayer.Entities;
using DomainLayer.Interfaces;
using RepositoryLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Repository
{
   public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext context;

        public ProductRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void ADD(Product Model)
        {
            context.Products.Add(Model);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Products.Remove(Find(id));
            context.SaveChanges();
        }

        public Product Find(int? id)
        {
            return context.Products.FirstOrDefault(c => c.ID == id);
        }

        public List<Product> List()
        {
            return context.Products.ToList();
        }

        public void Update(int id, Product Model)
        {
            context.Entry(Model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
