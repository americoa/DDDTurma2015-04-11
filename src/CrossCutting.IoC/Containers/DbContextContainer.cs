using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleInjector;
using LGroup.ControleFinanceiro.Infra.Data.Contexts;

namespace LGroup.ControleFinanceiro.Infra.CrossCutting.IoC.Containers
{
    internal static class DbContextContainer
    {
        public static void RegisterDbContexts(this Container container)
        {
            container.Register<ControleFinanceiroContext>();
        }
    }
}
