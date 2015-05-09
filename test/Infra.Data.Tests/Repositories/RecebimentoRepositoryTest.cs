using LGroup.ControleFinanceiro.Domain.Entities;
using LGroup.ControleFinanceiro.Infra.Data.Contexts;
using LGroup.ControleFinanceiro.Infra.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Infra.Data.Tests.Repositories
{
    [TestClass]
    public sealed class RecebimentoRepositoryTest
    {
        [TestMethod]
        public void QuandoEuConsultarOsRecebimentos()
        {
            //arrange
            ControleFinanceiroContext controleFinanceiroContext =
                new ControleFinanceiroContext();
            RecebimentoRepository recebimentoRepository =
                new RecebimentoRepository(controleFinanceiroContext);

            //act
            IEnumerable<Recebimento> recebimentos =
                recebimentoRepository.GetAll();

            //assert
            Assert.IsNotNull(recebimentos);
        }
    }
}
