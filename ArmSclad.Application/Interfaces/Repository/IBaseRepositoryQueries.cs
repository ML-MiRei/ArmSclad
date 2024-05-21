using ArmSclad.Core.Entities;

namespace ArmSclad.Domain.Interfaces.Repository
{
    public interface IBaseRepositoryQueries<T> where T : BaseEntity
    {
        public List<T> Get(int from = 0, int to = 10);
    }
}
