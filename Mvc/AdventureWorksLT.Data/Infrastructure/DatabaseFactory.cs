using AdventureWorksLT.Data.Data;

namespace AdventureWorksLT.Data.Infrastructure
{
    public interface IDatabaseFactory
    {
        AdventureWorksLTEntities Context { get; }
    }
    public class DatabaseFactory : IDatabaseFactory
    {
        private AdventureWorksLTEntities _dataContext;
        public AdventureWorksLTEntities Context
        {
            get { return _dataContext ?? (_dataContext = new AdventureWorksLTEntities()); }
        }
    }
}
