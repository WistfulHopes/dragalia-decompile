using UnityEngine;

namespace Gluon;

public class CharaCircleGaugeDrasticForceUI : CharaCircleGaugeUI
{
	[SerializeField]
	protected RectTransform _countAdjustRt;

	[SerializeField]
	protected RectTransform _countRt_01;

	[SerializeField]
	protected SpriteRenderer _countMultiImage;

	[SerializeField]
	protected SpriteRenderer[] _countImageArray;

	[SerializeField]
	protected Sprite[] _countSprites;

	[SerializeField]
	private float _oneDigitCountAdjustPosX;

	[SerializeField]
	private float _oneDigitCountPosX_01;

	private int _maxCount;

	public static CharaCircleGaugeDrasticForceUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1)
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

	public override void SetGaugeTimer(float time, float initialTime, bool isPlayAnim = true, bool isForce = false)
	{
	}

	protected override void SetSortingOrder(int v, bool force = false)
	{
	}
}
