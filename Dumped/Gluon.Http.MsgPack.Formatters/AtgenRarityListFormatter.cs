using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters;

public sealed class AtgenRarityListFormatter : IMessagePackFormatter<AtgenRarityList>
{
	private readonly AutomataDictionary ____keyMapping;

	private readonly byte[][] ____stringByteKeys;

	public int Serialize(ref byte[] bytes, int offset, AtgenRarityList value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public AtgenRarityList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return null;
	}
}
