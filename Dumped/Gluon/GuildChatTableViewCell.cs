using System;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class GuildChatTableViewCell : TableViewCell<GuildChatModel.ChatTableViewData>
{
	[SerializeField]
	public RectTransform cellFrame;

	[SerializeField]
	private GameObject[] panels;

	[SerializeField]
	private CommonIcon[] icons;

	[SerializeField]
	private Text[] nameTexts;

	[SerializeField]
	private Text[] timeTexts;

	[SerializeField]
	private Text[] normalTexts;

	[SerializeField]
	private CommonIcon[] stamps;

	[SerializeField]
	private GameObject[] normalFrames;

	[SerializeField]
	private GameObject[] stampFrames;

	[SerializeField]
	private GameObject dateChangeObject;

	[SerializeField]
	private Text dateChangeText;

	[SerializeField]
	private LayoutElement[] textWrapLayoutElements;

	[SerializeField]
	public Animator[] animators;

	[SerializeField]
	private GuildChatAnimationSupport[] animationSupporters;

	[SerializeField]
	private PointerEventHandler[] pointerEventHandlers;

	[SerializeField]
	private GameObject reportButtonGroup;

	[SerializeField]
	private LayoutElement sizeKeeper;

	private const float textBoxMaxWidth = 400f;

	private const int othersPanelNum = 0;

	private const int ownPanelNum = 1;

	private const int textOnlyPanelNum = 2;

	private int panelNum;

	private const int maxRetryTime = 4;

	private GameObject panel => null;

	private CommonIcon icon => null;

	private Text nameText => null;

	private Text timeText => null;

	private Text normalText => null;

	private CommonIcon stamp => null;

	private GameObject normalFrame => null;

	private GameObject stampFrame => null;

	private LayoutElement textWrapLayoutElement => null;

	private Animator animator => null;

	private GuildChatAnimationSupport animationSuppoter => null;

	private PointerEventHandler pointerEventHandler => null;

	private void Update()
	{
	}

	public override void UpdateContent(GuildChatModel.ChatTableViewData data)
	{
	}

	public void UpdateContent(GuildChatModel.ChatTableViewData data, bool isForceRebuild)
	{
	}

	private void SelectIconPanel(bool isMine)
	{
	}

	private void SelectTextOnlyPanel()
	{
	}

	private void SetPanel()
	{
	}

	private void SetIcon(GuildModel.ProfileIconData iconData)
	{
	}

	private void SetName(string name)
	{
	}

	private void SetText(string text)
	{
	}

	private void SetStamp(int stampId)
	{
	}

	private void SetTime(DateTime time)
	{
	}

	private void SetFrame(GuildChatModel.ContentType contentType)
	{
	}

	private void SetDataChangeObject(bool isDateCHange, DateTime time)
	{
	}

	private void SetReportButtonObject(bool isReportState)
	{
	}

	private void SetMainContent(GuildChatModel.ChatTableViewData data)
	{
	}

	private void SetSystemMessage(GuildChatModel.ChatTableViewData data)
	{
	}

	private void SetMultiLink(GuildChatModel.ChatTableViewData data)
	{
	}

	private string GetMultiplayLinkText(bool isFull, int nemberCount, int questId)
	{
		return null;
	}

	private void SetTextAreaSize()
	{
	}

	public GuildChatModel.ChatTableViewData GetData()
	{
		return null;
	}

	private void ClearPointerEvent()
	{
	}

	private void SetLongPressReportButton(GuildChatModel.ChatTableViewData data)
	{
	}

	private void SetSpeechButton(string text)
	{
	}

	private void SetJoinButton(GuildChatModel.ChatTableViewData data)
	{
	}

	private void OnLongPressReportButtonPressed(GuildChatModel.ChatTableViewData data)
	{
	}

	public void OnReportButtonPressed()
	{
	}

	public void OnReportCancelButtonPressed()
	{
	}

	private void OnJoinButtonPressed(GuildChatModel.ChatTableViewData data)
	{
	}

	private void OnMatchingGetRoomNameSuccess(MatchingGetRoomNameResponse res)
	{
	}

	private void OnMatchingGetRoomNameError(ErrorType errorType, int resultCode)
	{
	}

	private void SetAnimationWaitState(GuildChatModel.ChatTableViewData data)
	{
	}

	private void KeepCellSize(GuildChatModel.ChatAnimationWaitMode animationWaitState, Vector2 size)
	{
	}

	public void OnStampClick()
	{
	}

	private void PlayStampVoice(int stampId)
	{
	}
}
