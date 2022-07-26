using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event;

public sealed class CuttCommandTypesFormatter : IMessagePackFormatter<CuttCommandEvent.CuttCommandTypes>
{
	public int Serialize(ref byte[] bytes, int offset, CuttCommandEvent.CuttCommandTypes value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public CuttCommandEvent.CuttCommandTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return default(CuttCommandEvent.CuttCommandTypes);
	}
}
