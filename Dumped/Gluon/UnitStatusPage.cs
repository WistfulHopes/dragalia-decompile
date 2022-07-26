using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon;

public class UnitStatusPage : MonoBehaviour
{
	[SerializeField]
	private Text statusPageTitle;

	[SerializeField]
	public Text hpParam;

	[SerializeField]
	private Text hpPlusParam;

	[SerializeField]
	private Text hpAndPlusParam;

	public Text atkParam;

	[SerializeField]
	private Text atkPlusParam;

	[SerializeField]
	private Text atkAndPlusParam;

	public Text defParam;

	public Text powerParam;

	[SerializeField]
	private GameObject[] separateValueObj;

	[SerializeField]
	private GameObject[] sumValueObj;

	[SerializeField]
	private Button paramSwitchButton;

	[SerializeField]
	private GameObject possessionNode;

	[SerializeField]
	private Text possessionText;

	[SerializeField]
	private GameObject unionNode;

	[SerializeField]
	private Image[] unionImage;

	[SerializeField]
	private Text unionNothing;

	[SerializeField]
	private GameObject slotNode;

	[SerializeField]
	private Image[] slotImage;

	[SerializeField]
	private GameObject gaugeNode;

	[SerializeField]
	private GameObject levelNode;

	[SerializeField]
	public CharaTypeUI charaType;

	[SerializeField]
	public GameObject detailButtonBase;

	public UnityAction statusDetailCallBack;

	[SerializeField]
	public Text levelText;

	public Text expText;

	public Slider expGauge;

	public GameObject fullGageFill;

	public Button expChangeButton;

	[SerializeField]
	public GameObject limitBase;

	public GameObject[] limitParentImages;

	public GameObject[] limitOnImages;

	public GameObject[] limitMaxImages;

	[SerializeField]
	public Image manaStar;

	public Text manaCountText;

	[SerializeField]
	public GameObject shareSkillCostObj;

	public Text shareSkillCostText;

	[SerializeField]
	public Image weaponSkinIcon;

	[HideInInspector]
	public UnitDetailCanvas parentCanvas;

	private UnitDetailModel.UnitDetailType unitType;

	private bool isShowNextLv;

	private bool isParamSwitch;

	[SerializeField]
	private GameObject modeIconParent;

	[SerializeField]
	private Image[] modeIconImage;

	private Color grayout;

	public void SetupStatusPage(UnitDetailModel.UnitDetailType type)
	{
	}

	private void SetupCommonInfo()
	{
	}

	public void ExpInfoChangeButtonPressed()
	{
	}

	private void SetNextLevelGauge()
	{
	}

	public void StatusDetailButtonPressed()
	{
	}

	private void SetStatusInfo()
	{
	}

	private void SetGunModeIcon(Image image, int modeId)
	{
	}

	public void OnParamSwitchButton()
	{
	}
}
