using System;
using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class TradeMaterialItemConfirmPopup : ShopCommonPopup, ICustomMessage
{
	protected ShopTradeProductData.TradeShopItemData data;

	protected Action onPopupClosed;

	public Action onPopupCancelled;

	[SerializeField]
	public Text itemName;

	public Text itemDescription;

	public CommonIcon icon;

	public Text ownedCount;

	public CommonSliderSelection slider;

	public Text priceText;

	public Text confirmText;

	public GameObject sliderFrame;

	public Button tradeButton;

	[SerializeField]
	private Text itemNoticeText;

	[SerializeField]
	public ShopTradeMaterialIcon[] materialIcons;

	[SerializeField]
	public SelectIconListController selectController;

	[SerializeField]
	public GameObject ownedCountParent;

	[SerializeField]
	private List<GameObject> rarityObjs;

	[SerializeField]
	protected Text selectAmuletText;

	[SerializeField]
	public Text limitCountText;

	public Text endTimeText;

	public Text limitCommentText;

	public bool isUseShortQuantityLimite;

	[SerializeField]
	private Text errorText;

	protected int tradeCount;

	protected int selectionTargetIconIndex;

	protected ulong targetKeyId;

	public static TradeMaterialItemConfirmPopup Create(ShopTradeProductData.TradeShopItemData data, Action onPopupClosed)
	{
		return null;
	}

	protected override void OnDestroy()
	{
	}

	protected override void Start()
	{
	}

	protected long GetMaxTradeCount()
	{
		return default(long);
	}

	protected long GetMaxCountByMaterial(int id, int needCount, GiftType giftType = GiftType.MATERIAL)
	{
		return default(long);
	}

	public void OnSliderValueChanged(float val)
	{
	}

	public void OnClosePopup(bool bOK)
	{
	}

	public void RequestItemTrade()
	{
	}

	protected void OnItemTradeSuccess(TreasureTradeTradeResponse response)
	{
	}

	protected virtual void OnTradeDone()
	{
	}

	protected void OnItemTradeSuccess(EventTradeTradeResponse response)
	{
	}

	public void OnMessagReceived(CustomMessageType messageType, object data)
	{
	}
}
