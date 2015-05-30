using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Utilizamos este namespace para trazer 
// o DbContext do Entity Framework
using System.Data.Entity;

//Utilizamos este namespace para trazer as convenções do EF
//Nomeamos o namespace para facilitar na utilização
using Conventions = System.Data.Entity.ModelConfiguration.Conventions;
using LGroup.ControleFinanceiro.Domain.Entities;

namespace LGroup.ControleFinanceiro.Infra.Data.Contexts
{
    //Herdamos o DbConext para transformar a nossa classe
    // ControleFinanceiroContext em um filho de DbContext
    public sealed class ControleFinanceiroContext : DbContext
    {
        public ControleFinanceiroContext()
            : base(@"Data Source=(localdb)\ProjectsV12;Initial Catalog=ControleFinanceiro;Integrated Security=true")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            //Configuration.AutoDetectChangesEnabled = false;
        }

        public DbSet<Credito> Creditos { get; set; }
        public DbSet<Recebimento> Recebimentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Conventions
            modelBuilder.Conventions.Remove<Conventions.PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<Conventions.PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<Conventions.OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<Conventions.ManyToManyCascadeDeleteConvention>();
            #endregion

            #region Configurações de tabelas
            modelBuilder.Configurations.Add(new Mappings.CreditoMap());
            modelBuilder.Configurations.Add(new Mappings.RecebimentoMap());
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        public void CriarBanco()
        {
            Database.Create();
        }

        public void ExcluirBanco()
        {
            Database.Delete();
        }
    }
}
