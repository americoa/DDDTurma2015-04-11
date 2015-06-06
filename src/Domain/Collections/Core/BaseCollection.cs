using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.ControleFinanceiro.Domain.Collections.Core
{
    //Para transformar a classe em uma coleção,
    // implementamos a interface genérica ICollection<>
    //O base collection vai servir como um pai para as coleções
    // somente vou permitir os overrides dos métodos, quando necessário
    public abstract class BaseCollection<T> : ICollection<T>
    {
        //Criamos uma variável "protegida" para representar
        // a nossa coleção
        protected readonly ICollection<T> Collection;

        //Geramos os construtores da nossa collection,
        // sendo um normal e outro aceitando IList para
        // facilitar uma conversão de dados
        protected BaseCollection()
        {
            Collection = new Collection<T>();
        }
        protected BaseCollection(IList<T> list)
        {
            Collection = new Collection<T>(list);
        }

        //Colocamos o virtual para possibilitar um override do método
        // na classe que estiver herdando ele
        public virtual void Add(T item)
        {
            Collection.Add(item);
        }

        public virtual void Clear()
        {
            Collection.Clear();
        }

        public bool Contains(T item)
        {
            return Collection.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Collection.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return Collection.Count; }
        }

        public bool IsReadOnly
        {
            get { return Collection.IsReadOnly; }
        }

        public virtual bool Remove(T item)
        {
            return Collection.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Collection.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}