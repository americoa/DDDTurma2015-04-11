using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LGroup.ControleFinanceiro.Domain.Tests.Entities
{
    [TestClass]
    public sealed class DebitoTest
    {
        [TestMethod]
        public void QuandoEuCriarUmDebito()
        {
            //arrange
            DebitoTipo tipo = DebitoTipo.Fixo;
            Pagamento pagamento = new Pagamento();
            Debito debito;

            //act
            debito = new Debito(tipo, pagamento);

            //assert
            Assert.IsNotNull(debito);
            Assert.AreEqual(debito.Tipo, tipo);
            Assert.AreEqual(debito.Pagamento, pagamento);
        }
    }

    public sealed class Pagamento
    {

    }

    public enum DebitoTipo
    {
        Fixo = 1,
        Esporadico = 2
    }

    public sealed class Debito
    {
        public Debito(DebitoTipo tipo, Pagamento pagamento)
        {

        }

        public DebitoTipo Tipo { get; private set; }
        public Pagamento Pagamento { get; private set; }
    }
}
