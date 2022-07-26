using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event;

public sealed class NextEnemyGroupFormatter : IMessagePackFormatter<NextEnemyGroup>
{
	public int Serialize(ref byte[] bytes, int offset, NextEnemyGroup value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public NextEnemyGroup Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return null;
	}
}
