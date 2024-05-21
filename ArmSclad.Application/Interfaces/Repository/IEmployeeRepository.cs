using ArmSclad.Core.Entities;

namespace ArmSclad.Domain.Interfaces.Repository
{
    public interface IEmployeeRepository
    {
        List<EmployeeEntity> GetByStorage(int storageId, int from = 0, int to = 10);
    }
}
