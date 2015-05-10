using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.UI.WindowsForms.Models
{
    public sealed class RecebimentoModel
    {
        public string Nome { get; set; }
        //public int CodigoRecebimentoTipo { get; set; }
        public RecebimentoTipoModel Tipo { get; set; }
        public int CodigoCredito { get; set; }
    }
}
