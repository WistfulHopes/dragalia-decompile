using System;
using UnityEngine;

namespace Gluon.ActionData;

[Serializable]
public class OperateCuttData : ActionParts.PartsData
{
	[SerializeField]
	[HideInInspector]
	private Gluon.ActionPartsOperateCutt.OperateType _operateType;

	[SerializeField]
	[HideInInspector]
	private int _sceneId;

	[SerializeField]
	[HideInInspector]
	private float _cuttDuraion;

	[SerializeField]
	[HideInInspector]
	private bool _isQuestEndCutt;

	[SerializeField]
	[HideInInspector]
	private bool _isQTECutt;

	public Gluon.ActionPartsOperateCutt.OperateType operateType => default(Gluon.ActionPartsOperateCutt.OperateType);

	public int sceneId => default(int);

	public float cuttDuraion => default(float);

	public bool isQuestEndCutt => default(bool);

	public bool isQTECutt => default(bool);
}
