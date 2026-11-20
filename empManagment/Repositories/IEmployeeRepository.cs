using empManagment.Models;

namespace empManagment.Repositories
{
    public interface IEmployeeRepository:IRepository<clsEmployee>
    {
        IEnumerable<clsEmployee> GetAllWithDepandPos();

        clsEmployee? GetByIDWithDepandPos(int id);

        IEnumerable<clsEmployee> SearchandFilter(string?search,int?departmentID,int?positionID,int page,int pageSize);

        int CountSearchandFilter(string? search, int? departmentID, int? positionID);
    }
}
