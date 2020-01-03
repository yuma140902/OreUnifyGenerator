using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Util
{
	public class Cache<T>
	{
		private readonly Dictionary<string, T> data = new Dictionary<string, T>();

		public T Get(string key) => data.ContainsKey(key) ? data[key] : default(T);

		public void Set(string key, T value)
		{
			if (data.ContainsKey(key)) {
				data[key] = value;
			}
			else {
				data.Add(key, value);
			}
		}

		public void Remove(string key)
		{
			if (data.ContainsKey(key)) {
				data.Remove(key);
			}
		}
	}
}
