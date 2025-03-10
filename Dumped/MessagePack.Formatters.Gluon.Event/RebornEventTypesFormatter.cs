using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event;

public sealed class RebornEventTypesFormatter : IMessagePackFormatter<RebornEvent.RebornEventTypes>
{
	public int Serialize(ref byte[] bytes, int offset, RebornEvent.RebornEventTypes value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public RebornEvent.RebornEventTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return default(RebornEvent.RebornEventTypes);
	}
}
