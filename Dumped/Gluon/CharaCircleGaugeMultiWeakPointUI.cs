using UnityEngine;

namespace Gluon;

public class CharaCircleGaugeMultiWeakPointUI : CharaCircleGaugeUI
{
	[SerializeField]
	protected RectTransform _markUIAdjustRt;

	[SerializeField]
	protected RectTransform _wpOneDigitRt;

	[SerializeField]
	protected SpriteRenderer _wpBgImage;

	[SerializeField]
	protected SpriteRenderer _wpIconImage;

	[SerializeField]
	protected SpriteRenderer _wpMultiImage;

	[SerializeField]
	protected SpriteRenderer[] _wpCountImage;

	[SerializeField]
	protected Sprite[] _countSprites;

	[SerializeField]
	private float _oneDigitAdjustPosX;

	[SerializeField]
	private float _showMarkUIAdjustPosY;

	private int _maxCount;

	public static CharaCircleGaugeMultiWeakPointUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1)
	{
		return null;
	}

	protected override void Initialize(CharacterBase owner, CharacterMarkUI markUI, Type gaugeType, float adjustPosY)
	{
	}

	public override void SetCount(int count)
	{
	}

	private void SetCountSprite(ref SpriteRenderer image, int count, int targetDigit)
	{
	}

	private void SetCountSprite(ref SpriteRenderer image, int index, bool enabled)
	{
	}

	protected override void SetSortingOrder(int v, bool force = false)
	{
	}
}
