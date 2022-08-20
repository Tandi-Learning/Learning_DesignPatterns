using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Repository.Data.Entities;
using Repository.Data.Interfaces;
using Repository.Data.Repositories;

namespace Repository.Data.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(CompanyDbContext dbContext) : 
            base(dbContext)
        {
        }

        public int GetHeadcount()
        {
            throw new NotImplementedException();
        }
    }
}