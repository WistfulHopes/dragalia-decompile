using System;
using UnityEngine;

namespace Gluon.ActionData;

[Serializable]
public class ElementalTrapData : ActionParts.PartsData
{
	[SerializeField]
	[HideInInspector]
	private Gluon.ActionPartsElementalTrap.OperateType _operateType;

	[SerializeField]
	[HideInInspector]
	private float _delay;

	[SerializeField]
	[HideInInspector]
	private bool _guarantee;

	public Gluon.ActionPartsElementalTrap.OperateType operateType => default(Gluon.ActionPartsElementalTrap.OperateType);

	public float delay => default(float);

	public bool guarantee => default(bool);
}
