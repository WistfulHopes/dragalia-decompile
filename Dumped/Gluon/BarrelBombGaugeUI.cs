using Cute.Core;
using UnityEngine;

namespace Gluon;

public class BarrelBombGaugeUI : FastUpdateMonoBehaviour
{
	private enum BlinkState
	{
		Idle,
		In,
		Out
	}

	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _bgRt;

	[SerializeField]
	private RectTransform _blinkRt;

	[SerializeField]
	private SpriteRenderer _bgImage;

	[SerializeField]
	private SpriteRenderer _gaugeImage;

	[SerializeField]
	private SpriteRenderer _iconImage;

	[SerializeField]
	private SpriteRenderer _blinkImage;

	[SerializeField]
	private CircleGauge _gaugeCtrl;

	[SerializeField]
	private float _blinkStartRemainTime;

	[SerializeField]
	private Vector2 _blinkAlpha;

	[SerializeField]
	private float _blinkDurationTime;

	[SerializeField]
	private float _adjust3DPosY;

	[SerializeField]
	private float _adjust2DPosY;

	private VisibleUIObject _rootVisible;

	private VisibleUIObject _blinkVisible;

	private GameObject _owner;

	private Vector3 _settingPosition;

	private Vector3 _settingLocalScale;

	private Color _gaugeColor;

	private bool _show;

	private int _curSortingOrder;

	private int _defSortingOrder;

	private float _blinkTime;

	private BlinkState _blinkState;

	private static int _createCount;

	private int DefaultSortingOrder;

	private static readonly Color[] GAUGE_COLOR;

	private static readonly float[] GAUGE_COLOR_THRESHOLD;

	private static readonly int GAUGE_COLOR_NUM;

	public static BarrelBombGaugeUI Create(GameObject parent, GameObject owner, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize(GameObject owner)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void Update()
	{
	}

	private void UpdatePosition()
	{
	}

	public void SetPosition(Vector3 setPosition, Vector3 scale)
	{
	}

	private Vector2 GetScreenPosition(Vector3 position, Vector3 localscale)
	{
		return default(Vector2);
	}

	public void SetAdjust2DPosY(float adjust)
	{
	}

	public void SetAdjust3DPosY(float adjust)
	{
	}

	private void UpdateBlink()
	{
	}

	public void SetGaugeTimer(float remainTime, float durationTime)
	{
	}

	private void SetGaugeRate(float rate)
	{
	}

	private Color GetGaugeColor(float rate)
	{
		return default(Color);
	}

	private void SetBlinkAlpha(float a)
	{
	}

	private void EnableBlink()
	{
	}

	private void DisableBlink()
	{
	}

	private bool IsShow()
	{
		return default(bool);
	}

	private void InitSortingOrder()
	{
	}

	public void SetSortingOrder(int sortingOrder)
	{
	}

	public void ResetSortingOrder()
	{
	}

	private void SetSortingOrder(int v, bool force = false)
	{
	}
}
