using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class RecoverStaminaSingleItemConfirmPopup : PopupBase
{
	[SerializeField]
	public CommonIcon icon;

	public Text itemName;

	public Text itemDescription;

	public Text stoneComment;

	public Text insufficientStaminaCommentText;

	public Text titleText;

	[SerializeField]
	public CommonSliderSelection slider;

	[SerializeField]
	public Text beforeStaminaText;

	public Text afterStaminaText;

	public Text beforeInventoryCountText;

	public Text afterInventoryCountText;

	public Text staminaTabText;

	public Text priceText;

	[SerializeField]
	public Text staminaExceedsLimitText;

	public Text stoneStaminaExceedsLimitText;

	public Button okButton;

	[SerializeField]
	public GameObject[] stoneOnlyGOs;

	public GameObject[] itemOnlyGOs;

	public GameObject[] paidStoneOnlyGOs;

	public GameObject[] freeStoneOnlyGOs;

	public Button stonePlusButton;

	public Button stoneMinusButton;

	public Text itemNameTabText;

	[SerializeField]
	private List<MaintenanceFunctionType> maintenanceTypes;

	private int itemId;

	private bool isFreeStone;

	private int useCount;

	private StaminaUtilBase staminaUtil;

	private int recoveryPointPerItem;

	private int beforeStamina;

	private int inventoryCount;

	private bool isMulti;

	private int afterStamina;

	public ItemListPopup itemListPopup;

	private bool isShowRecoverDonePopup;

	public static RecoverStaminaSingleItemConfirmPopup Create(int itemId)
	{
		return null;
	}

	public static RecoverStaminaSingleItemConfirmPopup CreateForStoneWithModel(bool isFreeStone, bool isCreateRecoverDonePopup)
	{
		return null;
	}

	protected override void Start()
	{
	}

	private bool IsUseButtonInteractable(int useCount)
	{
		return default(bool);
	}

	public void OnSliderValueChanged(float val)
	{
	}

	public void OnUseButtonPressed()
	{
	}

	public void OnCloseButtonPressed()
	{
	}
}
