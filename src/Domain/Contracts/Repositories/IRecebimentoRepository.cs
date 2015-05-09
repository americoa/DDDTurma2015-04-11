using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Utilizamos para trazer o IEnumerable<>
using System.Collections.Generic;

using LGroup.ControleFinanceiro.Domain.Entities;

namespace LGroup.ControleFinanceiro.Domain.Contracts.Repositories
{
    public interface IRecebimentoRepository
    {
        IEnumerable<Recebimento> GetAll();
        void Add(Recebimento recebimento);
    }
}
