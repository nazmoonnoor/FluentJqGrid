using AdventureWorksLT.Data.Infrastructure;
using AdventureWorksLT.Data.Repositories;
using FluentJqGrid.Mvc4.Demo.Common;
using SimpleInjector;
using SimpleInjector.Extensions;

namespace FluentJqGrid.Mvc4.Demo.Infrastructure.SimpleInjector
{
    public class RegisterServices
    {
        public static void Config(Container container)
        {
            container.RegisterPerWebRequest<IDatabaseFactory,DatabaseFactory>();
            container.RegisterOpenGeneric(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterPerWebRequest<IUnitOfWork, UnitOfWork>();
            container.Register<IProductRepository, ProductRepository>();
            container.Register(()=>new SrcSamples());
        }
    }
}