using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class PartyEquipStatusIconBar : MonoBehaviour
{
	public Image charaBase;

	public Image amuletBase;

	public Image dragonBase;

	public Image weaponBase;

	public Image skillBase;

	public Text nameText;

	public Image icon;

	public Image lockIcon;

	public Image lockIconImage;

	public Image notUseImage;

	public GameObject skinIconObj;

	public void SetBaseImage(PartyEquipSkillAbilityData.AbilityType type)
	{
	}
}
