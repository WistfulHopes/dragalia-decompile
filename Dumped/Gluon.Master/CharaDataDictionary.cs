using System;
using SerializableCollections;

namespace Gluon.Master;

[Serializable]
public class CharaDataDictionary : SerializableDictionary<int, CharaDataElement>
{
}
