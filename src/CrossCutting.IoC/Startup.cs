using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleInjector;
using LGroup.ControleFinanceiro.Infra.CrossCutting.IoC.Containers;

namespace LGroup.ControleFinanceiro.Infra.CrossCutting.IoC
{
    public static class Startup
    {
        public static void Register(Container container)
        {
            //Containers.ApplicationServiceContainer.RegisterApplicationService(container);
            container.RegisterApplicationServices();
            container.RegisterDomainServices();
            container.RegisterRepositories();
            container.RegisterDbContexts();
        }
    }
}
