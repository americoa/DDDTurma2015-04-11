using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleInjector;
using LGroup.ControleFinanceiro.Infra.CrossCutting.IoC.Containers;

using Microsoft.Practices.ServiceLocation;
using CommonServiceLocator.SimpleInjectorAdapter;

namespace LGroup.ControleFinanceiro.Infra.CrossCutting.IoC
{
    public static class Startup
    {
        public static void Register(Container container, Lifestyle lifeStyleDbContext)
        {
            //Containers.ApplicationServiceContainer.RegisterApplicationService(container);
            container.RegisterApplicationServices();
            container.RegisterDomainServices();
            container.RegisterRepositories();
            
            container.RegisterDbContexts(lifeStyleDbContext);
            
            ServiceLocatorConfig(container);
        }

        private static void ServiceLocatorConfig(Container container)
        {
            ServiceLocator.SetLocatorProvider(
                () => new SimpleInjectorServiceLocatorAdapter(container));
        }
    }
}
