using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon;

public class ShopCommonItemTableViewCell : TableViewCell<ShopTradeProductData.CommonShopItemData>
{
	[Serializable]
	public class UnityEventShopItemData : UnityEvent<ShopTradeProductData.CommonShopItemData>
	{
	}

	[SerializeField]
	public UnityEventShopItemData buttonPressed;

	[SerializeField]
	public Text nameText;

	public Text limitCountText;

	public Text priceText;

	public Image packIcon;

	public Text sustainableContinueTimeText;

	[SerializeField]
	public GameObject sustainableEffectiveCover;

	public GameObject quantityLimitReachedCover;

	public GameObject priceLine;

	public GameObject recommendLabel;

	public RectTransform titleRectTrans;

	[SerializeField]
	public GameObject crystalIcon;

	public GameObject dragonDiamondIcon;

	public GameObject goldIcon;

	public GameObject moonIcon;

	public GameObject manaIcon;

	[SerializeField]
	public Button button;

	[SerializeField]
	public GameObject frameContent;

	[SerializeField]
	public GameObject captionFrame;

	public Text captionText;

	[SerializeField]
	private Text periodText;

	[SerializeField]
	public float periodIconPosY;

	public float periodIconScale;

	public float periodTitlePosY;

	[SerializeField]
	public float normalIconPosY;

	public float normalIconScale;

	public float normalTitlePosY;

	public Action onUpdateContent;

	protected ShopTradeProductData.CommonShopItemData data;

	protected ShopTradePanelBase panel;

	protected virtual void Start()
	{
	}

	public static string GetQuantityLimitText(ShopTradeProductData.CommonShopItemData.ResetType resetType, int purchaseLimit, int boughtCount)
	{
		return null;
	}

	public override void UpdateContent(ShopTradeProductData.CommonShopItemData data)
	{
	}

	public void OnPurchaseButtonPressed()
	{
	}

	private void SetPopup()
	{
	}

	private bool IsAstralItemExceed()
	{
		return default(bool);
	}

	private bool CanBuyMultiple()
	{
		return default(bool);
	}
}
