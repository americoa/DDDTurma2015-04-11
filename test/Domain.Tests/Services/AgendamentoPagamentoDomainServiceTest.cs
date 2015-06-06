using LGroup.ControleFinanceiro.Domain.Contracts.Repositories;
using LGroup.ControleFinanceiro.Domain.Contracts.Services;
using LGroup.ControleFinanceiro.Domain.Entities;
using LGroup.ControleFinanceiro.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Domain.Tests.Services
{
    [TestClass]
    public sealed class AgendamentoPagamentoDomainServiceTest
    {
        private IAgendamentoPagamentoDomainService
            _agendamentoPagamentoDomainService;

        //Transformamos a nossa variável em uma váriavel "mocada"
        private Mock<IPagamentoRepository>
            _pagamentoRepository;

        [TestInitialize]
        public void Initialize()
        {
            _pagamentoRepository = new Mock<IPagamentoRepository>();
        }

        [TestMethod]
        public void QuandoEuAgendarUmPagamentoPorDatas()
        {
            //arrange
            _agendamentoPagamentoDomainService =
                new AgendamentoPagamentoDomainService(_pagamentoRepository.Object);

            Pagamento pagamento =
                new Pagamento("Aluguel",
                    new DateTime(2015, 6, 8),
                    new DateTime(2015, 6, 8));

            IList<DateTime> datas =
                new List<DateTime>
                {
                    new DateTime(2015, 6, 8),
                    new DateTime(2015, 7, 8),
                    new DateTime(2015, 8, 10)
                };

            //act
            _agendamentoPagamentoDomainService
                .Agendar(pagamento, datas);

            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuAgendarUmPagamentoPorDatasNoFinalDeSemanaGerarException()
        {
            //arrange
            _agendamentoPagamentoDomainService =
                new AgendamentoPagamentoDomainService(_pagamentoRepository.Object);

            Pagamento pagamento =
                new Pagamento("Aluguel",
                    new DateTime(2015, 6, 8),
                    new DateTime(2015, 6, 8));

            IList<DateTime> datas =
                new List<DateTime>
                {
                    new DateTime(2015, 6, 6),
                    new DateTime(2015, 7, 8),
                    new DateTime(2015, 8, 10)
                };

            //act
            _agendamentoPagamentoDomainService
                .Agendar(pagamento, datas);

            //assert
        }

        [TestMethod]
        public void QuandoEuAgendarUmPagamentoPorVezes()
        {
            //arrange
            _agendamentoPagamentoDomainService = new
                AgendamentoPagamentoDomainService(_pagamentoRepository.Object);

            Pagamento pagamento =
                new Pagamento("Aluguel", DateTime.Now, new DateTime(2015, 6, 8));

            //act
            _agendamentoPagamentoDomainService
                .Agendar(pagamento, 12);

            //assert
        }
    }
}
