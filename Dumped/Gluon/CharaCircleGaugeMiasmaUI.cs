using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class CharaCircleGaugeMiasmaUI : CharaCircleGaugeUI
{
	[SerializeField]
	protected RectTransform _iconAnimRootRt;

	[SerializeField]
	protected RectTransform _iconAnimRt;

	[SerializeField]
	protected SpriteRenderer _iconAnimImage;

	[SerializeField]
	protected InGameAnimUI _glowAnimUI;

	[SerializeField]
	protected Vector2 _iconAnimScale;

	[SerializeField]
	protected Vector2 _iconAnimAlpha;

	[SerializeField]
	protected Ease _iconAnimEase;

	[SerializeField]
	protected float _animWaitTime;

	[SerializeField]
	protected float _grayScaleMulti;

	protected VisibleUIObject _iconAnimVisible;

	protected bool _initializedGrayScale;

	public static CharaCircleGaugeMiasmaUI Create(GameObject parent, CharacterBase owner, BossBreakUI bossBreakUI, float adjustPosY, int siblingIndex = -1)
	{
		return null;
	}

	protected override void Initialize(CharacterBase owner, BossBreakUI bossBreakUI, Type gaugeType, float adjustPosY)
	{
	}

	protected override void UpdateAnim()
	{
	}

	protected override void PlayAnim()
	{
	}

	protected override void StopAnim()
	{
	}

	protected override Color GetGaugeColor(float rate)
	{
		return default(Color);
	}

	private void InitGrayScale()
	{
	}

	protected bool CopyMaterial(ref SpriteRenderer image)
	{
		return default(bool);
	}

	public override void SetGrayScale(bool b, bool isForce = false)
	{
	}

	protected void SetGrayScaleParam(ref SpriteRenderer image, bool isGrayScale, float grayScaleMulti = 1f)
	{
	}
}
