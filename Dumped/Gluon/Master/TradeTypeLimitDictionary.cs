using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class TradeTypeLimitDictionary : SerializableDictionary<int, TradeTypeLimitElement>
	{
	}
}
