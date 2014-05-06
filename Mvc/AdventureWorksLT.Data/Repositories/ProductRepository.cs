
using AdventureWorksLT.Data.Data;
using AdventureWorksLT.Data.Infrastructure;

namespace AdventureWorksLT.Data.Repositories
{
    public class ProductRepository: Repository<Product>, IProductRepository
    {
        private readonly IDatabaseFactory _databaseFactory;

        public ProductRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
            _databaseFactory = databaseFactory;
        }

        public virtual PagedList<Product> All(int pageIndex, int pageSize)
        {
            return new PagedList<Product>(Table, pageIndex, pageSize);
        }
    }

    public interface IProductRepository : IRepository<Product>
    {
        PagedList<Product> All(int pageIndex, int pageSize);
    }
}