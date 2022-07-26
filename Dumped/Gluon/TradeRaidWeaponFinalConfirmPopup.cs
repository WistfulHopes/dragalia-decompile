using System;
using UnityEngine;

namespace Gluon;

public class TradeRaidWeaponFinalConfirmPopup : PopupBase
{
	[SerializeField]
	public CommonIcon icon;

	private ShopTradeProductData.TradeShopItemData data;

	private Action onTrade;

	public static TradeRaidWeaponFinalConfirmPopup Create(ShopTradeProductData.TradeShopItemData data, Action onTrade)
	{
		return null;
	}

	protected override void Start()
	{
	}

	public void OnTradeButtonPressed()
	{
	}
}
