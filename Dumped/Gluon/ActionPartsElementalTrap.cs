using Gluon.ActionData;
using Gluon.Event;

namespace Gluon;

public class ActionPartsElementalTrap : ActionParts
{
	public enum OperateType
	{
		ActiveTrap,
		StopTrap,
		AllBurst
	}

	private ElementalTrapUniqueCtrl _ctrl;

	private readonly ElementalTrapData _partsData;

	private RunActionRandomParameter _runActionParam;

	public ActionPartsElementalTrap(Gluon.ActionData.ActionParts resource)
	{
	}

	public override RunActionParameterBase CreateRunActionParameter()
	{
		return null;
	}

	public override void SetRunActionParameter(RunActionParameterBase param)
	{
	}

	public override void OnPostCreated(CharacterBase chara)
	{
	}

	public override void Clear()
	{
	}

	protected override void OnStart()
	{
	}

	private void Proc()
	{
	}
}
