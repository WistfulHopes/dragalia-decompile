using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class GuildOptionPopup : PopupBase
{
	public enum Type
	{
		GuildCreation,
		GuildMasterEdit,
		GuildMemberEdit
	}

	public const string prefabPath = "Prefabs/OutGame/Guild/GuildOptionPopup";

	[SerializeField]
	public Text guildNameText;

	public Text guildMottoText;

	public Text guildNoticeText;

	public Text guildIdText;

	public RawImage guildEmblemImage;

	[SerializeField]
	public CommonSettingToggleBase[] approvalRequirementToggles;

	public CommonSettingToggleBase[] activityPreferenceToggles;

	[SerializeField]
	public CommonIcon icon;

	[SerializeField]
	public TabBase pushTab;

	public TabBase nativePushTab;

	[SerializeField]
	public TabBase inviteTab;

	[SerializeField]
	public TabBase voiceOverTab;

	[SerializeField]
	public GameObject nameGO;

	public GameObject mottoGO;

	public GameObject noticeGO;

	public GameObject emblemGO;

	public GameObject approvalRequirementGO;

	public GameObject activityPreferenceGO;

	public GameObject iconGO;

	public GameObject pushGO;

	public GameObject nativePushGO;

	public GameObject voiceOverGO;

	public GameObject guildIdGO;

	public GameObject disbandGuildGO;

	public GameObject leaveGuildGO;

	[SerializeField]
	public Button okButton;

	[SerializeField]
	private GameObject inviteBadge;

	private GuildModel.GuildOption initOption;

	private GuildModel.GuildOption option;

	private GuildModel.ProfileIconData initProfileIconData;

	private GuildModel.ProfileIconData profileIconData;

	private Type popupType;

	private Action onOptionDone;

	private Action onStopPollingAction;

	private readonly Color textColorBlack;

	private readonly Color textColorGray;

	public static GuildOptionPopup Create(GuildModel.Occupation occupation, [Optional] Action onOptionDone, [Optional] Action onStopPollingAction)
	{
		return null;
	}

	protected override void Start()
	{
	}

	public void SetupForCreation()
	{
	}

	public void SetupForMasterEdit()
	{
	}

	public void SetupForMemberEdit()
	{
	}

	private void ApplyData()
	{
	}

	private void ConvertOptionToDeletedRaw()
	{
	}

	public void OnNameChangeButtonPressed()
	{
	}

	public void OnMottoChangeButtonPressed()
	{
	}

	public void OnNoticeChangeButtonPressed()
	{
	}

	public void OnEmblemChangeButtonPressed()
	{
	}

	public void OnProfileIconButtonPressed()
	{
	}

	public void OnDisbandGuildButtonPressed()
	{
	}

	public void OnLeaveGuildButtonPressed()
	{
	}

	private void OnStopPolling()
	{
	}

	public void OnCopyIdButtonPressed()
	{
	}

	private void Update()
	{
	}

	public void OnApplyButtonPressed()
	{
	}

	public void OnCheckInviteButtonPressed()
	{
	}
}
