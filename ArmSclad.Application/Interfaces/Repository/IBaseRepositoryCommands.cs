using ArmSclad.Core.Entities;

namespace ArmSclad.Domain.Interfaces.Repository
{
    public interface IBaseRepositoryCommands<T> where T : BaseEntity
    {
        public Task Update(T t);
        public Task Delete(int id);
        public Task<int> Add(T t);
    }
}
