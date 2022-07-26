using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event;

public sealed class BuffFieldDeleteEventParamFormatter : IMessagePackFormatter<BuffFieldDeleteEventParam>
{
	public int Serialize(ref byte[] bytes, int offset, BuffFieldDeleteEventParam value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public BuffFieldDeleteEventParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return null;
	}
}
