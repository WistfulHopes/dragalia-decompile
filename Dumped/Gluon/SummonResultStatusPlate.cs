using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class SummonResultStatusPlate : MonoBehaviour
{
	[SerializeField]
	public Text itemName;

	public Text levelNow;

	public Text levelMax;

	public Text hpVal;

	public Text atkVal;

	public Text powerVal;

	public Text skillText;

	[SerializeField]
	public GameObject exAbilityGO;

	[SerializeField]
	public GameObject normalStatusPanelGO;

	public GameObject moonStatusPanelGO;

	public Text moonDescriptionText;

	[SerializeField]
	public GameObject amuletStatusPanelGO;

	public Text amuletName;

	public UnitDetailAbilityInfoCell[] amuletAbilities;

	[SerializeField]
	public CommonIcon icon;

	public UnitDetailModel CreateUnitDetailModel(SummonResultItemData data)
	{
		return null;
	}

	public void SetupByResultItemData(SummonResultItemData data)
	{
	}
}
