using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using do ServiceLocator
using Microsoft.Practices.ServiceLocation;

namespace LGroup.ControleFinanceiro.Infra.Data.UnitsOfWork
{
    public sealed class ControleFinanceiroContextUnitOfWork
        : Domain.Contracts.UnitsOfWork.IControleFinanceiroContextUnitOfWork
    {
        private Contexts.ControleFinanceiroContext _context;

        //Forma tradicional via injeção de dependência
        //public ControleFinanceiroContextUnitOfWork(
        //    Contexts.ControleFinanceiroContext context)
        //{
        //    _context = context;
        //}

        public void Begin()
        {
            //Injeção via ServiceLocator
            //O Service Locator é um componente da Microsoft,
            // onde armazenamos as intâncias. É parecido com o IoC.
            _context = 
                ServiceLocator.Current
                .GetInstance<Contexts.ControleFinanceiroContext>();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
