using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class UnionBonusUIChara : MonoBehaviour
{
	[SerializeField]
	private Image charaIcon;

	[SerializeField]
	private UnionBonusUIAbility abilityUIBase;

	[SerializeField]
	private float unionBonusHeight;

	[SerializeField]
	private Image unionIcon;

	[SerializeField]
	private Text unionBonusName;

	public void Setup(UnionBonusPopup.UnionBonusInfo unionBonusInfo)
	{
	}

	public void Setup(UnionAbilityElement unionBonus)
	{
	}
}
