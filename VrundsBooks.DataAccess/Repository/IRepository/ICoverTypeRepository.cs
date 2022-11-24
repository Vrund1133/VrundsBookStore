using System;
using System.Collections.Generic;
using System.Text;
using VrundsBooks.Models;

namespace VrundsBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
