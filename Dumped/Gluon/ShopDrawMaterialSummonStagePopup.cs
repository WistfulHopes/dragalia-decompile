using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class ShopDrawMaterialSummonStagePopup : PopupBase
{
	[SerializeField]
	public Text priceText;

	public Text holdingText;

	[SerializeField]
	public GameObject[] iconPosList;

	[SerializeField]
	public GameObject sendToPresentBoxGO;

	[SerializeField]
	public GameObject redrawLayoutGO;

	public GameObject backButtonGO;

	[SerializeField]
	public GameObject firstViewBottomItemNode;

	[SerializeField]
	public UIAnimationPublisher majorEnterPublisher;

	public UIAnimationPublisher exitPubliser;

	public UIAnimationPublisher subExitPubliser;

	[SerializeField]
	public FlashPlayerManager flashPlayerManager;

	[SerializeField]
	public RawImage flashTextureImage;

	public float halfCutoffDuration;

	public float maximumCutoffDuration;

	private int price;

	private Action onDraw;

	private List<EntityData> resultData;

	private Camera flashCamera;

	private Camera oldFlashCamera;

	private FlashPlayer[] itemFallFlashPlayers;

	private FlashPlayer backFlashPlayer;

	private const string backFlashPath = "Prefabs/OutGame/ShopTrade/Flash/MaterialSummon/pf_ShopSummonMaterialBackLight";

	private const string frontFlashPath = "Prefabs/OutGame/ShopTrade/Flash/MaterialSummon/pf_ShopSummonMaterialLightImpact";

	public static readonly Vector2[] iconPositions;

	public static ShopDrawMaterialSummonStagePopup Create(Camera flashCamera, List<EntityData> resultData, int price, Action onDraw)
	{
		return null;
	}

	protected override void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	public static Vector3 GetFlashPositionFromLayoutPosition(Vector2 pos)
	{
		return default(Vector3);
	}

	private IEnumerator ShowResultCoroutine()
	{
		return null;
	}

	private void DestroyItemFallFlashPlayers()
	{
	}

	public void OnSummonButtonPressed()
	{
	}

	public void OnBackButtonPressed()
	{
	}

	private void PlayExitAnimation(Action onFinished)
	{
	}
}
