using UnityEngine;

namespace Gluon;

public class CharaGimmickModeGaugeUI : CharaGimmickActiveGaugeUI
{
	[SerializeField]
	protected SpriteRenderer[] _bgImage;

	[SerializeField]
	protected SpriteRenderer[] _iconImage;

	[SerializeField]
	protected Color _deactiveColor;

	private VisibleUIObject[] _gaugeVisible;

	public new static CharaGimmickModeGaugeUI Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	protected override void Initialize(CharacterBase chara)
	{
	}

	public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false)
	{
	}

	public void SetMode(int mode)
	{
	}

	protected void SetColor(Color color, int index, bool active)
	{
	}

	protected void SetColor(ref SpriteRenderer sprite, Color color)
	{
	}

	protected void SetActiveColor(int index)
	{
	}

	protected void SetDeactiveColor(int index)
	{
	}

	public override int GetGaugeType()
	{
		return default(int);
	}
}
