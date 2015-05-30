using LGroup.ControleFinanceiro.Domain.Entities;
using LGroup.ControleFinanceiro.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Domain.Factories
{
    //Normalmente, as fábricas são classes estáticas.
    //Ela serve para fabricar objetos a partir de outros
    // objetos, ou seja, gerar uma instância
    public static class RecebimentoFactory
    {
        public static Recebimento Create(string nome, Tipo tipo)
        {
            return new Recebimento(nome, tipo);
        }

        public static Recebimento Create(Debito debito, string nome)
        {
            return new Recebimento(nome, debito.Tipo);
        }
    }
}
