using System;
using UnityEngine;

namespace Gluon.ActionData;

[Serializable]
public class MonolithBurstData : ActionParts.PartsData
{
	[SerializeField]
	[HideInInspector]
	private bool _childType01;

	[SerializeField]
	[HideInInspector]
	private bool _childType02;

	[SerializeField]
	[HideInInspector]
	private bool _childType03;

	[SerializeField]
	[HideInInspector]
	private string[] _hitAttrLabel;

	[SerializeField]
	[HideInInspector]
	private float _waitTime;

	[SerializeField]
	[HideInInspector]
	private int _childActionId;

	public bool childType01 => default(bool);

	public bool childType02 => default(bool);

	public bool childType03 => default(bool);

	public string[] hitAttrLabel => null;

	public float waitTime => default(float);

	public int childActionId => default(int);
}
