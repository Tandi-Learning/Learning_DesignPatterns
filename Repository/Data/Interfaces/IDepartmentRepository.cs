using Repository.Data.Entities;

namespace Repository.Data.Interfaces
{
    public interface IDepartmentRepository : IBaseRepository<Department>
    {
        int GetHeadcount();
    }
}