using System;
using System.Linq;
using System.Web.Mvc;

namespace FluentJqGrid.Mvc4.Demo.Infrastructure.Ninject
{
    public class ConfigureContainer
    {
        public ConfigureContainer()
        {
            var modules = typeof(ConfigureContainer).Assembly
                .GetExportedTypes()
                .Where(t =>
                       t.IsClass && !t.IsAbstract
                       && typeof(INinjectModule).IsAssignableFrom(t))
                .Where(t =>
                       t.GetConstructors().Any(ctor => !ctor.GetParameters().Any()))
                .Select(t => (INinjectModule)Activator.CreateInstance(t))
                .ToArray();

            var container = new StandardKernel(modules);
            var resolver = new NinjectDependencyResolver(container);

            DependencyResolver.SetResolver(resolver);
        }
    }
}