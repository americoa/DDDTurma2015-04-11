using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.ControleFinanceiro.Domain.Contracts.Repositories;
using LGroup.ControleFinanceiro.Infra.Data.Contexts;

namespace LGroup.ControleFinanceiro.Infra.Data.Repositories
{
    public sealed class CreditoRepository
        : ICreditoRepository
    {
        private readonly ControleFinanceiroContext _controleFinanceiroContext;

        public CreditoRepository(ControleFinanceiroContext controleFinanceiroContext)
        {
            _controleFinanceiroContext = controleFinanceiroContext;
        }

        public Domain.Entities.Credito GetByCodigo(int codigo)
        {
            return
                _controleFinanceiroContext
                    .Creditos
                    .SingleOrDefault(x => x.Codigo == codigo);
        }
    }
}
