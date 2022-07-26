using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon;

public class PurchaseShopItemPopup : ShopCommonPopup
{
	[SerializeField]
	public PurchaseShopItemTableViewController tableview;

	[SerializeField]
	public Transform topPart;

	public Text ownedPaidStoneText;

	private UnityAction onCloseCallbak;

	public static void CreateModule(GiftType giftType, [Optional] UnityAction OnOkCallback, bool connect = false)
	{
	}

	public void SetContent(GiftType giftType)
	{
	}

	public void popupUpdate()
	{
	}

	public override void OnCloseButtonPressed()
	{
	}
}
