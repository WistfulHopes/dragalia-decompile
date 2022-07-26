using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class RaidEventInfoCtrl : EventInfoCtrlBase
{
	[SerializeField]
	private GameObject friendlyPointParent;

	[SerializeField]
	private Text friendlyPointText;

	[SerializeField]
	private Image itemImage;

	[SerializeField]
	private Text itemCountText;

	[SerializeField]
	private Image exItemImage;

	[SerializeField]
	private Text exItemCountText;

	[SerializeField]
	private Image iconImage;

	[SerializeField]
	private Text iconCountText;

	[SerializeField]
	private Text exchangeItem1CountText;

	[SerializeField]
	private Text exchangeItem2CountText;

	[SerializeField]
	private Text hintText;

	[SerializeField]
	private Text hintTitleText;

	[SerializeField]
	private Text charaGrowItemCountText;

	[SerializeField]
	private Image charaGrowItemIcon;

	[SerializeField]
	private GameObject charaGrowItem;

	[SerializeField]
	private Gauge gauge;

	[SerializeField]
	private GameObject hintParent;

	[SerializeField]
	private GameObject itemsParent;

	[SerializeField]
	public GameObject raidBoostGO;

	public GameObject raidBoostSpecialHelpGO;

	public ButtonWithSelectedImage specialHelpButtonWithSelectImage;

	[SerializeField]
	private Text updateTimeText;

	[SerializeField]
	private Text individualTotalDamageValueText;

	[SerializeField]
	private Text wholeTotalDamageValueText;

	[SerializeField]
	private ButtonWithSelectedImage totalDamageRewardButtonSelectedImage;

	[SerializeField]
	private Text aggregateUpdateTimeText;

	[SerializeField]
	private GameObject friendlyInfoPanel;

	private bool hasRaidBoost;

	private bool isTotalDamageEvent;

	private static readonly string totalDamageRaidEventInfoPrefabPath;

	private static readonly string raidEventInfoPrefabPath;

	public static RaidEventInfoCtrl Create(Transform parent, bool isTotalDamageEvent)
	{
		return null;
	}

	public override void SetEventInfo()
	{
	}

	private void SetEventHintText()
	{
	}

	public void OnRaidBoostButtonPressed()
	{
	}

	protected override void ResetSpecialHelpButtonPressedState()
	{
	}

	public void OnTotalDamageRewardButtonPressed()
	{
	}

	private void InitializeTotalDamageEventInfo()
	{
	}
}
