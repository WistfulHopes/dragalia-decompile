using System.Collections.Generic;

namespace SerializableCollections;

internal sealed class IDictionaryDebugView<K, V>
{
	private readonly IDictionary<K, V> _dict;

	public KeyValuePair<K, V>[] Items => null;

	public IDictionaryDebugView(IDictionary<K, V> dictionary)
	{
	}
}
