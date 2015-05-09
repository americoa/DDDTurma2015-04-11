using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.ControleFinanceiro.Domain.ValueObjects;

using LGroup.ControleFinanceiro.Infra.Common.Resources;

namespace LGroup.ControleFinanceiro.Domain.Entities
{
    public sealed class Recebimento : Core.BaseEntity
    {
        //Utilizamos o set como private para não permitir 
        // que classes de fora alterem o escopo da classe responsável,
        // que neste caso, é a classe Recebimento
        public string Nome { get; private set; }
        public RecebimentoTipo Tipo { get; private set; }
        public DateTime DataEntrada { get; private set; }

        public int CodigoCredito { get; private set; }
        public Credito Credito { get; private set; }

        private Recebimento() { }

        //Utilizamos o construtor do objeto para trazer um cenário da "vida real",
        // onde falamos que para criar um recebimento, é obrigatório informar
        // um nome e um tipo
        public Recebimento(string nome, RecebimentoTipo recebimentoTipo)
        {
            if (string.IsNullOrWhiteSpace(nome))
                //Criamos o resource Mensagens para centralizar as mensagens
                // do sistema. Ele contém propriedades estáticas. Para utilizá-lo,
                // basta apenas utilizar o seu using, colocar o nome da Classe (nome do resource) e 
                // chamar a propriedade da mensagem desejada
                throw new ApplicationException(Mensagens.RecebimentoNomeVazio);

            Nome = nome;
            Tipo = recebimentoTipo;
            DataEntrada = DateTime.Now;
        }

        public void AlterarCredito(Credito credito)
        {
            Credito = credito;
        }
    }
}
