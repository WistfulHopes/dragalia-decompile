using System;
using UnityEngine;

namespace Gluon.Dungeon;

public class StampCollisionArea : MonoBehaviour
{
	[Flags]
	public enum DirectionFlags
	{
		Down = 1,
		Up = 2,
		Left = 4,
		Right = 8
	}

	[SerializeField]
	[EnumFlags]
	private DirectionFlags dirFlags;

	public bool IsDirectionFlags(DirectionFlags f)
	{
		return default(bool);
	}
}
