using UnityEngine;

namespace Gluon;

public class CharaCircleGaugeScapegoatUI : CharaCircleGaugeUI
{
	[SerializeField]
	protected RectTransform _oneDigitRt;

	[SerializeField]
	protected SpriteRenderer[] _countImage;

	[SerializeField]
	protected Sprite[] _countSprites;

	[SerializeField]
	private float _oneDigitAdjustPosX;

	public static CharaCircleGaugeScapegoatUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1)
	{
		return null;
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
}
