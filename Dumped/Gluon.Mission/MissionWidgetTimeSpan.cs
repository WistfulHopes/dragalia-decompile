using System;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Mission;

public class MissionWidgetTimeSpan : MonoBehaviour
{
	public enum Type
	{
		Period,
		ReceivingTime
	}

	[SerializeField]
	public Text text;

	[SerializeField]
	public Image iconLimit;

	public void Set(Type type, DateTime start, DateTime end)
	{
	}

	public void Initialize(MissionTableViewData data)
	{
	}
}
