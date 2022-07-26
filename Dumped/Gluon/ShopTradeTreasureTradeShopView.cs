using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon;

public class ShopTradeTreasureTradeShopView : ShopTradePanelBase
{
	[SerializeField]
	private ShopTradeTableViewController tableview;

	[SerializeField]
	public TabBase[] tabControllers;

	[SerializeField]
	public RectTransform frameDialogRectTransform;

	private List<ShopTradeTableViewController> tableViewList;

	private TabBase usingTabBase;

	private static Action onHttpDone;

	private ShopTradeProductData.TradeShopItemData selectedData;

	public static ShopTradeTreasureTradeShopView Create(Transform parent, ShopTradeScene scene)
	{
		return null;
	}

	private static void ReloadData()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public override void OnCellButtonPressed(ShopTradeProductData.TradeShopItemData data)
	{
	}

	public void ReloadPage()
	{
	}

	public override void RefreshCurrentPage()
	{
	}
}
