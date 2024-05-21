namespace ArmSclad.Infrastructure.Database.Context
{
    public class DatabaseSingleton
    {
        private MyDbContext _dbContext = new MyDbContext();
        public MyDbContext DbContext => _dbContext;

    }
}
