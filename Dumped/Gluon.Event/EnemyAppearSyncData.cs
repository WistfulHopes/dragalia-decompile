namespace Gluon.Event;

public struct EnemyAppearSyncData
{
	[Required]
	public CharacterId character;

	[EnemyParamId]
	public int paramId;
}
