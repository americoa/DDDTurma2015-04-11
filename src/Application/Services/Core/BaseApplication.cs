using LGroup.ControleFinanceiro.Domain.Contracts.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.ServiceLocation;

namespace LGroup.ControleFinanceiro.Application.Services.Core
{
    public abstract class BaseApplication
    {
        private readonly IControleFinanceiroContextUnitOfWork _controleFinanceiroContextUnitOfWork;

        //Injeção por construtor
        public BaseApplication(
            IControleFinanceiroContextUnitOfWork controleFinanceiroContextUnitOfWork)
        {
            _controleFinanceiroContextUnitOfWork = controleFinanceiroContextUnitOfWork;
        }

        //Injeção por ServiceLocator
        public BaseApplication()
        {
            _controleFinanceiroContextUnitOfWork =
                ServiceLocator.Current
                .GetInstance<IControleFinanceiroContextUnitOfWork>();
        }

        public void Begin()
        {
            _controleFinanceiroContextUnitOfWork.Begin();
        }

        public void SaveChanges()
        {
            _controleFinanceiroContextUnitOfWork.SaveChanges();
        }
    }
}
