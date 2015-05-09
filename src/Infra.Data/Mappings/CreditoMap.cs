using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Utilizamos este namespace para trabalharmos com as
// configurações para mapeamento no EF
using System.Data.Entity.ModelConfiguration;
using LGroup.ControleFinanceiro.Domain.Entities;

namespace LGroup.ControleFinanceiro.Infra.Data.Mappings
{
    public sealed class CreditoMap : 
        EntityTypeConfiguration<Credito>
    {
        public CreditoMap()
        {
            ToTable("Credito");

            //Por padrão, no HasKey, é adicionado:
            // PK, Identity e Not Null
            HasKey(x => x.Codigo);

            Property(x => x.Codigo)
                .HasColumnName("IdCredito");
        }
    }
}
