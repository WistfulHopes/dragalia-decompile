using System;
using SerializableCollections;

namespace Gluon.Master;

[Serializable]
public class QuestGuestDataDictionary : SerializableDictionary<int, QuestGuestDataElement>
{
}
