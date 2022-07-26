using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon;

public class SummonScene : SceneBase
{
	public struct CameraAndImageEffectPlayer
	{
		public bool camera;

		public bool imageEffectPlayer;
	}

	[SerializeField]
	private GameObject world3dRoot;

	[SerializeField]
	private GameObject canvasRoot;

	[SerializeField]
	public EdgeToEdgeFrame edgeToEdgeFrame;

	[SerializeField]
	private GameObject httpGreenLight;

	[SerializeField]
	public GameObject topNode;

	public GameObject stageResultNode;

	public GameObject stage3dNode;

	public GameObject resultOutOfCanvasNode;

	[SerializeField]
	public Canvas canvas;

	[SerializeField]
	public Transform cameraParent;

	public Transform cameraParentDragon;

	[SerializeField]
	public SummonPostEffectSetting postEffectSetting;

	public SummonPostFilmSetting postFilmSetting;

	[SerializeField]
	public Camera bg3dCamera;

	public Camera character3dCamera;

	public Camera shot2CharaWeaponCamera;

	[SerializeField]
	public Camera mainUIStageCamera;

	public GameObject postEffectCameraGO;

	[SerializeField]
	public Camera resultFlashCamera;

	private Vector3 resultFlashCameraInitPosition;

	public SummonUnitShaderSettings unitShaderSettings;

	public KeepStableToTransform bg3dCameraKeepComponent;

	private bool initEnterSceneDone;

	private bool isTutorialRequired;

	public bool isExitStarted;

	private int uiCameraCullingMask;

	private SummonTop topView;

	private bool firstEnterScene;

	private bool fadeOutPrepare;

	public static bool isGetCurrencyCodeSucceeded;

	private CameraAndImageEffectPlayer mainUIStageCameraEnable;

	private CameraAndImageEffectPlayer charaCameraEnable;

	private CameraAndImageEffectPlayer postEffectFlashCameraEnable;

	private CameraAndImageEffectPlayer shot2CharaWeaponFlashCameraEnable;

	private CameraAndImageEffectPlayer bg3DCameaEnable;

	private CameraAndImageEffectPlayer resultFlashCameraEnable;

	[HideInInspector]
	public UnityEvent onBeforeStartExitAnimation;

	public SummonResult resultView
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private IEnumerator Start()
	{
		return null;
	}

	public void ResetResultFlashCameraToInitPosition()
	{
	}

	public void SetMainUIStageCameraCullMask(bool toNothing)
	{
	}

	private void OnPrevSceneExitDone()
	{
	}

	private void OnInitReadyRequestHttp()
	{
	}

	private void OnEnterScene()
	{
	}

	public void OnChangedBackgroundShaderParameter()
	{
	}

	public void RequestSummonTop()
	{
	}

	public static void RequestPaymentGetListForGetCurrencySymbol(UnityAction successCallback, UnityAction failedCallback)
	{
	}

	private void OnRequestSummonTopSuccess(SummonGetSummonListResponse res)
	{
	}

	private void OnRequestSummonTopSuccessCallback()
	{
	}

	private void LoadTopBGView()
	{
	}

	private void SetupCameraForTopView()
	{
	}

	private void SetupCameraForStage()
	{
	}

	private void LoadTopView()
	{
	}

	private void SetupTutorialState()
	{
	}

	private void StartTutorial()
	{
	}

	private IEnumerator Tutorial_1_1_SummonIn()
	{
		return null;
	}

	private IEnumerator Tutorial_1_1_SelectSummonIn()
	{
		return null;
	}

	private IEnumerator Tutorial_1_1_SummonDone()
	{
		return null;
	}

	private IEnumerator Tutorial_SummonExchangeStart()
	{
		return null;
	}

	public void OnSummonButton(SummonTopItemData.ButtonType buttonType, int summonId)
	{
	}

	public void OnDrawSummonButtonClicked(SummonTopItemData.ButtonType buttonType, int summonId, bool paidStone, int useMultiSingleTicketCount)
	{
	}

	public void RequestDrawSummon(bool paidStone)
	{
	}

	public void OnRequestSummonRequestSuccess(SummonRequestResponse res)
	{
	}

	public void GoExcludeSummon()
	{
	}

	public void RequestSummonExcludeRequest(int summonId, GiftType type, List<int> entityList)
	{
	}

	public void Tutorial(int id)
	{
	}

	private IEnumerator LoadResultView()
	{
		return null;
	}

	private void LoadStageView()
	{
	}

	public void OnStageDone()
	{
	}

	private void DestroyChildren(Transform t)
	{
	}

	public override void StartExitAnimation()
	{
	}

	public override void OnBeforeLeaving()
	{
	}

	public void OnDestroy()
	{
	}

	public override void OnPopupOpened()
	{
	}

	public override void OnPopupClosed()
	{
	}

	public void SetupResultRenderCamera(bool isEnable, [Optional] RenderTexture bgRenderTexture, [Optional] RenderTexture charaRenderTexture)
	{
	}

	public void SetupStageRenderCamera(bool isEnable, [Optional] RenderTexture shot2CharaWeaponRenderTexture)
	{
	}

	public override void OnPresentReceived()
	{
	}

	public void SetOffCamera()
	{
	}

	public void SetOnCamera()
	{
	}

	public void SaveOffCamera(Camera camera, out CameraAndImageEffectPlayer player)
	{
	}

	public void LoadCamera(Camera camera, CameraAndImageEffectPlayer player)
	{
	}
}
