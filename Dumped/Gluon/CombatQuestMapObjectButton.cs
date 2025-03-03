using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class CombatQuestMapObjectButton : MonoBehaviour
{
	[SerializeField]
	public PointerEventHandler[] pointerEventHandler;

	[SerializeField]
	private Text title;

	[SerializeField]
	private Image balloonImage;

	[SerializeField]
	private Image ribbonImage;

	[SerializeField]
	private Image storyLandmarkImage;

	[SerializeField]
	private GameObject[] bodyObject;

	[SerializeField]
	public Sprite[] ribbonSpriteList;

	[SerializeField]
	private QuestStateIcon stateIcon;

	[SerializeField]
	private Transform ballonTransform;

	[SerializeField]
	private float moveY;

	[SerializeField]
	private float moveTime;

	[SerializeField]
	private Ease easeType;

	private Sequence sequence;

	[SerializeField]
	private Transform lockIconParent;

	[SerializeField]
	private GameObject lockIcon;

	private FlashPlayer lockIconFlash;

	[SerializeField]
	private GameObject iconBadge;

	[SerializeField]
	private FlashPlayerManager flashPlayerManager;

	private FlashPlayer unlockFlash;

	[SerializeField]
	private Transform flashParent;

	private const string balloonPath = "Images/Icon/Combat/Balloon/{0:D5}/{1:D2}";

	private const string landmarkPath = "Images/Icon/Combat/Landmark/{0:D5}/storyLandmark";

	public void Setup(int index, string titleText, Action<int> onTouched, int masterIndex, QuestUtil.QuestState state)
	{
	}

	public void UpdateState(int index, QuestUtil.QuestState state)
	{
	}

	public void PlayUnlockFlash([Optional] Action onAnimationEnded)
	{
	}

	private void OnDestroy()
	{
	}
}
