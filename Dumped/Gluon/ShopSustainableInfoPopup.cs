using UnityEngine;

namespace Gluon;

public class ShopSustainableInfoPopup : PopupBase
{
	[SerializeField]
	public GameObject[] dailyCrystalGOs;

	public GameObject[] dailyStaminaGOs;

	public GameObject[] questBonusGOs;

	[SerializeField]
	private MaintenanceButtonController purchageButtonMaintenance;

	private ShopTradeProductData.CommonShopItemData.PackContentType contentType;

	public static ShopSustainableInfoPopup Create(ShopTradeProductData.CommonShopItemData.PackContentType contentType)
	{
		return null;
	}

	protected override void Start()
	{
	}

	public void OnOKButtonPressed()
	{
	}

	public static void SwitchToSustainableItem(ShopTradeProductData.CommonShopItemData.PackContentType packContentType)
	{
	}
}
