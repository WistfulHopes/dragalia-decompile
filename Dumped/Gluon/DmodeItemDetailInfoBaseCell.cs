using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class DmodeItemDetailInfoBaseCell : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private Text nameText;

	[SerializeField]
	private GameObject normalPanel;

	[SerializeField]
	private GameObject nonePanel;

	[SerializeField]
	public Image weaponBG;

	public Image dragonBG;

	public Image abilityCrestBG;

	public Image unifiedBG;

	[SerializeField]
	private Button button;

	private SkillAbilityDetailPopup.PopupType detailType;

	private int id;

	private ElementalType elementalType;

	public void SetupBySkill(int skillId, DmodeDungeonItemType type, IconLoader.Size size = IconLoader.Size.M)
	{
	}

	public void SetupByAbility(int abilityId, DmodeDungeonItemType type, ElementalType elementalType, WeaponType weaponType = WeaponType.NONE, IconLoader.Size size = IconLoader.Size.M)
	{
	}

	private void Start()
	{
	}

	public void OnPressed()
	{
	}

	public void SetBGImage(DmodeDungeonItemType type)
	{
	}
}
