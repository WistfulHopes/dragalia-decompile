namespace Gluon.Event;

public class VesselBombEventCountdownWithCoolTimeParameter : VesselBombEventParameterBase
{
	[Required]
	public CharacterId appender;

	[ActionId]
	public int actionId;

	[SkillIdOrZero]
	public int skillId;

	[ActionConditionId]
	public int actionConditionId;
}
