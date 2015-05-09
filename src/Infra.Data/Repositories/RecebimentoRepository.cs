using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.ControleFinanceiro.Domain.Contracts.Repositories;
using LGroup.ControleFinanceiro.Domain.Entities;
using LGroup.ControleFinanceiro.Infra.Data.Contexts;

namespace LGroup.ControleFinanceiro.Infra.Data.Repositories
{
    public sealed class RecebimentoRepository
        : IRecebimentoRepository
    {
        private readonly ControleFinanceiroContext _controleFinanceiroContext;
        
        public RecebimentoRepository(ControleFinanceiroContext controleFinanceiroContext)
        {
            _controleFinanceiroContext = controleFinanceiroContext;
        }

        public IEnumerable<Recebimento> GetAll()
        {
            return _controleFinanceiroContext.Recebimentos.ToList();
        }

        public void Add(Recebimento recebimento)
        {
            _controleFinanceiroContext.Recebimentos.Add(recebimento);
            _controleFinanceiroContext.SaveChanges();
        }
    }
}
