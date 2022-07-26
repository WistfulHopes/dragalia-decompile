using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters;

public sealed class ToolGetServiceStatusResponse_CommonResponseFormatter : IMessagePackFormatter<ToolGetServiceStatusResponse.CommonResponse>
{
	private readonly AutomataDictionary ____keyMapping;

	private readonly byte[][] ____stringByteKeys;

	public int Serialize(ref byte[] bytes, int offset, ToolGetServiceStatusResponse.CommonResponse value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public ToolGetServiceStatusResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return null;
	}
}
