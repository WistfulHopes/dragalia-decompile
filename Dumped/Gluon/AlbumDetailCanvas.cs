using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class AlbumDetailCanvas : MonoBehaviour
{
	[HideInInspector]
	public UnitDetailScene detailScene;

	[SerializeField]
	public Viewer2DCanvas viewer2DCanvas;

	[SerializeField]
	public Viewer3DCanvas viewer3DCanvas;

	[SerializeField]
	public RawImageWithAlphaBlend modelViewImage;

	[SerializeField]
	public UIAnimationPublisher mainPublisher;

	[SerializeField]
	public UIAnimationPublisher quitPublisher;

	[SerializeField]
	public GameObject viewerButtons;

	[SerializeField]
	public Image cvNameBase;

	[SerializeField]
	public Button voiceButton;

	[SerializeField]
	private Image seasonVoiceButtonImage;

	[SerializeField]
	private Button seasonVoiceButton;

	[SerializeField]
	public GameObject artistNameBase;

	public RawImage artistNameImage;

	[SerializeField]
	private UnitDetail2dModel unitImage;

	[SerializeField]
	private RectTransform imageOffset;

	[SerializeField]
	public Transform switchEffectAttachPoint;

	[SerializeField]
	public GameObject switchButton;

	[SerializeField]
	public Text switchText;

	[SerializeField]
	public GameObject switchChangeDragonButton;

	[SerializeField]
	public Text switchChangeDragonText;

	[SerializeField]
	public GameObject switchSubButton;

	[SerializeField]
	public Button[] fullScreenButtons;

	public UIAnimationPublisher fullScreenModePublisher;

	public Image[] viewPageButtonsRaycast;

	[SerializeField]
	private Image rareIcon;

	[SerializeField]
	private Image elementalIcon;

	[SerializeField]
	private Image weaponTypeIcon;

	[SerializeField]
	private Text anotherName;

	[SerializeField]
	private Text anotherNameRuby;

	[SerializeField]
	private Text unitName;

	[SerializeField]
	private Button albumMemoryPopupButton;

	[SerializeField]
	private Text unitLevel;

	[SerializeField]
	private Text unitLevelTitle;

	[SerializeField]
	private Text unitManaCircle;

	[SerializeField]
	private Text unitManaCircleTitle;

	[SerializeField]
	private Text maxLimitBreakCount;

	[SerializeField]
	private Text maxLimitBreakCountTitle;

	[SerializeField]
	private Text reliabilityLevel;

	[SerializeField]
	private Text reliabilityLevelTitle;

	[SerializeField]
	private List<GameObject> allAchievementObj;

	[SerializeField]
	private List<GameObject> charaAchievementObj;

	[SerializeField]
	private List<GameObject> dragonAchievementObj;

	[SerializeField]
	private GameObject achievementParentObj;

	[SerializeField]
	private Button growthMenuButton;

	[SerializeField]
	private Button medalButton;

	[SerializeField]
	private Button profileButton;

	[SerializeField]
	private Button viewerModeButton;

	private bool switchSubButtonEnabled;

	private Canvas canvas;

	private int talkIndex;

	private string[] voiceNames;

	private string voiceSheetName;

	private AudioPlayback characterVoice;

	private FlashPlayerManager flashPlayerManager;

	private FlashPlayer switchFlashPlayer;

	private string seasonVoiceSheetName;

	private string seasonVoiceName;

	private AudioPlayback seasonCharacterVoice;

	private int currentNormalizedIndex;

	private List<int> switchableNormalizedIdList;

	private Color statusLevelDefaultTextColor;

	private Color statusLevelMaxTextColor;

	private Color statusLevelMax2TextColor;

	public bool isFullScreenMode
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public int sortingOrder => default(int);

	private void Awake()
	{
	}

	private void Start()
	{
	}

	protected void OnDestroy()
	{
	}

	public void SetUnit2DImage(int forceSubId = -1)
	{
	}

	private void SetChangeDragonButton()
	{
	}

	private void SetGrowthMenuButton()
	{
	}

	private void SetMedalButton()
	{
	}

	private void SetViewerModeButton()
	{
	}

	private void SetProfileButton()
	{
	}

	private void SetMemoryButton()
	{
	}

	private void SetAlbumStatus()
	{
	}

	private void SetAchievementObj()
	{
	}

	private void SetLockButton()
	{
	}

	private void SetSwitchSubButton()
	{
	}

	public void CVButtonPressed()
	{
	}

	private void SetCVAndArtistBaseData(out string voiceSheetName, out string[] voiceNames)
	{
	}

	public void SeasonVoiceButtonPressed()
	{
	}

	private void SetSeasonVoiceData(out string voiceSheetName, out string voiceNames)
	{
	}

	private void LoadVoiceGroup(string voiceSheetName, Image cvNameBase, Button voiceButton)
	{
	}

	public void OnMemoryButton()
	{
	}

	public void OnProfileButton()
	{
	}

	public void OnMedalButton()
	{
	}

	public void ToggleSwitchSubButton(bool toEnable)
	{
	}

	public void OnViewerButtonPressed()
	{
	}

	public void OnSwitchViewModeButtonPressed()
	{
	}

	public void SwitchTo3DMode()
	{
	}

	public void SwitchTo2DMode()
	{
	}

	public void OnReturnFromViewMode()
	{
	}

	public void PlayEnterAnimation()
	{
	}

	public void PlayExitAnimation()
	{
	}

	public void SetUnitModel()
	{
	}

	public void OnSwitchSubButtonPressed()
	{
	}

	public void EnableFullScreenButton(bool toEnable)
	{
	}

	public void OnFullScreenButtonPressed()
	{
	}

	public void ToggleFullScreen(bool withBackButton = true)
	{
	}

	private void ButtonLaycastSetting(bool isLayCast)
	{
	}

	public void OnSwitchChangeDragonButton()
	{
	}

	private void MultipleCharacterSwitchButtonAction()
	{
	}

	public void SetSwitchChangeButtonText(int charaId, UnitDetailScene.MultipleCharacter3DMode mode)
	{
	}

	private void SwitchChangeDragonButtonText()
	{
	}

	private void SwitchChangeDefaultDragonButtonText()
	{
	}

	public void OnGrowthMenuPressed()
	{
	}

	public void PlaySwitchFlash()
	{
	}
}
