using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class DmodeNextFloorConfirmDialog : InGameDialogBase
{
	public class Param
	{
		public Action<Action> onClickInventoryButton;

		public Action<Action> onClickSkillButton;

		public Action onClickNextFloorButton;

		public Action onClickCancelButton;
	}

	[SerializeField]
	private RectTransform headRt;

	[SerializeField]
	private RectTransform frameRt;

	[SerializeField]
	private Toggle announceStar5Toggle;

	[SerializeField]
	private Toggle announceStar4Toggle;

	[SerializeField]
	private Toggle announceStar3Toggle;

	[SerializeField]
	private Toggle announceSkillToggle;

	[SerializeField]
	private Button nextFloorButton;

	[SerializeField]
	private Button cancelButton;

	public Param param;

	private RectTransform rootRt;

	public Action onClickNextFloorButtonExternal;

	public Action onClickCancelButtonExternal;

	public static DmodeNextFloorConfirmDialog Create(GameObject parent)
	{
		return null;
	}

	private void Initialize()
	{
	}

	public void Open(Action onClickNextFloorButtonExternal, Action onClickCancelButtonExternal)
	{
	}

	public bool Close(bool isPlayCloseSE = false, [Optional] Action onCloseComplete)
	{
		return default(bool);
	}

	protected override void SetEnableButtons(bool b)
	{
	}

	public void OnInventoryButtonPressed()
	{
	}

	public bool ExecInventoryButtonPressed()
	{
		return default(bool);
	}

	public void OnSkillButtonPressed()
	{
	}

	public bool ExecSkillButtonPressed()
	{
		return default(bool);
	}

	public void OnNextFloorButtonPressed()
	{
	}

	private bool ExecNextFloorButtonPressed()
	{
		return default(bool);
	}

	public void OnCancelButtonPressed()
	{
	}

	public void OnClickAnnounceStar5(bool value)
	{
	}

	public void OnClickAnnounceStar4(bool value)
	{
	}

	public void OnClickAnnounceStar3(bool value)
	{
	}

	public void OnClickAnnounceSkill(bool value)
	{
	}
}
