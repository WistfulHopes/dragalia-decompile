using UnityEngine;

namespace Gluon;

public class CharaCircleGaugeMeteorStrikeUI : CharaCircleGaugeUI
{
	[SerializeField]
	private ElementIconUISpriteRenderer elementIcon;

	private ElementalType elementType;

	public static CharaCircleGaugeMeteorStrikeUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1)
	{
		return null;
	}

	protected override void Initialize(CharacterBase owner, CharacterMarkUI markUI, Type gaugeType, float adjustPosY)
	{
	}

	protected override void UpdateOwner()
	{
	}

	private void SetElement(ElementalType type, bool isForce = false)
	{
	}
}
