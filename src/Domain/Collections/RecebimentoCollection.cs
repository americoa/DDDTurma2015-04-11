using LGroup.ControleFinanceiro.Domain.Entities;
using LGroup.ControleFinanceiro.Domain.Factories;
using LGroup.ControleFinanceiro.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Domain.Collections
{
    //Herdamos do BaseCollection para transformar a nossa
    // classe em uma coleção de dados
    //O base collection irá facilitar na hora do desenvolvimento,
    // evitando ter que reescrever o código várias vezes
    //Como o BaseCollection<> é genérico, eu consigo criar qualquer
    // tipo de coleção
    public sealed class RecebimentoCollection
        : Core.BaseCollection<Recebimento>
    {
        //Utilizamos o override para sobrescrever o método
        // Add do BaseCollection<>, pois assim, podemos fazer
        // as nossas próprias condições, o que não era permitido antes
        public override void Add(Recebimento item)
        {
            //Fizemos a nossa validação
            if (Count > 100)
                throw new ApplicationException("O limite de itens é de 100");

            //Mantemos a forma de adicionar da nossa clase base
            base.Add(item);
        }

        //Criamos uma nova forma de adicionar o item 
        // na nossa coleção de dados
        public void Add(string nome, Tipo tipo)
        {
            var recebimento = RecebimentoFactory.Create(nome, tipo);
            Add(recebimento);
        }

        //Criamos o nosso método customizado
        // para remover itens pelo nome
        public void RemoveByNome(string nome)
        {
            //Recuperamos todos os itens que tenha o nome
            // de acordo com a variável nome do método
            var recebimentosComNomeInformado = 
                Collection.Where(x => x.Nome == nome);

            //Removemos item a item
            foreach (var recebimento in recebimentosComNomeInformado)
                Remove(recebimento);
        }
    }
}
