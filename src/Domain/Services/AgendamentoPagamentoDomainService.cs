using LGroup.ControleFinanceiro.Domain.Contracts.Repositories;
using LGroup.ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BM.Validations;
using LGroup.ControleFinanceiro.Infra.Common.Resources;

namespace LGroup.ControleFinanceiro.Domain.Services
{
    public sealed class AgendamentoPagamentoDomainService
        : Contracts.Services.IAgendamentoPagamentoDomainService
    {
        private readonly IPagamentoRepository _pagamentoRepository;

        public AgendamentoPagamentoDomainService(
            IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }

        private static void ValidarPagamento(Pagamento pagamento)
        {
            //Valida o pagamento
            ValidatorHelper.GarantirNaoNulo(pagamento, Mensagens.PagamentoInvalido);
        }

        public void Agendar(Pagamento pagamento, IEnumerable<DateTime> datas)
        {
            ValidarPagamento(pagamento);

            //Valida se tem data para o agendamento
            ValidatorHelper.GarantirMaiorQue(datas.Count(), 0, Mensagens.DatasNaoInformadasNoAgendamento);

            //Valida se não tem data de sábado ou domingo
            ValidatorHelper.GarantirFalso(datas.Any(
                    x => x.DayOfWeek == DayOfWeek.Saturday
                    || x.DayOfWeek == DayOfWeek.Sunday),
                    Mensagens.AgendamentoSabadoDomingoInvalido);

            foreach (var dataVencimento in datas)
            {
                _pagamentoRepository
                    .Add(
                    new Pagamento(
                        pagamento.Descricao,
                        pagamento.Data,
                        dataVencimento));
            }
        }

        public void Agendar(Pagamento pagamento, short vezes)
        {
            ValidarPagamento(pagamento);

            //Criamos uma lista de vencimentos
            var vencimentos = new List<DateTime>();

            //Adicionamos a primeira data
            vencimentos.Add(pagamento.DataVencimento);

            for (int i = 0; i < vezes - 1; i++)
            {
                //Adicionamos um mês de acordo com a quantidade de vezes
                //Adicionamos o +1, pois já adicionamos a primeira data 
                var proximoVencimento = pagamento.DataVencimento.AddMonths(i + 1);

                //Enquanto a data cair em um final de semana, adicionar mais um dia
                while (proximoVencimento.DayOfWeek == DayOfWeek.Saturday
                    || proximoVencimento.DayOfWeek == DayOfWeek.Sunday)
                {
                    proximoVencimento = proximoVencimento.AddDays(1);
                }

                //Adicionamos na nossa lista de vencimentos
                vencimentos.Add(proximoVencimento);
            }

            //Reutilizamos o nosso método para fazer os agendamentos
            Agendar(pagamento, vencimentos);
        }
    }
}
