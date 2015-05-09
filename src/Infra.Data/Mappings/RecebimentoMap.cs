using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using LGroup.ControleFinanceiro.Domain.Entities;

namespace LGroup.ControleFinanceiro.Infra.Data.Mappings
{
    public sealed class RecebimentoMap
        : EntityTypeConfiguration<Recebimento>
    {
        public RecebimentoMap()
        {
            ToTable("Recebimento");
            HasKey(x => x.Codigo);

            HasRequired(x => x.Credito)
                .WithMany(y => y.Recebimentos)
                .HasForeignKey(x => x.CodigoCredito);

            Property(x => x.Codigo)
                .HasColumnName("IdRecebimento");

            Property(x => x.CodigoCredito)
                .HasColumnName("IdCredito")
                .HasColumnType("int");

            Property(x => x.DataEntrada)
                .HasColumnName("DataEntrada")
                .HasColumnType("smalldatetime")
                .IsRequired();

            Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();

            Property(x => x.Tipo)
                .HasColumnName("IdRecebimentoTipo")
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
