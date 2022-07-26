using System.Collections.Generic;

namespace SerializableCollections;

internal sealed class DictionaryValueCollectionDebugView<TKey, TValue>
{
	private readonly ICollection<TValue> _collection;

	public TValue[] Items => null;

	public DictionaryValueCollectionDebugView(ICollection<TValue> collection)
	{
	}
}
