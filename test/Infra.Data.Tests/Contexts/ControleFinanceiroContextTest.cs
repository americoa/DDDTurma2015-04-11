using LGroup.ControleFinanceiro.Infra.Data.Contexts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Infra.Data.Tests.Contexts
{
    [TestClass]
    public sealed class ControleFinanceiroContextTest
    {
        [TestMethod]
        public void QuandoEuCriarUmBanco()
        {
            //arrange
            ControleFinanceiroContext controleFinanceiroContext =
                new ControleFinanceiroContext();

            //act
            controleFinanceiroContext.CriarBanco();

            //assert
        }

        [TestMethod]
        public void QuandoEuExcluirUmBanco()
        {
            //arrange
            ControleFinanceiroContext controleFinanceiroContext =
                new ControleFinanceiroContext();

            //act
            controleFinanceiroContext.ExcluirBanco();

            //assert
        }
    }
}
