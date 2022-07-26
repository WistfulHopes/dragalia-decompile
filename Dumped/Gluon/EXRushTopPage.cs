using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class EXRushTopPage : EventQuestPageBase, ICustomMessage
{
	[SerializeField]
	public RectTransform bgFrame;

	public CanvasGroup bgCancvasGroup;

	public UIAnimationPublisher mainPublisher;

	[SerializeField]
	public Text eventTimeText;

	public Text friendshipNumText;

	public Slider friendshipGauge;

	public Text eventItemSCountText;

	public Text eventItemLCountText;

	[SerializeField]
	public GameObject stageSelect;

	public GameObject eventEndedText;

	[SerializeField]
	public ExRushTopCharaButton[] buttons;

	[SerializeField]
	public Text hint;

	public ButtonWithSelectedImage howtoButtonWithSelectedImage;

	private Coroutine loadBGCoroutine;

	private GameObject bgObj;

	private const string bgPrefabPath = "Prefabs/OutGame/EventQuest/21801/ExRushTopBG";

	protected override void Awake()
	{
	}

	public override void OnPageBecomeActive(object data)
	{
	}

	private IEnumerator LoadBGObj()
	{
		return null;
	}

	public override void OnPageBecomeInActive()
	{
	}

	public override void OnPageEnterAnimationEnded()
	{
	}

	private void UpdateTopInfo()
	{
	}

	public override void OnPresentReceived()
	{
	}

	private void UpdateHint()
	{
	}

	public void OnHelpButtonPressed()
	{
	}

	private void Start()
	{
	}

	public void OnBackButtonTouched()
	{
	}

	public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
	{
	}

	public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
	{
	}

	public void OnMessagReceived(CustomMessageType messageType, object data)
	{
	}
}
