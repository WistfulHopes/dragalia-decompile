using System;
using UnityEngine;

namespace Gluon.ActionData;

[Serializable]
public class SetupX3rdSubData : ActionParts.PartsData
{
	[SerializeField]
	[HideInInspector]
	private string _attachNode;

	[SerializeField]
	[HideInInspector]
	private float _bodyScaleFor2nd;

	[SerializeField]
	[HideInInspector]
	private Vector3 _popTentacleAPos;

	[SerializeField]
	[HideInInspector]
	private Vector3 _popTentacleBPos;

	[SerializeField]
	[HideInInspector]
	private float _popTentacleADir;

	[SerializeField]
	[HideInInspector]
	private float _popTentacleBDir;

	[SerializeField]
	[HideInInspector]
	private int _deadActionId;

	[SerializeField]
	[HideInInspector]
	private string _hitAttrLabel;

	[SerializeField]
	[HideInInspector]
	private float _hitInterval;

	public string attachNode => null;

	public float bodyScaleFor2nd => default(float);

	public Vector3 popTentacleAPos => default(Vector3);

	public Vector3 popTentacleBPos => default(Vector3);

	public float popTentacleADir => default(float);

	public float popTentacleBDir => default(float);

	public int deadActionId => default(int);

	public string hitAttrLabel => null;

	public float hitInterval => default(float);
}
