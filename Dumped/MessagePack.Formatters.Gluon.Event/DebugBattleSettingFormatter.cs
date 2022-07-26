using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event;

public sealed class DebugBattleSettingFormatter : IMessagePackFormatter<DebugBattleSetting>
{
	public int Serialize(ref byte[] bytes, int offset, DebugBattleSetting value, IFormatterResolver formatterResolver)
	{
		return default(int);
	}

	public DebugBattleSetting Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
	{
		return null;
	}
}
