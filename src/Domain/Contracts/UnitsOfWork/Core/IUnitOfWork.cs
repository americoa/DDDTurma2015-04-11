using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Domain.Contracts.UnitsOfWork.Core
{
    public interface IUnitOfWork
    {
        void Begin();
        void SaveChanges();
    }
}
