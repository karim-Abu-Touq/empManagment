using empManagment.Data;
using empManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace empManagment.Repositories
{
    public class EmployeeRepository:Repository<clsEmployee>, IEmployeeRepository
    {
        private readonly clsAppDBContext _dbcontext;

        public EmployeeRepository(clsAppDBContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public int CountSearchandFilter(string? search, int? departmentID, int? positionID)
        {
            var query = _dbcontext.Employees.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(e => e.FirstName.Contains(search) || e.LastName.Contains(search) || e.Email.Contains(search));
            }

            if (departmentID.HasValue)
            {
                query = query.Where(e => e.DepartmentID == departmentID.Value);
            }

            if (positionID.HasValue)
            {
                query = query.Where(e => e.PositionID == positionID.Value);
            }
            return query.Count();
        }

        public IEnumerable<clsEmployee> GetAllWithDepandPos()
        {
            return _dbcontext.Employees.Include(e => e.Department).Include(e => e.Position).ToList();
        }

        public clsEmployee? GetByIDWithDepandPos(int id)
        {
            return _dbcontext.Employees.Include(e=>e.Department).Include(e=>e.Position).FirstOrDefault(e=>e.EmpID==id);
        }

        public IEnumerable<clsEmployee> SearchandFilter(string? search, int? departmentID, int? positionID, int page, int pageSize)
        {
            var query=_dbcontext.Employees.Include(e=>e.Department).Include(e=>e.Position).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query=query.Where(e=>e.FirstName.Contains(search)||e.LastName.Contains(search)||e.Email.Contains(search));
            }

            if (departmentID.HasValue)
            {
                query=query.Where(e=>e.DepartmentID==departmentID.Value);
            }

            if(positionID.HasValue)
            {
                query=query.Where(e=>e.PositionID==positionID.Value);
            }
            return query.OrderBy(e => e.EmpID).Skip((page - 1) * pageSize).Take(pageSize).ToList();

        }
    }
}
