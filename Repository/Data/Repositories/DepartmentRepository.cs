using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Repository.Data.Entities;
using Repository.Data.Interfaces;

namespace Repository.Data.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(CompanyDbContext DbContext) : base(DbContext)
        {
        }

        public int GetHeadcount()
        {
            throw new NotImplementedException();
        }
    }
}