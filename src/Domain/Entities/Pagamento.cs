using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importamos esse namespace para trabalharmos com
// o ValidatorHelper
using BM.Validations;
using LGroup.ControleFinanceiro.Infra.Common.Resources;

namespace LGroup.ControleFinanceiro.Domain.Entities
{
    public sealed class Pagamento : Core.BaseEntity
    {
        public Pagamento(string descricao, DateTime data, DateTime dataVencimento)
        {
            ValidatorHelper.GarantirValorPreenchido(descricao, Mensagens.DescricaoPagamentoInvalida);
            ValidatorHelper.GarantirFalso(data == default(DateTime), Mensagens.DataPagamentoInvalida);
            ValidatorHelper.GarantirFalso(dataVencimento == default(DateTime), Mensagens.DataVencimentoPagamentoInvalida);

            Descricao = descricao;
            Data = data;
            DataVencimento = dataVencimento;
        }

        public string Descricao { get; private set; }
        public DateTime Data { get; private set; }
        public DateTime DataVencimento { get; private set; }
    }
}
