using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class EventTalkWindowModule : MonoBehaviour
{
	public enum Type
	{
		Balloon,
		TextWindow
	}

	[SerializeField]
	private Text charaNameText;

	[SerializeField]
	private Text contentText;

	[SerializeField]
	public RectTransform rt;

	[SerializeField]
	public AnimationUITalkWindow balloonAnimation;

	public UIAnimationPublisher commonBalloonAnimaiton;

	[SerializeField]
	public Type type;

	[SerializeField]
	public EventStatusInfoCtrl infoCtrl;

	private float contentAnimationSpeed;

	public void SetCharaName(string charaName)
	{
	}

	public void SetContent(string content)
	{
	}

	public void SetShowHide(bool show)
	{
	}

	public bool IsActiveInHierarchy()
	{
		return default(bool);
	}

	public void SetShowHideWithScale(bool show)
	{
	}

	public bool IsHidingWithScale()
	{
		return default(bool);
	}

	public void StartEnterAnimation()
	{
	}

	public void StartExitAnimation()
	{
	}

	public void StartCloseAndOpenAnimation(string voiceData, [Optional] Action onCloseAndReopen)
	{
	}
}
