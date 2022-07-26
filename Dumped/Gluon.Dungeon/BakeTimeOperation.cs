using System;
using UnityEngine;

namespace Gluon.Dungeon;

public class BakeTimeOperation : MonoBehaviour
{
	[Flags]
	private enum Operation
	{
		None = 0,
		ScaleX = 1,
		ScaleY = 2,
		ScaleZ = 4
	}

	[SerializeField]
	private Operation _operation;

	[SerializeField]
	private Vector3 _localScale;
}
