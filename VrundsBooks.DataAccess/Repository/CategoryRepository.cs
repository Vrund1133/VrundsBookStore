using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VrundsBooks.DataAccess.Repository.IRepository;
using VrundsBooks.Models;
using VrundsBookStore.DataAccess.Data;

namespace VrundsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(Category category)
        {
            var objFormDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFormDb != null)
            {
                objFormDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
