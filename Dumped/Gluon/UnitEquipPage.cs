using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class UnitEquipPage : MonoBehaviour
{
	[SerializeField]
	public Image weaponIcon;

	public GameObject weaponLvGO;

	public Text weaponLvText;

	public Text weaponNameText;

	public Image weaponSkinIcon;

	[SerializeField]
	public Image dragonIcon;

	public GameObject dragonLvGO;

	public Text dragonLvText;

	public Text dragonNameText;

	public GameObject noDragonIconGO;

	public void SetupEquipPage()
	{
	}

	private void SetEquipDragonInfo()
	{
	}

	private void SetEquipWeaponInfo()
	{
	}
}
