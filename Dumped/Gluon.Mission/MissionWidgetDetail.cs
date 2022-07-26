using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Mission;

public class MissionWidgetDetail : MonoBehaviour
{
	private string missionName;

	private string spanDesc;

	[SerializeField]
	public Text textMissionName;

	[SerializeField]
	public bool useTimeSpan;

	public MissionWidgetTimeSpan timeSpan;

	[SerializeField]
	public MissionWidgetDetailReward detailReward;

	public Text duplicateText;

	private void Start()
	{
	}

	public void SetTimeSpan(MissionWidgetTimeSpan.Type type, DateTime start, DateTime end)
	{
	}
}
