using System;
using SerializableCollections;

namespace Gluon.Master;

[Serializable]
public class EventDamageRewardGroupDictionary : SerializableDictionary<int, EventDamageReward>
{
}
