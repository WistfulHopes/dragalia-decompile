using System;
using SerializableCollections;

namespace Gluon.Master;

[Serializable]
public class QuestScoreMissionDataDictionary : SerializableDictionary<int, QuestScoreMissionDataElement>
{
}
