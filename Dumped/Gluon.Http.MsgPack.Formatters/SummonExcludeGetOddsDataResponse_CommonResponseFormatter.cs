using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters;

public sealed class SummonExcludeGetOddsDataResponse_CommonResponseFormatter : IMessagePackFormatter<SummonExcludeGetOddsDataResponse.CommonResponse>
{
	private readonly AutomataDictionary ____keyMapping;

	private readonly byte[][] ____stringByteKeys;

	public int Serialize(ref byte[] bytes, int offset, SummonExcludeGetOddsDataResponse.CommonResponse value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public SummonExcludeGetOddsDataResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return null;
	}
}