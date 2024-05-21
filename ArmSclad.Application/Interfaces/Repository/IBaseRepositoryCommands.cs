using ArmSclad.Core.Entities;

namespace ArmSclad.Domain.Interfaces.Repository
{
    public interface IBaseRepositoryCommands<T> where T : BaseEntity
    {
        public void Update(T t);
        public void Delete(int id);
        public int Add(T t);
    }
}
