using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Contém a classe estática Thread para
// a criação de um novo processo;
using System.Threading.Tasks;

//
using LGroup.ControleFinanceiro.Domain.Entities;
using LGroup.ControleFinanceiro.Domain.ValueObjects;

//Contém os dataannotations para testes
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;



namespace LGroup.ControleFinanceiro.Domain.Tests.Entities
{
    //TestClass permite que a classe 
    // trabalhe como uma classe de teste
    [TestClass]
    public sealed class CreditoTest
    {
        //Permite que o método se torne um
        // teste de unidade
        [TestMethod]
        public void QuandoEuCriarUmCredito()
        {
            //arrage

            //act
            Credito credito = new Credito();

            //assert
            Assert.IsNotNull(credito);
        }
        
        [TestMethod]
        public void QuandoEuAdicionarUmRecebimentoNoCredito()
        {
            //arrange: Criar os objetos necessários 
            //         para a execução do teste
            Credito credito = new Credito();
            RecebimentoTipo recebimentoTipo = RecebimentoTipo.Esporádico;
            const string nomeRecebimento = "Salário";
            Recebimento recebimento = new Recebimento(nomeRecebimento, recebimentoTipo);

            //act: Ação de executar o que deverá ser testado
            credito.AdicionarRecebimento(recebimento);

            //assert: Garantir que a ação executada está de acordo
            //        com o previsto
            Assert.IsTrue(credito.Recebimentos.Count == 1);
        }

        [TestMethod]
        public void QuandoEuCriarUmRecebimento()
        {
            //arrange
            const string nomeRecebimento = "Aluguel";
            DateTime dataEntrada = DateTime.Now;
            RecebimentoTipo tipoRecebimento = RecebimentoTipo.Fixo;

            //act
            //Pausa a Thread atual em milisegundos, 
            // neste caso, 2 segundos
            Thread.Sleep(1);
            Recebimento recebimento = new Recebimento(nomeRecebimento, tipoRecebimento);

            //assert
            Assert.IsNotNull(recebimento);
            Assert.AreEqual(recebimento.DataEntrada.Date, dataEntrada.Date);
        }

        //ExpectedException: Informa para o teste, que o assert (a garantia)
        //                    deverá ser uma exceção
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmRecebimentoONomeDeveraSerObrigatorio()
        {
            //Para alterar o idioma do sistema, utilizamos o CurrentCulture e o CurrentUICulture para informar 
            // o idioma desejado
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            //arrange
            string nomeRecebimento = string.Empty;
            RecebimentoTipo recebimentoTipo = RecebimentoTipo.Fixo;

            //act
            Recebimento recebimento =
                new Recebimento(nomeRecebimento, recebimentoTipo);

            //assert
        }
    }    
}
