using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event;

public sealed class CuttCommandEventFormatter : IMessagePackFormatter<CuttCommandEvent>
{
	public int Serialize(ref byte[] bytes, int offset, CuttCommandEvent value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public CuttCommandEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return null;
	}
}
