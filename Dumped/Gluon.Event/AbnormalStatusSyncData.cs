namespace Gluon.Event;

public struct AbnormalStatusSyncData
{
	[ActionConditionId]
	public int elemId;

	public ushort durationNum;

	public float durationTime;

	public float baseSlipDamage;

	public float lifeSec;

	public CharacterId from;
}
