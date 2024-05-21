using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Employees.Queries.GetEmployeesByStorage
{
    internal class GetEmployeesByStorageHandler(IEmployeeRepository employeeRepository) : IRequestHandler<GetEmployeesByStorageQuery, List<EmployeeEntity>>
    {
        public Task<List<EmployeeEntity>> Handle(GetEmployeesByStorageQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => employeeRepository.GetByStorage(request.StorageId, request.From, request.To));
        }
    }
}
