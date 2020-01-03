using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Util
{
	public static class Dictionaries
	{
		public static string ToStringEx<K, V>(this Dictionary<K, V> map, string separator = ", ")
			=> string.Join(separator, map.Select((pair) => $"{pair.Key}: {pair.Value}"));

		public static V GetOrDefault<K, V>(this Dictionary<K, V> map, K key, V dflt = default)
			=> map.ContainsKey(key) ? map[key] : dflt;

		public static HashSet<V> GetOrEmpty<K, V>(this Dictionary<K, HashSet<V>> map, K key)
			=> map.ContainsKey(key) ? map[key] : new HashSet<V>();

		public static V Put<K, V>(this Dictionary<K, V> map, K key, V value)
		{
			if (map.ContainsKey(key)) {
				V prev = map[key];
				map[key] = value;
				return prev;
			}
			else {
				map.Add(key, value);
				return default;
			}
		}

		public static void RemoveSafely<K, V>(this Dictionary<K, V> map, K key)
		{
			if (map.ContainsKey(key)) {
				map.Remove(key);
			}
		}
	}
}
