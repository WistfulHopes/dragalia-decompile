using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class WalkerQuestButton : FastUpdateMonoBehaviour
{
	public enum StatusType
	{
		PlayMode,
		PhotoMode
	}

	[SerializeField]
	private RectTransform offsetRt;

	[SerializeField]
	private RectTransform outSideOffsetRt;

	[SerializeField]
	private RectTransform playModeRt;

	[SerializeField]
	private RectTransform photoModeRt;

	[SerializeField]
	private RectTransform playModeInvalidRt;

	[SerializeField]
	private RectTransform photoModeInvalidRt;

	[SerializeField]
	private RectTransform offsetRt2;

	[SerializeField]
	private RectTransform outSideOffsetRt2;

	[SerializeField]
	private RectTransform photoModeRt2;

	[SerializeField]
	private RectTransform stampButtonRt;

	[SerializeField]
	private RectTransform photoModeInvalidRt2;

	[SerializeField]
	private Button photoButton;

	[SerializeField]
	private Button backButton;

	[SerializeField]
	private Button hideButton;

	[SerializeField]
	private CommonSliderSelection dofSlider;

	[SerializeField]
	private Image dofSliderFillImage;

	[SerializeField]
	private Image dofSliderHandleImage;

	[SerializeField]
	private Text dofSliderValueText;

	[SerializeField]
	private Button dofButton;

	private VisibleUIObject rootVisible;

	private VisibleUIObject playModeVisible;

	private VisibleUIObject photoModeVisible;

	private VisibleUIObject photoModeVisible2;

	private VisibleUIObject playModeInvalidVisible;

	private VisibleUIObject photoModeInvalidVisible;

	private VisibleUIObject photoModeInvalidVisible2;

	private Tweener _playModeTweener;

	private Tweener _photoModeTweener;

	private Vector3 _originOffsetPos;

	private Vector3 _originOffsetPos2;

	private Vector3 _originHideButtonPos;

	private Vector3 _originStampButtonPos;

	private bool _isLeft;

	private bool _inSide;

	private bool _isShow;

	private bool _isEnableDof;

	private Action<bool> _onChangeEnableDOF;

	private const long DOFMaxValue = 100L;

	private const long DOFMinValue = 0L;

	public RectTransform StampButtonRt => null;

	public StatusType Status
	{
		[CompilerGenerated]
		get
		{
			return default(StatusType);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static WalkerQuestButton Create(GameObject parent, bool isLeft, Action onClickPhotoMode, Action onClickBack, Action onClickHide, Action<float> onChangeDOF, Action<bool> onChangeEnableDOF, int index = -1)
	{
		return null;
	}

	private void SetDofSetting(bool enableDof)
	{
	}

	private void Initialize(bool isLeft, Action onClickPhotoMode, Action onClickBack, Action onClickHide, Action<float> onChangeDOF, Action<bool> onChangeEnableDOF)
	{
	}

	public void OnDestroy()
	{
	}

	public override void FastUpdate()
	{
	}

	private void UpdatePos()
	{
	}

	public void Visible(bool b)
	{
	}

	public bool IsVisible()
	{
		return default(bool);
	}

	public void Show(StatusType status, bool immediate = false, bool force = false)
	{
	}

	public void RedisplayForPhotoMode(bool immediate = false, bool force = false)
	{
	}

	public void HideForPhotoMode(bool immediate = false)
	{
	}

	private void ShowPlayMode(bool isShow, bool immediate)
	{
	}

	private void OnCompleteShowPlayModeIn()
	{
	}

	private void OnCompleteShowPlayModeOut()
	{
	}

	private void OnShowPlayMode(float rate)
	{
	}

	private void ShowPhotoMode(bool isShow, bool immediate, bool isApplyDofSetting)
	{
	}

	private void OnCompleteShowPhotoModeIn()
	{
	}

	private void OnCompleteShowPhotoModeOut()
	{
	}

	private void OnShowPhotoMode(float rate)
	{
	}

	public void SetLayout(bool isLeft, bool force = false)
	{
	}

	public void SetODFRate(float rate)
	{
	}

	public float GetDOFRate()
	{
		return default(float);
	}

	public void OnClickScreen()
	{
	}
}
