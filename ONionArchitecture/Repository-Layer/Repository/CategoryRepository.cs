using DomainLayer.Entities;
using DomainLayer.Interfaces;
using RepositoryLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Repository
{
    class CategoryRepository:IRepository<Category>,ICategoryRepository
    {
        private readonly ApplicationDbContext context;

        public CategoryRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void ADD(Category Model)
        {
            context.Categories.Add(Model);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Categories.Remove(Find(id));
            context.SaveChanges();
        }

        public Category Find(int? id)
        {
            return context.Categories.FirstOrDefault(c=>c.ID==id);
        }

        public List<Category> List()
        {
           return context.Categories.ToList();
        }

        public void Update(int id, Category Model)
        {
            context.Entry(Model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
