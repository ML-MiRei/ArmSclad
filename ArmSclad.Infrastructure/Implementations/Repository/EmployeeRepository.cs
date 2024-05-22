using ArmSclad.Domain.Interfaces.Repository;
using ArmSclad.Core.Entities;
using ArmSclad.Core.Enums;
using ArmSclad.Infrastructure.Database.Context;

namespace ArmSclad.Infrastructure.Implementations.Repository
{
    public class EmployeeRepository(DatabaseSingleton db) : IEmployeeRepository
    {
        public List<EmployeeEntity> GetByStorage(int storageId, int from = 0, int to = 10)
        {
            return db.DbContext.Employees.Where(e => e.IsActive && e.StorageId == storageId).Select(e => new EmployeeEntity
            {
                StorageId = storageId,
                Email = e.Email,
                Phone = e.Phone,
                FirstName = e.FirstName,
                SecondName = e.SecondName,
                LastName = e.LastName,
                Id = e.Id,
                Position = db.DbContext.EmployeePositions.Find(e.Position).Name,
                Role = (EmployeeRoleEnum)e.Role
            }).Skip(from).Take(to).ToList();
        }
    }
}
