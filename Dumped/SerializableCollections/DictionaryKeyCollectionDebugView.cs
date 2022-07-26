using System.Collections.Generic;

namespace SerializableCollections;

internal sealed class DictionaryKeyCollectionDebugView<TKey, TValue>
{
	private readonly ICollection<TKey> _collection;

	public TKey[] Items => null;

	public DictionaryKeyCollectionDebugView(ICollection<TKey> collection)
	{
	}
}
