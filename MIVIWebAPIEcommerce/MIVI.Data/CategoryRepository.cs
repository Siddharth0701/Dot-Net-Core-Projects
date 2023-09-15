using Microsoft.EntityFrameworkCore;
using MIVI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MIVI.Data
{
   public  class CategoryRepository
    {
        ApplicationDbContext context = null;
        public CategoryRepository(ApplicationDbContext context)
        {
            this.context = context;

        }
        public IEnumerable<Category> GetAllCategory()
        {
            return context.Category.ToList();
        }
        public void AddCategory(Category c)
        {
            context.Category.Add(c);
            context.SaveChanges();
        }
        public void UpdateCategory(Category c)
        {
            context.Entry<Category>(c).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteCategory(int id)
        {
            Category s = context.Category.Find(id);
            context.Category.Remove(s);
            context.SaveChanges();
        }
    }
}
