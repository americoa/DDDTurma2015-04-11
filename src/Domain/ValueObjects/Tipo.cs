using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Domain.ValueObjects
{
    //Enum: É uma enumeração com valores fixos.
    //Quando utilizar: Quando não existe uma frequência alta
    //                 de alteração daquela situação ou estratégia
    public enum Tipo
    {
        Fixo = 1,
        Esporadico = 2
    }
}
