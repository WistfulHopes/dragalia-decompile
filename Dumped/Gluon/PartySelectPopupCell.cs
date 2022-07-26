using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class PartySelectPopupCell : MonoBehaviour
{
	[SerializeField]
	public CommonIcon characterIcon;

	public CommonIcon dragonIcon;

	public GameObject noDragonMark;

	public CommonIcon weaponIcon;

	public CommonIcon[] amuletIcon;

	public GameObject[] noAmuletMark;

	[SerializeField]
	private GameObject abilityCrestPanel;

	[SerializeField]
	public Transform charaDecoNode;

	public Transform dragonDecoNode;

	public Transform weaponDecoNode;

	public Transform[] amuletDecoNode;

	[SerializeField]
	public Text characterNameText;

	public Text plusValText;

	public Text manaCircleText;

	public Text charaHpText;

	public Text charaAtkText;

	[SerializeField]
	private Text emptyAbilityCrestText;

	[SerializeField]
	private Image[] exAbility1Icons;

	[SerializeField]
	private Image[] exAbility2Icons;

	[SerializeField]
	private CommonExAbilityCell[] exAbilityCells;

	[SerializeField]
	private Sprite abilityIconBlankSprite;

	[SerializeField]
	private Material abilityIconBlankMaterial;

	[SerializeField]
	private Image skill3Icon;

	[SerializeField]
	private Image skill4Icon;

	private int skill3Id;

	private int skill3Level;

	private int skill3MaxLevel;

	private int skill4Id;

	private int skill4Level;

	private int skill4MaxLevel;

	private int memberIndex;

	private PartyList partyDataList;

	private CommonIconListSortDeco charaDeco;

	private CommonIconListSortDeco dragonDeco;

	private CommonIconListSortDeco weaponDeco;

	private CommonIconListSortDeco[] amuletDeco;

	private CommonPartyPowerCalculateData[] multiPartyPowerCalculateDatas;

	public void Setup(int partyNo, int memberIndex, [Optional] PartyList clearParty)
	{
	}

	private void InitWithData()
	{
	}

	private static Color GetColor(CommonParamCalculate.OutGame.ManaCircleTextColor manaColor)
	{
		return default(Color);
	}

	private void SetAmulet(CommonIcon icon, CommonIconListSortDeco deco, GameObject noAmuletMark, int keyId, int slotNum, int maxSlotCount, ref int totalPlus, ref int totalMaxPlus, ref bool isAllEquip)
	{
	}

	public void OnExAbilityButtonPressed()
	{
	}

	public void OnSkill3ButtonPressed()
	{
	}

	public void OnSkill4ButtonPressed()
	{
	}

	public void DisableEditSkills()
	{
	}
}
