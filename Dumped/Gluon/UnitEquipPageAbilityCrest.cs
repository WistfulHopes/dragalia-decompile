using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class UnitEquipPageAbilityCrest : MonoBehaviour
{
	[SerializeField]
	public Image[] abilityCrestIcon;

	public Graphic[] unionIcon;

	public Text[] abilityCrestNameText;

	public Transform[] abilityCrestDecoNode;

	public GameObject[] noAbilityCrestIconGO;

	[SerializeField]
	private Text abilityCrestTitleText;

	public void SetupEquipPage()
	{
	}

	private void SetEquipAmuletInfo()
	{
	}

	private void SetCrestUnionIcon(Graphic unionIcon, int crestId)
	{
	}

	private void SetTalisman(int index)
	{
	}

	private void SetBlank(int index)
	{
	}
}
