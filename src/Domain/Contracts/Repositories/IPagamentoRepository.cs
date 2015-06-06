using LGroup.ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Domain.Contracts.Repositories
{
    public interface IPagamentoRepository
    {
        void Add(Pagamento pagamento);
    }
}
