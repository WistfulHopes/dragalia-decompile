using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public abstract class StrategyDialogBase : InGameDialogBase
{
	public class Param
	{
		public Action onClickRetryButton;

		public Action onClickRetireButton;

		public Action onClickCloseButton;
	}

	[SerializeField]
	protected RectTransform headRt;

	[SerializeField]
	protected RectTransform frameRt;

	[SerializeField]
	protected Text titleText;

	[SerializeField]
	protected Button retryButton;

	[SerializeField]
	protected Button retireButton;

	[SerializeField]
	protected Button closeButton;

	public Param param;

	protected RectTransform rootRt;

	protected Text retryButtonText;

	protected Text retireButtonText;

	protected Text closeButtonText;

	protected CommonDialog performanceModeDialog;

	protected CommonDialog.Param performanceModeDialogParam;

	protected InGameOptionPopup optionPopup;

	protected bool isSwap;

	protected virtual void Initialize()
	{
	}

	public virtual void Open()
	{
	}

	public virtual bool Close(bool isPlayCloseSE = false)
	{
		return default(bool);
	}

	public void OnCloseButtonPressed()
	{
	}

	protected virtual bool ExecCloseButtonPressed()
	{
		return default(bool);
	}

	public void OnRetryButtonPressed()
	{
	}

	protected virtual bool ExecRetryButtonPressed()
	{
		return default(bool);
	}

	public void OnRetireButtonPressed()
	{
	}

	protected virtual bool ExecRetireButtonPressed()
	{
		return default(bool);
	}

	public void OnOptionButtonPressed()
	{
	}

	protected void OnClosedButtonPressedFromOptionDialog()
	{
	}

	protected void OnClosedButtonPressedFromPerformanceModeDialog(CommonDialog dlg)
	{
	}

	protected override void SetEnableButtons(bool b)
	{
	}
}
