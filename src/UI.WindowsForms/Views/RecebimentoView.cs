using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LGroup.ControleFinanceiro.Application.Contracts;
using System.Collections;
using LGroup.ControleFinanceiro.UI.WindowsForms.Models;
using LGroup.ControleFinanceiro.Infra.Common.Resources;
using LGroup.ControleFinanceiro.Application.Services;

//using LGroup.ControleFinanceiro.Infra.Data.Repositories;
//using LGroup.ControleFinanceiro.Infra.Data.Contexts;

namespace LGroup.ControleFinanceiro.UI.WindowsForms.Views
{
    public partial class RecebimentoView : Form
    {
        private readonly IRecebimentoApplicationService _recebimentoApplicationService;

        //Forma tradicional, sem o IoC
        //public RecebimentoView()
        //{
        //    //Instânciamos o dbContext para os repositórios
        //    ControleFinanceiroContext controleFinanceiroContext =
        //        new ControleFinanceiroContext();

        //    //Instânciamos os repositórios para o application service
        //    RecebimentoRepository recebimentoRepository =
        //        new RecebimentoRepository(controleFinanceiroContext);
        //    CreditoRepository creditoRepository =
        //         new CreditoRepository(controleFinanceiroContext);

        //    //Enfim, conseguimos instânciar o ApplicationService
        //    _recebimentoApplicationService =
        //        new RecebimentoApplicationService(
        //            recebimentoRepository, creditoRepository);

        //    InitializeComponent();
        //}

        //---------------------------------------

        //Forma com o IoC
        public RecebimentoView(IRecebimentoApplicationService recebimentoApplicationService)
        {
            _recebimentoApplicationService = recebimentoApplicationService;
            
            //Carrega a tela
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            recebimentoModelBindingNavigatorSaveItem.Enabled = true;
        }

        private void recebimentoModelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            recebimentoModelBindingSource.EndEdit();

            var listaDeRecebimento =
                (IList<RecebimentoModel>)recebimentoModelBindingSource.List;


            var erros = new List<ApplicationException>();

            foreach (var item in listaDeRecebimento)
            {
                try
                {
                    _recebimentoApplicationService.Adicionar(
                        item.Nome, item.Tipo.Codigo, item.CodigoCredito);
                }
                catch (ApplicationException ex)
                {
                    erros.Add(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Mensagens.ErroInesperado);
                    Close();
                }
            }

            //Se não contém erros, exibe uma mensagem com OK
            if (erros.Count == 0)
                MessageBox.Show(Mensagens.SalvoComSucesso);
            //Se não, exibe os erros na tela
            else
            {
                //StringBuilder é uma forma performática de criar strings
                StringBuilder stringBuilder = new StringBuilder();

                //Adicio cada erro no meu stringBuilder
                foreach (var erro in erros)
                    stringBuilder.AppendLine(erro.Message);

                //Exibo a mensagem completa
                MessageBox.Show(stringBuilder.ToString());
            }
        }

        private void RecebimentoView_Load(object sender, EventArgs e)
        {
            var listaDeTipos = new List<RecebimentoTipoModel>
            {
                new RecebimentoTipoModel { Codigo = 1, Descricao = "Fixo" },
                new RecebimentoTipoModel { Codigo = 2, Descricao = "Esporádico" }
            };

            //recebimentoTipoModelBindingSource.DataSource = listaDeTipos;
            codigoRecebimentoTipoComboBox.DataSource = listaDeTipos;
        }
    }
}
