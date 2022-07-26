using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class ShopTradeTopView : ShopTradePanelBase
{
	[SerializeField]
	public PageViewBase pageView;

	public GameObject pageViewNode;

	[SerializeField]
	public GameObject materialSummonBadge;

	public GameObject amuletNewIcon;

	public GameObject diaRecommendedIcon;

	[SerializeField]
	public GameObject campaignButtonGO;

	public ButtonWithSelectedImage campaignButtonWithSelectedImage;

	[SerializeField]
	public Image centerBannerBGImage;

	public MaintenanceButtonController centerBGMaintenanceButton;

	public Text centerBannerText;

	[SerializeField]
	public GameObject starterPackSubBanner;

	public GameObject commonPackSubBanner;

	public GameObject sustainablePackButtonRoot;

	public GameObject diaButtonRoot;

	public GameObject dailyDiaButtonRoot;

	public GameObject dailyStaminaButtonRoot;

	public GameObject doubleBonusButtonRoot;

	public GameObject dailyBGRootBefore;

	public Image itemButtonNormalImage;

	public Image itemButtonPressedImage;

	public Sprite itemButtonNormalSpriteAf;

	public Sprite itemButtonPressedSpriteAf;

	public GameObject topBannerObj;

	public GameObject centerBannerObj;

	public GameObject centerButtonObj;

	private float diaEndOffset;

	private const float autoMoveTime = 8f;

	private float moveTimer;

	private bool autoMove;

	private GameObject preLoadedPage;

	private ShopTopBannerModel.BannerData centerData;

	public static ShopTradeTopView Create(Transform parent, ShopTradeScene scene)
	{
		return null;
	}

	public static bool IsDiaEnd()
	{
		return default(bool);
	}

	public static void RequestForEntryHttp(Action onHttpDoneCallback)
	{
	}

	private void Awake()
	{
	}

	private static bool IsShowDailyDiaButton()
	{
		return default(bool);
	}

	private bool IsShowDailyStaminaButton()
	{
		return default(bool);
	}

	private bool IsShowQuestBonusButton()
	{
		return default(bool);
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void SetSubBanner()
	{
	}

	private void SetCenterBannerBG(ShopTopBannerModel.BannerData data)
	{
	}

	public void OnCenterBannerPressed()
	{
	}

	private void GenerateCenterBanners()
	{
	}

	private void Update()
	{
	}

	public void CheckAmuletNewBadge()
	{
	}

	public void CheckDiaRecommendedBadge()
	{
	}

	public void OnCampainButtonPressed()
	{
	}

	public override void RefreshCurrentPage()
	{
	}

	private void SetSustainableUIActive()
	{
	}
}
