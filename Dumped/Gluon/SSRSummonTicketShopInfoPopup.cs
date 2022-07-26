using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class SSRSummonTicketShopInfoPopup : PopupBase
{
	public class PackModel
	{
		private static PackModel instance;

		public int diamondCount;

		public List<int> ssrTicketIds;

		public List<SummonTicketShopInfo> summonTicketShopItems;

		public int price;

		public long completeDate;

		public int tradeId;

		public string productId;

		public ShopTradeProductData.CommonShopItemData data;

		public static PackModel Instance => null;

		public static void DeleteInstance()
		{
		}

		private PackModel()
		{
		}

		static PackModel()
		{
		}
	}

	public class SummonTicketShopInfo
	{
		public int id;

		public GiftType type;

		public int count;
	}

	public RectTransform frame;

	[SerializeField]
	public Text titleText;

	public Text topText;

	[SerializeField]
	public RawImage image;

	[SerializeField]
	public CommonIcon diamondIcon;

	public Text[] ssrTicketNames;

	public CommonIcon[] ssrTicketIcons;

	public GameObject[] ssrTicketIconGOs;

	[SerializeField]
	public Button purchaseButton;

	[SerializeField]
	public Text limitCountText;

	public Text priceText;

	public Text insufficientText;

	[SerializeField]
	public GameObject[] charaDescriptionGOs;

	public GameObject[] dragonDescritptionGOs;

	[SerializeField]
	public GameObject specifiedCommercialActObj;

	public Text specifiedCommercialTransactionActText;

	public GameObject specifiedCommercialActInformation;

	public float specialOffset;

	public Text specifiedCommercialActInformationText;

	private Action onPurchaseDone;

	private const string imagePathTemplate = "Images/OutGame/Shop/Top/SummonTicketPack/{0}";

	public static void CreateModule(ShopTradeProductData.CommonShopItemData item, Action onPurchaseDone)
	{
	}

	private void Setup()
	{
	}

	public void OnOddsButtonClicked(int i)
	{
	}

	public void OnPurchaseButtonClicked()
	{
	}

	public void OnSpecifiedCommercialTransactionActPressed()
	{
	}
}
