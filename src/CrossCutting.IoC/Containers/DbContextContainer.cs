using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleInjector;
using LGroup.ControleFinanceiro.Infra.Data.Contexts;

using LGroup.ControleFinanceiro.Domain.Contracts.UnitsOfWork;
using LGroup.ControleFinanceiro.Infra.Data.UnitsOfWork;

namespace LGroup.ControleFinanceiro.Infra.CrossCutting.IoC.Containers
{
    internal static class DbContextContainer
    {
        public static void RegisterDbContexts(this Container container, Lifestyle lifeStyle)
        {
            container.Register<IControleFinanceiroContextUnitOfWork, ControleFinanceiroContextUnitOfWork>();
            container.Register<ControleFinanceiroContext>(lifeStyle);
        }
    }
}
