using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class UnitAbilityPage : MonoBehaviour
{
	[SerializeField]
	public GameObject normalPanel;

	public GameObject withEquipPanel;

	[SerializeField]
	public UnitDetailAbilityInfoCell[] mixedPageCellList;

	public UnitDetailAbilityInfoCell[] singlePageCellList;

	[SerializeField]
	private Text abilityTitleText;

	[HideInInspector]
	public UnitDetailCanvas parentCanvas;

	private UnitDetailModel.UnitDetailType unitType;

	private const int maxCount = 8;

	public void SetupAbilityPage(UnitDetailModel.UnitDetailType type, int index)
	{
	}

	private void SetAbilityInfo(int index)
	{
	}
}
