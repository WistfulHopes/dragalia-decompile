using System;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class UniqueTransButton : FastUpdateMonoBehaviour
{
	[SerializeField]
	private Button button;

	[SerializeField]
	private RectTransform iconRt;

	[SerializeField]
	private RectTransform offsetRt;

	[SerializeField]
	private RectTransform noUseRt;

	[SerializeField]
	private SpriteRenderer icon;

	[SerializeField]
	private SpriteRenderer buttonEffectImage;

	[SerializeField]
	private SpriteRenderer noUseImage;

	[SerializeField]
	private SpriteRenderer _utpGaugeImage;

	[SerializeField]
	private CircleGauge _utpGaugeCtrl;

	[SerializeField]
	private DragonPointGaugeUI dpGaugeUI;

	[SerializeField]
	private float expansionTime;

	[SerializeField]
	private float moveTime;

	[SerializeField]
	private float gaugeOffsetX;

	[SerializeField]
	private Color32 inactiveTimeColor;

	[SerializeField]
	private float inactiveTimeContrast;

	[SerializeField]
	private float inactiveTimeSaturation;

	[SerializeField]
	private float inactiveTimeBrightness;

	[SerializeField]
	private float inactiveTimeBrightnessDeep;

	[SerializeField]
	private int flashCount;

	[SerializeField]
	private float flashTime;

	[SerializeField]
	private float maxFlashPower;

	[SerializeField]
	private float utpGaugeRequireRate;

	[SerializeField]
	private float utpGaugeMaxRate;

	[SerializeField]
	private Color32 utpGaugeDefaultColor;

	[SerializeField]
	private Color32 utpGaugeMaxColor;

	private CharacterBase lastOwner;

	private RectTransform rootRt;

	private RectTransform buttonEffectRt;

	private VisibleUIObject noUseVisible;

	private bool[] lastIsUtpMax;

	private bool validate;

	private bool lastValidate;

	private Tweener twExpansion;

	private Tweener twMove;

	private Action onMaxValue;

	private Vector2 moveInSidePos;

	private Vector2 moveOutSidePos;

	private float lastRecastSec;

	private ClockworkShaderControl clockworkShaderControl;

	private bool isClonedMaterial;

	private bool isUpdate;

	private bool isLeftFlag;

	private float lastUtpRate;

	private bool lastChangeTrans;

	private bool lastRecast;

	private Tweener twButtonEffect;

	private Tweener twButtonEffectFlash;

	private const float tweenerExpansionEndValue = (float)Math.PI;

	private const float clockworkMinTimerVolume = 0.01f;

	public static UniqueTransButton Create(GameObject parent, int index, Action<UniqueTransButton> onClick, bool isLeft)
	{
		return null;
	}

	public void Initialize(Action<UniqueTransButton> onClick, bool isLeft)
	{
	}

	public void OnDestroy()
	{
	}

	public override void FastUpdate()
	{
	}

	private void UpdateUI(bool isOwnerChange = false, bool isForce = false)
	{
	}

	private void SetInvalidActive(bool isActive)
	{
	}

	protected void SetEnableButton(bool b, bool isForce = false)
	{
	}

	public void SetDPGaugeRate(float rate, bool isForce = false, bool isImmediate = false, bool isWithEffectAndSE = true)
	{
	}

	public void SetUTPGaugeValue(CharacterBase owner, int val, int maxVal, int requireVal, bool force = false, bool withEffectAndSE = true)
	{
	}

	public void SetImage(Material mat)
	{
	}

	public void SetImage()
	{
	}

	public void VisibleButton(bool v)
	{
	}

	public void SetActionMaxValue(Action onMaxValue)
	{
	}

	public void Visible(bool b)
	{
	}

	public bool IsVisible()
	{
		return default(bool);
	}

	public void Validate(bool b)
	{
	}

	private void CheckInactive(bool utpTrigger, bool modeChange, bool recast, bool noUse, bool isMaxNow, bool isOwnerChange)
	{
	}

	public void EnterUI()
	{
	}

	public void LeaveUI()
	{
	}

	public Vector2 GetButtonPosition()
	{
		return default(Vector2);
	}

	public Vector2 GetButtonSize()
	{
		return default(Vector2);
	}

	public Vector2 GetGaugePosition()
	{
		return default(Vector2);
	}

	public int GetSiblingIndex()
	{
		return default(int);
	}

	private void StartExpansion()
	{
	}

	private void OnUpdateExpansion(float value)
	{
	}

	private void OnCompleteButtonEffectColor()
	{
	}

	private void OnUpdateButtonEffectFlash(float value)
	{
	}

	private void StartButtonEffect()
	{
	}

	public static bool CanUse(PlayerCharacter player)
	{
		return default(bool);
	}

	public static bool CanUseAndIsInsideUI(PlayerCharacter player)
	{
		return default(bool);
	}
}
