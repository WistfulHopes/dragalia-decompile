using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class RetryVoteDialog : InGameDialogBase
{
	public enum VoteState
	{
		Waiting,
		Accepted,
		Denied,
		Absence,
		Finish
	}

	[SerializeField]
	private RectTransform _adjustRt;

	[SerializeField]
	private Button _retryButton;

	[SerializeField]
	private Button _cancelButton;

	[SerializeField]
	private Image _retryButtonBgImage;

	[SerializeField]
	private Image _cancelButtonBgImage;

	[SerializeField]
	private Text _retryButtonText;

	[SerializeField]
	private Text _cancelButtonText;

	[SerializeField]
	private InGameGaugeUI _timeGauge;

	[SerializeField]
	private Image[] _voteImage;

	[SerializeField]
	private Color32[] _voteStateColor;

	[SerializeField]
	private Sprite _disableButtonBgImage;

	private VisibleUIObject _rootVisible;

	private int _actorIndex;

	private VoteState _voteState;

	private MultiPlayRetryVoteModel _retryVoteModel;

	private bool _isOpenRequested;

	public bool IsOpenRequested
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static RetryVoteDialog Create(GameObject parent)
	{
		return null;
	}

	public void Initialize()
	{
	}

	private void Update()
	{
	}

	private void SetActive(ref RectTransform rt, bool isActive)
	{
	}

	private void UpdateVoteIcon()
	{
	}

	public void RequestOpen()
	{
	}

	public void Open()
	{
	}

	public void Close(bool isPlayCloseSE = false)
	{
	}

	protected override void SetEnableButtons(bool b)
	{
	}

	public void OnRetryButtonPressed()
	{
	}

	private void ExecRetryButtonPressed(bool force = false)
	{
	}

	public void OnCancelButtonPressed()
	{
	}

	private void ExecCancelButtonPressed()
	{
	}

	private void DisableButtons()
	{
	}

	public void SetVoteIconColor(int index, VoteState state)
	{
	}

	public void SetTimeRate(float rate, bool immediate = false)
	{
	}
}
