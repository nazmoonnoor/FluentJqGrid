namespace AdventureWorksLT.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory _databaseFactory;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this._databaseFactory = databaseFactory;
        }

        public void Commit()
        {
            _databaseFactory.Context.SaveChanges();
        }
    }
}
