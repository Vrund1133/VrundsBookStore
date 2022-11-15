using System;
using System.Collections.Generic;
using System.Text;
using VrundsBooks.Models;

namespace VrundsBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void update(Category category);
    }
}
