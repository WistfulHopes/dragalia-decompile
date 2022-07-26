using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class DrawSummonPopup : PopupBase
{
	private enum DrawSummonPage
	{
		normalPage,
		stoneSelectPage,
		ticketSelectPage,
		overSummonPointPage
	}

	[SerializeField]
	private Text okButtonText;

	[SerializeField]
	public GameObject[] drawSummonPages;

	[SerializeField]
	private Text titleText;

	[SerializeField]
	private Text legendTitleText;

	[SerializeField]
	private GameObject[] insufficientTextGOs;

	[SerializeField]
	private GameObject purchaseStoneImage;

	[SerializeField]
	private GameObject usePaidStoneImage;

	[SerializeField]
	private Text[] insufficientTexts;

	[SerializeField]
	public GameObject stonePriceLine;

	public GameObject paidStonePriceLine;

	public GameObject ticketPriceLine;

	[SerializeField]
	private GameObject singleTicketIcon;

	[SerializeField]
	private GameObject multiTicketIcon;

	[SerializeField]
	private GameObject startDashTicketIcon;

	[SerializeField]
	private GameObject dragonSsrTicketIcon;

	[SerializeField]
	private GameObject charaUpdateSsrTicketIcon;

	[SerializeField]
	private GameObject dragonUpdateSsrTicketIcon;

	[SerializeField]
	public Button okButton;

	public Button cancelButton;

	public Button closeButton;

	public Button stoneButton;

	public Button paidStoneButton;

	public Button ticketsButton;

	public Button tenTicketsButton;

	[SerializeField]
	private Text priceText;

	public Text selectableText;

	public Text[] onButtonStonePriceTexts;

	public GameObject insufficientStonePriceGO;

	public GameObject insufficientPaidStonePriceGO;

	public GameObject normalStonePriceGO;

	public GameObject normalPaidStonePriceGO;

	[SerializeField]
	private Text[] ownedCountTexts;

	[SerializeField]
	private Text[] ownedPaidCountTexts;

	[SerializeField]
	private Text[] afterCountTexts;

	[SerializeField]
	private GameObject ownedUIBase;

	[SerializeField]
	private Text[] summonCeilingItemTexts;

	[SerializeField]
	private Text summonExchangeLimit;

	[SerializeField]
	private Transform exchangeSummonIconTrans;

	[SerializeField]
	private GameObject[] exchangeNode;

	[SerializeField]
	private Image summonExchangeDoubleImage;

	[SerializeField]
	private CommonSliderSelection ticketSlider;

	[SerializeField]
	private RectTransform frame;

	[SerializeField]
	private float specifiedCommercialFrameY;

	[SerializeField]
	private GameObject endDateTimeLine;

	[SerializeField]
	private Text endDateTimeText;

	[SerializeField]
	private GameObject specifiedCommercialActObj;

	[SerializeField]
	private Text specifiedCommercialTransactionActText;

	[SerializeField]
	private Text specifiedCommercialActInformationText;

	[SerializeField]
	private RectTransform frame2;

	[SerializeField]
	private float specifiedCommercialFrameY2;

	[SerializeField]
	private GameObject endDateTimeLine2;

	[SerializeField]
	private Text endDateTimeText2;

	[SerializeField]
	private GameObject specifiedCommercialActObj2;

	[SerializeField]
	private Text specifiedCommercialTransactionActText2;

	[SerializeField]
	private Text specifiedCommercialActInformationText2;

	private SummonScene scene;

	private int summonId;

	private SummonTopItemData.ButtonType buttonType;

	private SummonTopItemData itemData;

	private bool isNormalPage;

	private bool isPaidStone;

	private bool isUsingTicket;

	private int multiSingleTicketCount;

	private const int summonCount10 = 10;

	public static DrawSummonPopup Create(SummonScene scene, SummonTopItemData itemData, SummonTopItemData.ButtonType buttonType)
	{
		return null;
	}

	public static DrawSummonPopup CreateOverSummonpopup(SummonTopItemData itemData)
	{
		return null;
	}

	private void SwitchToSelectPage()
	{
	}

	private void SwitchToTicketSelectPage()
	{
	}

	private void SwitcPages(DrawSummonPage pages)
	{
	}

	private void SetupByItemData(SummonTopItemData itemData, SummonTopItemData.ButtonType buttonType)
	{
	}

	public static bool DoesShowSpecifiedCommcialTransactionOnDiamondConsume()
	{
		return default(bool);
	}

	private void SetSpecifiedCommcialTransactionAct(SummonTopItemData itemData)
	{
	}

	public void SetContentOverSummonPoint(SummonTopItemData itemData)
	{
	}

	private void DisplayInsufficientInfo(bool hasEnoughStone, bool hasEnoughPaidStone, bool isSelectable, bool isUsingTicket, int afterCount, int afterPaidCount, bool isExchangeSummon)
	{
	}

	public void SummonPointIcon()
	{
	}

	private void OnStoneOKButtonClicked()
	{
	}

	private void OnTicketOKButtonClicked()
	{
	}

	public void OnOKButtonClicked()
	{
	}

	public void OnStoneOKButtonPressed()
	{
	}

	public void OnPaidStoneOKButtonPressed()
	{
	}

	public void OnCloseButtonClicked()
	{
	}

	public void ClosePopup([Optional] Action onFinished)
	{
	}

	public void OnValueChanged(float f)
	{
	}

	public void OnMaxValueChange()
	{
	}

	public void OnSummonSingleTicketsButtonPressed()
	{
	}

	public void OnSummonMultiTicketsButtonPressed()
	{
	}

	public void OnSummonPointExchangeButtonPressed()
	{
	}

	public void OnSpecifiedCommercialTransactionActPressed()
	{
	}
}
