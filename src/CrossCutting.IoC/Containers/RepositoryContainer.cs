using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleInjector;
//Interfaces
using LGroup.ControleFinanceiro.Domain.Contracts.Repositories;
//Concretas
using LGroup.ControleFinanceiro.Infra.Data.Repositories;

namespace LGroup.ControleFinanceiro.Infra.CrossCutting.IoC.Containers
{
    internal static class RepositoryContainer
    {
        public static void RegisterRepositories(this Container container)
        {
            container
                .Register<ICreditoRepository, CreditoRepository>();
            container
                .Register<IRecebimentoRepository, RecebimentoRepository>();
        }
    }
}
