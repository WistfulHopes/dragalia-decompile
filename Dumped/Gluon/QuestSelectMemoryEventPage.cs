using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon;

public class QuestSelectMemoryEventPage : QuestSelectEventPageBase, ICustomMessage
{
	[SerializeField]
	public GameObject activeEventGO;

	public SimpleAnimationCell activeTitleAnimationCell;

	public QuestMenuMemoryEventBanner activeBanner;

	[SerializeField]
	public QuestMenuMemoryEventBanner templateBanner;

	[SerializeField]
	public GameObject recommendedGO;

	public SimpleAnimationCell recommendedTitleAnimationCell;

	public Transform recommendedParent;

	[SerializeField]
	public GameObject recommendedRaidGO;

	public SimpleAnimationCell recommendedRaidTitleAnimationCell;

	public Transform recommendedRaidParent;

	[SerializeField]
	public GameObject recommendedDefenceGO;

	public SimpleAnimationCell recommendedDefenceTitleAnimationCell;

	public Transform recommendedDefenceParent;

	[SerializeField]
	public GameObject recommendedInterceptGO;

	public SimpleAnimationCell recommendedInterceptTitleAnimationCell;

	public Transform recommendedInterceptParent;

	[SerializeField]
	public GameObject recommendedEventOthersGO;

	public SimpleAnimationCell recommendedEventOthersTitleAnimationCell;

	public Transform recommendedEventOthersParent;

	[SerializeField]
	public GameObject recommendedSpecialGO;

	public SimpleAnimationCell recommendedSpecialTitleAnimationCell;

	public Transform recommendedSpecialParent;

	[SerializeField]
	public GameObject othersGO;

	public SimpleAnimationCell otherTitleAnimationCell;

	public Transform othersParent;

	[SerializeField]
	public GameObject othersRaidGO;

	public SimpleAnimationCell otherRaidTitleAnimationCell;

	public Transform othersRaidParent;

	[SerializeField]
	public GameObject othersDefenceGO;

	public SimpleAnimationCell otherDefenceTitleAnimationCell;

	public Transform othersDefenceParent;

	[SerializeField]
	public GameObject othersInterceptGO;

	public SimpleAnimationCell otherInterceptTitleAnimationCell;

	public Transform othersInterceptParent;

	[SerializeField]
	public GameObject othersEventOthersGO;

	public SimpleAnimationCell otherEventOthersTitleAnimationCell;

	public Transform othersEventOthersParent;

	[SerializeField]
	public GameObject othersSpecialGO;

	public SimpleAnimationCell otherSpecialTitleAnimationCell;

	public Transform othersSpecialParent;

	[SerializeField]
	public UIAnimationPublisher publisher;

	[SerializeField]
	public ButtonWithSelectedImage howtoButtonWithSelectedImage;

	private QuestSelectInstance.QuestEventData eventData;

	private const string prefMemoryTutorial = "__MemoryEventTutorialPU";

	private Dictionary<int, float> scrollValueDic;

	[SerializeField]
	private int tutorialPageCount;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
	{
	}

	public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
	{
	}

	public override void OnPageBecomeActive(object data)
	{
	}

	public override void OnPageBecomeInActive()
	{
	}

	public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
	{
		return default(bool);
	}

	private void CreateEventList()
	{
	}

	private void SetEventList(List<int> eventList, GameObject go, SimpleAnimationCell animationCell, Transform parent, ref int delayIndex)
	{
	}

	public void OnBackButtonTouched()
	{
	}

	public void OnHowToButtonPressed()
	{
	}

	public void OnMessagReceived(CustomMessageType messageType, object data)
	{
	}
}
