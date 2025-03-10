using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event;

public sealed class ResetBuffRequestFormatter : IMessagePackFormatter<ResetBuffRequest>
{
	public int Serialize(ref byte[] bytes, int offset, ResetBuffRequest value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public ResetBuffRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return null;
	}
}
