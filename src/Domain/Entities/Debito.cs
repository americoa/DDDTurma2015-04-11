using BM.Validations;
using LGroup.ControleFinanceiro.Domain.ValueObjects;
using LGroup.ControleFinanceiro.Infra.Common.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Domain.Entities
{
    public sealed class Debito
    {
        public Debito(Tipo tipo, Pagamento pagamento)
        {
            ValidatorHelper.GarantirNaoNulo(pagamento, Mensagens.PagamentoDebitoInvalido);
            
            Tipo = tipo;
            Pagamento = pagamento;
        }

        public Tipo Tipo { get; private set; }
        public Pagamento Pagamento { get; private set; }
    }
}
