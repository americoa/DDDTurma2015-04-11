using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using BM.Validations;
using LGroup.ControleFinanceiro.Infra.Common.Resources;
using LGroup.ControleFinanceiro.Domain.ValueObjects;
using LGroup.ControleFinanceiro.Domain.Entities;

namespace LGroup.ControleFinanceiro.Domain.Tests.Entities
{
    [TestClass]
    public sealed class DebitoTest
    {
        [TestMethod]
        public void QuandoEuCriarUmDebito()
        {
            //arrange
            Tipo tipo = Tipo.Fixo;
#warning Trazer esse objeto do repositório
            Pagamento pagamento = new Pagamento("Aluguel", DateTime.Now, DateTime.Now);
            Debito debito;

            //act
            debito = new Debito(tipo, pagamento);

            //assert
            Assert.IsNotNull(debito);
            Assert.AreEqual(debito.Tipo, tipo);
            Assert.AreEqual(debito.Pagamento, pagamento);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmDebitoOPagamentoDeveSerObrigatorio()
        {
            //arrange
            Tipo tipo = Tipo.Esporadico;
            Pagamento pagamento = null;
            Debito debito;

            //act
            debito = new Debito(tipo, pagamento);

            //assert
        }
    }
}
