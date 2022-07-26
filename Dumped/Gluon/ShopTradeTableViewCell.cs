using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon;

public class ShopTradeTableViewCell : TableViewCell<ShopTradeProductData.TradeShopItemData>
{
	public enum TradeItemType
	{
		Common,
		AbilityCrest
	}

	[Serializable]
	public class UnityEventShopItemData : UnityEvent<ShopTradeProductData.TradeShopItemData>
	{
	}

	[SerializeField]
	public UnityEventShopItemData buttonPressed;

	[SerializeField]
	public Text nameText;

	public Text limitCountText;

	public Text priceText;

	public Text endTimeText;

	public Text commentText;

	public CommonIcon icon;

	public bool isUseShortQuantityLimit;

	public bool hideQuantityLimitPrefix;

	[SerializeField]
	public GameObject limitCountLine;

	public GameObject timeLimitLine;

	[SerializeField]
	private List<GameObject> rarityObjs;

	[SerializeField]
	public ShopTradeMaterialIcon[] materials;

	[SerializeField]
	public GameObject[] moonIconGOs;

	[SerializeField]
	public GameObject newFlag;

	[SerializeField]
	public Button button;

	[SerializeField]
	public GameObject needStoryBlockGO;

	public Text needStoryText;

	[SerializeField]
	private GameObject lockIconObj;

	[SerializeField]
	private Sprite emptyMaterialSprite;

	[SerializeField]
	public RectTransform bgFrame;

	public int highQuantityLimitLayoutHeight;

	public int lowQuantityLimitLayoutHeight;

	private ShopTradePanelBase panel;

	private ShopTradeProductData.TradeShopItemData data;

	private TradeItemType type;

	private void Start()
	{
	}

	public override void UpdateContent(ShopTradeProductData.TradeShopItemData data)
	{
	}

	private ShopTradeProductData.InsufficientReason CheckSufficiencyCondition()
	{
		return default(ShopTradeProductData.InsufficientReason);
	}

	public void OnExchangeButtonPressed()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateOKButtonForCrest(bool canExcange)
	{
	}
}
