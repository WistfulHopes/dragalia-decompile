using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Event;

public class BRCreateItemEvent : EventBase<BRCreateItemEvent>
{
	public enum PatternTypes
	{
		RandomPop,
		Silent
	}

	public Vector3 pos;

	public float radius;

	public uint seed;

	public List<BRItemParam> items;

	public PatternTypes pattern;
}
