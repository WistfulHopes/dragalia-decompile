using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class StrategyDialog : StrategyDialogBase
{
	public enum ItemType
	{
		Sack_N,
		Sack_R,
		Weapon_N,
		Weapon_R,
		Amulet_N,
		Amulet_R,
		Max
	}

	public enum ExConditionType
	{
		Continue,
		Reborn,
		PartySwitch
	}

	[SerializeField]
	private RectTransform infoRt;

	[SerializeField]
	private RectTransform infoDetailRt;

	[SerializeField]
	private RectTransform[] infoDetailItemRt;

	[SerializeField]
	private RectTransform missionRt;

	[SerializeField]
	private RectTransform missionDetailRt;

	[SerializeField]
	private RectTransform itemRt;

	[SerializeField]
	private RectTransform itemDetailRt;

	[SerializeField]
	private Image frameImage;

	[SerializeField]
	private Image[] elementImages;

	[SerializeField]
	private Sprite[] elementSprite;

	[SerializeField]
	private RectTransform buttonBaseRt;

	[SerializeField]
	private Text clearText;

	[SerializeField]
	private Text failureText;

	[SerializeField]
	private Text exConditionTitleText;

	[SerializeField]
	private Text exConditionDetailText;

	[SerializeField]
	private Text exCondition2TitleText;

	[SerializeField]
	private Text exCondition2DetailText;

	[SerializeField]
	private RectTransform exCondition2Rt;

	[SerializeField]
	private Text exCondition3TitleText;

	[SerializeField]
	private Text exCondition3DetailText;

	[SerializeField]
	private RectTransform exCondition3Rt;

	[SerializeField]
	private Text[] missionText;

	[SerializeField]
	private Image[] missionIcon;

	[SerializeField]
	private Sprite missionIconOn;

	[SerializeField]
	private Sprite missionIconOff;

	[SerializeField]
	private Text manaText;

	[SerializeField]
	private Text coinText;

	[SerializeField]
	private Text[] itemText;

	[SerializeField]
	private Image[] itemImage;

	[SerializeField]
	private Color32 selectedColor;

	[SerializeField]
	private float continueImpossibleMergin;

	[SerializeField]
	private float gameWallDetailOffsetY;

	[SerializeField]
	private float gameWallInfoDetailItemOffsetY;

	[SerializeField]
	private float gameWallItemOffsetY;

	[SerializeField]
	private float gameBRHeadOffsetY;

	[SerializeField]
	private float gameBRFrameOffsetY;

	[SerializeField]
	private float gameBRFrameOffsetH;

	[SerializeField]
	private float gameBRItemOffsetY;

	[SerializeField]
	private float gameBRButtonOffsetY;

	[SerializeField]
	private float elementIconOffset;

	private Vector3 orgHeadPos;

	private Vector3 orgFramePos;

	private Vector3 orgInfoPos;

	private Vector3 orgInfoDetailPos;

	private Vector3[] orgInfoDetailItemPos;

	private Vector3 orgMissionPos;

	private Vector3 orgMissionDetailPos;

	private Vector3 orgItemPos;

	private Vector3 orgItemDetailPos;

	private Vector3 orgButtonBasePos;

	private Vector3 orgRetryButtonPos;

	private float orgFrameHeight;

	private const int numKind = 2;

	private const int numElement = 6;

	private const int numStrategy = 4;

	private const int numMission = 3;

	private const int numItem = 6;

	public static StrategyDialog Create(GameObject parent)
	{
		return null;
	}

	protected override void Initialize()
	{
	}

	private void LoadEventSackMaterial(int type)
	{
	}

	public void Update()
	{
	}

	public override void Open()
	{
	}

	private void SetQuestElement(ElementalType elemental, ElementalType elemental2 = ElementalType.NONE)
	{
	}

	private void SetupLayout()
	{
	}

	private void UpdateItemCount(ref Text uiText, int count)
	{
	}

	private Sprite GetElementSprite(ElementalType type)
	{
		return null;
	}

	private string GetExConditionTitle(ExConditionType type)
	{
		return null;
	}

	public static string GetExConditionDetail(ExConditionType type, bool isStrategy)
	{
		return null;
	}
}
