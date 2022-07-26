using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon;

public class ActionPartsRotateTarget : ActionParts
{
	private readonly RotateTargetData _partsData;

	private float _baseRot;

	private float _moveRot;

	private Vector3 targetPos;

	private CharacterBase _targetCharacter;

	private float _elapsedSec;

	private RunActionPosRotParameter _tmpRunActionParam;

	public ActionPartsRotateTarget(Gluon.ActionData.ActionParts resource)
	{
	}

	public override RunActionParameterBase CreateRunActionParameter()
	{
		return null;
	}

	public override void SetRunActionParameter(RunActionParameterBase param)
	{
	}

	protected override void OnStart()
	{
	}

	private void CalcTarget()
	{
	}

	protected override bool OnUpdate(float delta)
	{
		return default(bool);
	}
}
