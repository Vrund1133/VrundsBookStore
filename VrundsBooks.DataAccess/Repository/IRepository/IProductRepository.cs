using System;
using System.Collections.Generic;
using System.Text;
using VrundsBooks.Models;

namespace VrundsBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
