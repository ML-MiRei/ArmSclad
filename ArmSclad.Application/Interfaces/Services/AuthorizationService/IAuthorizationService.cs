using ArmSclad.Core.Entities;

namespace ArmSclad.Domain.Interfaces.Services.AuthorizationService
{
    public interface IAuthorizationService
    {
        public EmployeeEntity Authorize(string email, string password);
        public EmployeeEntity Registrate(EmployeeEntity employeeEntity);
        public void DeleteAccount(int id);
    }
}
