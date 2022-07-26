using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class EventInfoCtrlBase : MonoBehaviour
{
	[SerializeField]
	public Button howtoButton;

	[SerializeField]
	public Button scheduleButton;

	[SerializeField]
	public UIAnimationPublisher innerMovePublisher;

	[SerializeField]
	public RectTransform syncTopMask;

	protected virtual void Start()
	{
	}

	public virtual void SetEventInfo()
	{
	}

	public virtual void OnResetTopImageAndTalk()
	{
	}

	public void OnHowtoButtonTouched()
	{
	}

	public void OnScheduleButtonTouched()
	{
	}

	protected virtual void ResetSpecialHelpButtonPressedState()
	{
	}

	public void AdjustMoveOffset(float moveOffset)
	{
	}
}
