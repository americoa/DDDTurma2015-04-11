using LGroup.ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Domain.Contracts.Services
{
    public interface IAgendamentoPagamentoDomainService
    {
        void Agendar(Pagamento pagamento, IEnumerable<DateTime> datas);
        void Agendar(Pagamento pagamento, short vezes);
    }
}
