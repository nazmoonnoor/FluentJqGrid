using AdventureWorksLT.Data.Infrastructure;
using AdventureWorksLT.Data.Repositories;

namespace FluentJqGrid.Mvc4.Demo.Infrastructure.Ninject
{
    public class ContainerModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDatabaseFactory>().To<DatabaseFactory>().InRequestScope();
            Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<SrcSamples>().ToSelf();
        }
    }
}