using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.ControleFinanceiro.Application.Dtos;

namespace LGroup.ControleFinanceiro.Application.Contracts
{
    public interface IRecebimentoApplicationService
    {
        IEnumerable<RecebimentoDto> Consultar();
        void Adicionar(RecebimentoDto recebimento);
    }
}
