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

namespace LGroup.ControleFinanceiro.UI.WindowsForms.Views
{
    public partial class RecebimentoView : Form
    {
        private readonly IRecebimentoApplicationService _recebimentoApplicationService;

        public RecebimentoView()
        {
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

            foreach (var item in listaDeRecebimento)
                _recebimentoApplicationService.Adicionar(
                    item.Nome, item.Tipo.Codigo, item.CodigoCredito);
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
