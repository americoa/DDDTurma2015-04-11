using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleInjector;
using LGroup.ControleFinanceiro.Application.Contracts;
using LGroup.ControleFinanceiro.Application.Services;

namespace LGroup.ControleFinanceiro.Infra.CrossCutting.IoC.Containers
{
    internal static class ApplicationServiceContainer
    {
        public static void RegisterApplicationServices(this Container container)
        {
            container
                .Register
                <IRecebimentoApplicationService,
                 RecebimentoApplicationService>();
        }
    }
}
