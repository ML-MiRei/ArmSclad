using ArmSclad.Domain.Interfaces.Services.AuthorizationService;
using ArmSclad.Core.Entities;
using ArmSclad.Core.Enums;
using ArmSclad.Core.Exceptions;
using ArmSclad.Infrastructure.Database.Context;
using ArmSclad.Infrastructure.Database.Model;

namespace ArmSclad.Infrastructure.Implementations.Services
{
    public class AuthorizationService(DatabaseSingleton db) : IAuthorizationService
    {
        public EmployeeEntity Authorize(string email, string password)
        {
            var t = db.DbContext.Employees.Count();
            var employee = db.DbContext.Employees.FirstOrDefault(emp => emp.IsActive && emp.Email == email);
            if (employee == null)
                throw new EmailNotExistException();
            if (employee.Password != password)
                throw new AuthorizeException();
            return new EmployeeEntity
            {
                FirstName = employee.FirstName,
                SecondName = employee.SecondName,
                LastName = employee.LastName,
                Email = email,
                Password = password,
                Phone = employee.Phone,
                Id = employee.Id,
                Position = db.DbContext.EmployeePositions.Find(employee.Position).Name,
                Role = (EmployeeRoleEnum)employee.Role,
                StorageId = employee.StorageId
            };

        }

        public void DeleteAccount(int id)
        {
            Employee employee = db.DbContext.Employees.Find(id);
            if (employee == null)
                throw new NotFoundException();
            db.DbContext.Employees.Remove(employee);
            db.DbContext.SaveChanges();
        }

        public EmployeeEntity Registrate(EmployeeEntity employeeEntity)
        {
            var isEmployee = db.DbContext.Employees.FirstOrDefault(emp => emp.Email == employeeEntity.Email);

            if (isEmployee != null)
                throw new EmailExistException();

            Employee employee = new Employee
            {
                FirstName = employeeEntity.FirstName,
                SecondName = employeeEntity.SecondName,
                LastName = employeeEntity.LastName,
                Email = employeeEntity.Email,
                Password = employeeEntity.Password,
                Phone = employeeEntity.Phone,
                Role = (int)employeeEntity.Role,
                StorageId = employeeEntity.StorageId
            };

            EmployeePosition employeePosition = db.DbContext.EmployeePositions.FirstOrDefault(ep => ep.Name == employeeEntity.Position);
            if (employeePosition == null)
            {
                employeePosition = new EmployeePosition { Name = employeeEntity.Position };
                db.DbContext.EmployeePositions.Add(employeePosition);
                db.DbContext.SaveChanges();
            }

            employee.Position = employeePosition.Id;
            db.DbContext.Employees.Add(employee);
            db.DbContext.SaveChanges();

            employeeEntity.Id = employee.Id;
            return employeeEntity;
        }
    }
}
