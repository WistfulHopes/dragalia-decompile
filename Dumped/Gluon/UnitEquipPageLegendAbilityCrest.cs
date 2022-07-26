using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class UnitEquipPageLegendAbilityCrest : MonoBehaviour
{
	[SerializeField]
	public Image[] abilityCrestIcon;

	public Graphic[] unionIcon;

	public Text[] abilityCrestNameText;

	public Transform[] abilityCrestDecoNode;

	public GameObject[] noAbilityCrestIconGO;

	public void SetupEquipPage()
	{
	}

	private void SetEquipAmuletInfo()
	{
	}

	private void SetCrestUnionIcon(Graphic unionIcon, int crestId)
	{
	}

	private void SetBlank(int index)
	{
	}
}
