using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters;

public sealed class ToolGetServiceStatusRequestFormatter : IMessagePackFormatter<ToolGetServiceStatusRequest>
{
	private readonly AutomataDictionary ____keyMapping;

	private readonly byte[][] ____stringByteKeys;

	public int Serialize(ref byte[] bytes, int offset, ToolGetServiceStatusRequest value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public ToolGetServiceStatusRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return null;
	}
}
