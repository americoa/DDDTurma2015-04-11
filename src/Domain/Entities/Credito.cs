using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.ControleFinanceiro.Domain.ValueObjects;

//Contém a classe Collection para trabalhar com coleção
using System.Collections.ObjectModel;
using LGroup.ControleFinanceiro.Domain.Collections;

namespace LGroup.ControleFinanceiro.Domain.Entities
{
    //Sealed: Tranca a nossa classe. Informa para o compilador,
    // que é a classe final, ou seja, que ela não vai ser pai
    // de ninguém.
    public sealed class Credito : Core.BaseEntity
    {
        public Credito()
        {
            Recebimentos = new RecebimentoCollection();
        }

        public string Descricao { get; private set; }
        public RecebimentoCollection Recebimentos { get; private set; }

        public void AdicionarRecebimento(Recebimento recebimento)
        {
            Recebimentos.Add(recebimento);
        }
    }
}
