using UnityEngine;

namespace Gluon;

public class EventTopPageExHunter : EventTopPageBase
{
	[SerializeField]
	public EventTalkWindowModule talkWindowModule;

	[SerializeField]
	public GameObject newObject;

	public override void OnPageBecomeActive(object data)
	{
	}

	public void OnTradeButtonPressed()
	{
	}
}
