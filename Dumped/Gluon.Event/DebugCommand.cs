namespace Gluon.Event;

public class DebugCommand : EventBase<DebugCommand>
{
	public enum DebugCommandTypes
	{
		None,
		QuestClear,
		BRWarp,
		KillingEnemy,
		EnemyParameterMaxHP,
		EnemyParameterATK,
		EnemyParameterOD,
		EnemyParameterBreak
	}

	[Required]
	public DebugCommandTypes type;

	public bool boolValue;

	public int intValue;

	public float floatValue;

	[Required]
	public CharacterId charaId;
}
