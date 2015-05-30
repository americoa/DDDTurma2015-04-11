using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using LGroup.ControleFinanceiro.Infra.Common.Resources;

namespace UI.Web.Models.Recebimento
{
    public sealed class AdicionarModel
    {
        [Key]
        public int CodigoRecebimento { get; set; }

        [Required]
        [Display(Name = "NomeRecebimento", ResourceType = typeof(Campos))]
        public string NomeRecebimento { get; set; }

        [Required]
        [Display(Name = "CodigoCredito", ResourceType = typeof(Campos))]
        public int CodigoCredito { get; set; }

        [Required]
        [Display(Name = "TipoRecebimento", ResourceType = typeof(Campos))]
        public int TipoRecebimento { get; set; }
    }
}