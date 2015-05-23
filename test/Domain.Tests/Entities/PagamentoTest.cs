using LGroup.ControleFinanceiro.Domain.Entities;
using LGroup.ControleFinanceiro.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Domain.Tests.Entities
{
    [TestClass]
    public sealed class PagamentoTest
    {
        private string _descricao;
        private DateTime _dataPagamento;
        private DateTime _dataVencimento;
        private Pagamento _pagamento;

        private void Instanciar()
        {
            _pagamento = 
                new Pagamento(_descricao, _dataPagamento, _dataVencimento);
        }

        //O TestInitialize serve para inicializar os objetos antes de cada teste,
        // ou seja, para cada teste, vai ser chamado esse método
        [TestInitialize]
        public void Initialize()
        {
            _pagamento = null;
            _descricao = "Aluguel";
            _dataPagamento = DateTime.Now.AddDays(1);
            _dataVencimento = DateTime.Now.AddDays(5);
        }

        [TestMethod]
        public void QuandoEuCriarUmPagamento()
        {
            //arrange

            //act
            Instanciar();

            //assert
            Assert.IsNotNull(_pagamento);
            Assert.AreEqual(_pagamento.Descricao, _descricao);
            Assert.AreEqual(_pagamento.Data, _dataPagamento);
            Assert.AreEqual(_pagamento.DataVencimento, _dataVencimento);
            Assert.IsNotNull(_pagamento.Codigo); //Identidade do Pagamento
        }

        [TestMethod]
        //O ExpectedException fala para o método que o ASSERT (garantira)
        // se torna uma exceção, ou seja, para que o teste esteja ok, 
        // é necessário estourar uma exceção (um erro).
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmPagamentoADescricaoDeveSerObrigatoria()
        {
            //arrange
            _descricao = string.Empty;
            Pagamento pagamento;

            //act
            pagamento = new Pagamento(_descricao, _dataPagamento, _dataVencimento);

            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmPagamentoADataDeveSerObrigatoria()
        {
            //arrange
            _dataPagamento = default(DateTime);

            //act
            Instanciar();

            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmPagamentoADataVencimentoDeveSerObrigatoria()
        {
            //arrange
            _dataVencimento = default(DateTime);

            //act
            Instanciar();

            //assert
        }
    }
}