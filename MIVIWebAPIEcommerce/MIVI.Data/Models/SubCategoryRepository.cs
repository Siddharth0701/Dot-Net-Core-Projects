using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MIVI.Data.Models
{
   public class  SubCategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public SubCategoryRepository(ApplicationDbContext db)
        {
            this._db = db;
                
        }
        public IEnumerable<SubCategory> GetAllSubCategories()
        {
            return _db.SubCategory.ToList();
        }
        public void AddSubCategory(SubCategory subCategory)
        {
            _db.SubCategory.Add(subCategory);
            _db.SaveChangesAsync();
        }
        public void UpdateSubCategory(SubCategory subCategory)
        {
            _db.Entry<SubCategory>(subCategory).State = EntityState.Modified;
            _db.SaveChanges();
        }
        public void DeleteCategory(int id)
        {
            SubCategory s = _db.SubCategory.Find(id);
            _db.SubCategory.Remove(s);
            _db.SaveChanges();
        }
    }
}
