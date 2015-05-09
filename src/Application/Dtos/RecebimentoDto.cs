using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Application.Dtos
{
    //O pattern DTO serve para passar informações de uma camda
    // para outra, evitando métodos com bastante parâmetros
    public sealed class RecebimentoDto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int CodigoRecebimentoTipo { get; set; }
        public DateTime DataEntrada { get; set; }
        public int CodigoCredito { get; set; }
    }
}
