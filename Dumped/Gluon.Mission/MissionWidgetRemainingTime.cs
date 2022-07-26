using System;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon.Mission;

public class MissionWidgetRemainingTime : MonoBehaviour
{
	private MissionTableViewData.State state;

	private bool isDrawTime;

	private DateTime end;

	[SerializeField]
	private GameObject clearedTextImage;

	[SerializeField]
	private GameObject clearedStampImage;

	[SerializeField]
	private GameObject receivedTextImage;

	[SerializeField]
	private GameObject receivedStampImage;

	[SerializeField]
	private GameObject goRemainingTime;

	[SerializeField]
	private Text textRemainingTime;

	[SerializeField]
	private Image iconLimit;

	public UnityAction expiredCallback;

	private void Update()
	{
	}

	public void Initialize(MissionTableViewData.State state)
	{
	}

	public void Initialize(MissionTableViewData.State state, DateTime end)
	{
	}

	public void SetState(MissionTableViewData.State state)
	{
	}

	public void SetDrawTime(bool isDrawTime)
	{
	}

	private string GetTimeText(TimeSpan span)
	{
		return null;
	}

	public void UpdateTime(TimeSpan span)
	{
	}

	private void SetVisibleClearedImage(bool visible)
	{
	}

	private void SetVisibleReceivedImage(bool visible)
	{
	}
}
