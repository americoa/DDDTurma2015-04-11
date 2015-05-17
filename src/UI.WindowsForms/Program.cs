using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forms = System.Windows.Forms;

using SimpleInjector;
using LGroup.ControleFinanceiro.Infra.CrossCutting.IoC;

namespace LGroup.ControleFinanceiro.UI.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Forms.Application.EnableVisualStyles();
            Forms.Application.SetCompatibleTextRenderingDefault(false);

            //Inicializamos o IoC
            Bootstrap();

            //Recuperamos a tela a partir do IoC
            Forms.Application.Run(_container.GetInstance<Views.RecebimentoView>());
        }


        //Declaramos o container do SimpleInjector
        private static Container _container;

        //Iniciaremos o container
        private static void Bootstrap()
        {
            //Criamos a instância
            _container = new Container();

            //Chamamos a nossa camada para registrar as classes 
            // no container
            Startup.Register(_container);

            //Registramos as nossas telas de windows forms
            _container.RegisterForms();

            //Verifica se não está faltando alguma classe que foi injetada
            // (Validação de possíveis erros)
            _container.Verify();
        }

        private static void RegisterForms(this Container container)
        {
            container.Register<Views.RecebimentoView>();
        }
    }
}
