using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Event;

public class BRInitWorld : EventBase<BRInitWorld>
{
	public Vector3 pulseCenterPoint;

	public List<BRInitWorldItemData> items;

	public float pulseMaxRadius;
}
