using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Gluon;

public class AutoPlayUI : MonoBehaviour
{
	[SerializeField]
	private RectTransform rootRt;

	[SerializeField]
	private RectTransform autoButtonRt;

	[SerializeField]
	private RectTransform autoOffRt;

	[SerializeField]
	private RectTransform autoOnRt;

	[SerializeField]
	private RectTransform autoStopRt;

	[SerializeField]
	private RectTransform dragonButtonRt;

	[SerializeField]
	private RectTransform dragonOffRt;

	[SerializeField]
	private RectTransform dragonOnRt;

	[SerializeField]
	private RectTransform speedButtonRt;

	[SerializeField]
	private RectTransform speedNormalRt;

	[SerializeField]
	private RectTransform speedFastRt;

	[SerializeField]
	private RectTransform repeatButtonRt;

	[SerializeField]
	private RectTransform repeatOffRt;

	[SerializeField]
	private RectTransform repeatOnRt;

	[SerializeField]
	private RectTransform impossibleAutoRt;

	[SerializeField]
	private RectTransform impossibleDragonRt;

	[SerializeField]
	private RectTransform impossibleRepeatRt;

	[SerializeField]
	private SpriteRenderer imageOn;

	[SerializeField]
	private SpriteRenderer imageOnRing;

	[SerializeField]
	private SpriteRenderer imageOnAdd;

	[SerializeField]
	private SpriteRenderer imageStop;

	[SerializeField]
	private SpriteRenderer imageStopAdd;

	[SerializeField]
	private SpriteRenderer imageDragonOn;

	[SerializeField]
	private SpriteRenderer imageDragonOnRing;

	[SerializeField]
	private SpriteRenderer imageDragonOnAdd;

	[SerializeField]
	private SpriteRenderer imageSpeedFast;

	[SerializeField]
	private SpriteRenderer imageSpeedFastRing;

	[SerializeField]
	private SpriteRenderer imageRepeatOn;

	[SerializeField]
	private SpriteRenderer imageRepeatOnRing;

	[SerializeField]
	private SpriteRenderer imageLockAuto;

	[SerializeField]
	private SpriteRenderer imageLockSpeed;

	[SerializeField]
	private SpriteRenderer imageLockRepeat;

	[SerializeField]
	private Text textRepeatOff;

	[SerializeField]
	private Text textRepeatOn;

	[SerializeField]
	private Sprite[] speedIcon;

	[SerializeField]
	private float ringRotateSpeed;

	[SerializeField]
	private int defaultRaycastSortingOrder;

	[SerializeField]
	private int textSortingOrderOffset;

	[SerializeField]
	private float[] raidQuestAdjustPosYList;

	[SerializeField]
	private float sumUpTotalDamageQuestAdjustPosY;

	[SerializeField]
	private float dmodeAdjustPosY;

	private Sequence sequenceToStop;

	private Sequence sequenceIdleAlpha;

	private SortingGroup spriteSortingGroup;

	private Canvas repeatOffTextCanvas;

	private Canvas repeatOnTextCanvas;

	private Canvas _raycastCanvas;

	private Vector3 basePos;

	private Vector3 ringRot;

	private float tweenStopImageAlpha;

	private float tweenIdleAlpha;

	private bool isStopAutoPlay;

	private bool isAutoEnable;

	private bool isRepeatEnable;

	private bool isQuestStartShowing;

	private const float toStopFadeDuration = 0.1f;

	private const float idleAlphaDuration = 0.75f;

	private const float idleAlphaScale = 0.5f;

	private const float idleAlphaScaleStop = 0.15f;

	private const float lockStatusAdjustPos = 20f;

	private const float systemMessageDisplayTime = 2f;

	public static AutoPlayUI Create(GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize()
	{
	}

	private void ResetParameter()
	{
	}

	private void UpdateStopAlphaValue(float alpha)
	{
	}

	private void UpdateIdleAlphaValue(float alpha)
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void UpdateImageFade(ref SpriteRenderer sprite, float a)
	{
	}

	public void OnClickAutoPlay()
	{
	}

	private void ExecOnClickAutoPlay(bool val, bool withSE)
	{
	}

	public void OnClickDragon()
	{
	}

	public void OnClickSpeed()
	{
	}

	public void OnClickRepeat()
	{
	}

	private void SetAutoMode(bool val, bool withSE)
	{
	}

	private void SetDragonImage(bool val, bool withSE, bool applyMode)
	{
	}

	private void SetSpeedRateImage(InGameTime.GameSpeed rate, bool withSE)
	{
	}

	private void SetRepeatImage(bool val, bool effect)
	{
	}

	public void SetLock(bool isLock)
	{
	}

	public void SetEnable(bool isEnable)
	{
	}

	public void SetRepeatCounter(int currNum, int loopNum)
	{
	}

	public void SetRaidQuestPosition(int otherPlayerNum)
	{
	}

	public void SetSumUpTotalDamageQuestPosition()
	{
	}

	public void SetDmodePosition()
	{
	}

	private void SetActive(ref RectTransform rt, bool active)
	{
	}

	private void SetActive(ref SpriteRenderer sr, bool active)
	{
	}

	private bool IsSingleQuest()
	{
		return default(bool);
	}

	private bool IsEnableRepeat()
	{
		return default(bool);
	}
}
