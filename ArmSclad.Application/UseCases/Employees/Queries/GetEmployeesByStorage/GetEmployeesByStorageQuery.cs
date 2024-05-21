using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Employees.Queries.GetEmployeesByStorage
{
    public class GetEmployeesByStorageQuery : IRequest<List<EmployeeEntity>>
    {
        public int StorageId { get; set; }
        public int From { get; set; } = 0;
        public int To { get; set; } = 10;
    }
}
