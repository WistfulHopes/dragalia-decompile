using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters;

public sealed class ShopChargeCancelResponse_CommonResponseFormatter : IMessagePackFormatter<ShopChargeCancelResponse.CommonResponse>
{
	private readonly AutomataDictionary ____keyMapping;

	private readonly byte[][] ____stringByteKeys;

	public int Serialize(ref byte[] bytes, int offset, ShopChargeCancelResponse.CommonResponse value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public ShopChargeCancelResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return null;
	}
}
