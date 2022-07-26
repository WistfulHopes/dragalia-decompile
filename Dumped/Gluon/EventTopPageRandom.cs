using UnityEngine;

namespace Gluon;

public class EventTopPageRandom : EventTopPageBase
{
	[SerializeField]
	private TreasureTimeController treasureTimeCtrl;

	protected override void Awake()
	{
	}

	public override void OnPageBecomeActive(object data)
	{
	}
}
