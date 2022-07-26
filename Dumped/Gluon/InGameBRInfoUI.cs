using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class InGameBRInfoUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _weaponExpCounterRt;

	[SerializeField]
	private InGameCounterUI _suvivorCounter;

	[SerializeField]
	private InGameCounterUI _killCounter;

	[SerializeField]
	private InGameCounterUI _weaponLevelCounter;

	[SerializeField]
	private InGameCounterUI _weaponExpCounter;

	[SerializeField]
	private InGameCounterUI _weaponExpCounter2;

	[SerializeField]
	protected InGameGaugeUISpriteRenderer _weaponGauge;

	[SerializeField]
	protected RectTransform _weaponLevelupAnimRt;

	[SerializeField]
	protected RectTransform _weaponGaugeAnimRt;

	[SerializeField]
	protected SpriteRenderer _weaponGaugeAnimImage;

	[SerializeField]
	protected SpriteRenderer _weaponLevelupImage;

	[SerializeField]
	protected float _levelupTextAnimTime;

	[SerializeField]
	protected float _levelupTextIntervalTime;

	[SerializeField]
	protected float _levelupTextPosY;

	[SerializeField]
	protected float _levelupTextPosY2;

	[SerializeField]
	protected float _levelupTextPosY3;

	[SerializeField]
	protected Vector2 _gaugeAnimScale;

	[SerializeField]
	protected Vector2 _gaugeAnimScale2;

	[SerializeField]
	protected float _gaugeAnimTime;

	[SerializeField]
	protected float _gaugeIntervalTime;

	[SerializeField]
	protected float _gaugeAnimTime2;

	protected Sequence _seqLevelup;

	protected Sequence _seqGaugeAnim;

	protected VisibleUIObject _weaponExpCounterVisible;

	private int _lastSuvivorCount;

	private int _lastKillCount;

	protected int _lastWeaponLevel;

	protected int _lastExp;

	protected int _lastNextExp;

	protected float _reqGaugeRate;

	protected bool _isDirty;

	protected bool _isLevelMax;

	public static InGameBRInfoUI Create(GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	protected virtual void Initialize()
	{
	}

	private void OnDestroy()
	{
	}

	public override void FastUpdate()
	{
	}

	private void SetSuvivorNum(bool isForce = false)
	{
	}

	private void SetSuvivorNum(int count, bool isForce = false)
	{
	}

	private int GetSuvivorCount()
	{
		return default(int);
	}

	private void SetKillNum(bool isForce = false)
	{
	}

	private void SetKillNum(int count, bool isForce = false)
	{
	}

	private int GetKillCount()
	{
		return default(int);
	}

	private void SetWeaponExp(bool isForce = false, bool isAnim = true)
	{
	}

	protected void ResetLevelupTextAnim()
	{
	}

	protected void PlayLevelupTextAnim()
	{
	}

	protected void PlayGaugeAnim(bool isLevelMax)
	{
	}

	protected void SetAlpha(ref SpriteRenderer sprite, float alpha)
	{
	}
}
