using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Util
{
	public class BiMap<T1, T2> : IEnumerable<KeyValuePair<T1, T2>>
	{
		private readonly Dictionary<T1, T2> forward = new Dictionary<T1, T2>();
		private readonly Dictionary<T2, T1> reverse = new Dictionary<T2, T1>();

		public Indexer<T1, T2> Forward { get; private set; }
		public Indexer<T2, T1> Reverse { get; private set; }

		public BiMap()
		{
			this.Forward = new Indexer<T1, T2>(forward);
			this.Reverse = new Indexer<T2, T1>(reverse);
		}

		public void Add(T1 v1, T2 v2)
		{
			this.forward.Add(v1, v2);
			this.reverse.Add(v2, v1);
		}

		public IEnumerator<KeyValuePair<T1, T2>> GetEnumerator() => this.forward.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator() => this.forward.GetEnumerator();

		public class Indexer<T3, T4>
		{
			private readonly Dictionary<T3, T4> dic;
			public Indexer(Dictionary<T3, T4> dictionary) => dic = dictionary;
			public T4 this[T3 index] {
				get => dic[index];
				set => dic[index] = value;
			}
		}

	}
}
