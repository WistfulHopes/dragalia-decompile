using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters;

public sealed class UserGetWalletBalanceResponseFormatter : IMessagePackFormatter<UserGetWalletBalanceResponse>
{
	private readonly AutomataDictionary ____keyMapping;

	private readonly byte[][] ____stringByteKeys;

	public int Serialize(ref byte[] bytes, int offset, UserGetWalletBalanceResponse value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public UserGetWalletBalanceResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return null;
	}
}
