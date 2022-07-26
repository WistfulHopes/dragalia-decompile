using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon.Mission.ListView;

public class MissionTableViewCell : TableViewCell<MissionTableViewData>
{
	[Serializable]
	public class ButtonEvent : UnityEvent<int>
	{
	}

	[SerializeField]
	public Text missionNameText;

	[SerializeField]
	public MissionWidgetRewardIcon rewardIcon;

	[SerializeField]
	public MissionWidgetAchievement achievement;

	[SerializeField]
	public MissionWidgetRemainingTime remainingTime;

	[SerializeField]
	private GameObject ClearedObj;

	[SerializeField]
	private GameObject ReceivedObj;

	[SerializeField]
	private GameObject widgetRoot;

	[SerializeField]
	private GameObject captionRoot;

	[SerializeField]
	private Text captionText;

	[SerializeField]
	private Text noMissionText;

	[SerializeField]
	private GameObject lockBaseObj;

	[SerializeField]
	private Text lockTitleText;

	[SerializeField]
	private Text lockInfoText;

	[SerializeField]
	private Image badgeIcon;

	[SerializeField]
	private GameObject challengeButtonObj;

	[SerializeField]
	private ButtonEvent onCellPressed;

	[SerializeField]
	private ButtonEvent onChallengeButtonPressed;

	public override void UpdateContent(MissionTableViewData data)
	{
	}

	public void SetMissionName(string name)
	{
	}

	public void OnCellPressed()
	{
	}

	public void OnChallengeButtonPressed()
	{
	}
}
