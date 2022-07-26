using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class QuestSkillButton : QuestSkillButtonBase
{
	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _invalidRt;

	[SerializeField]
	private RectTransform _noUseRt;

	[SerializeField]
	private RectTransform _offsetRt;

	[SerializeField]
	private RectTransform _effectRt;

	[SerializeField]
	private RectTransform _shadowRt;

	[SerializeField]
	private RectTransform[] _countRt;

	[SerializeField]
	private RectTransform _readyAnimFrameRt;

	[SerializeField]
	private RectTransform _changeAnimRt;

	[SerializeField]
	private RectTransform _changeAnimMaxLevelRt;

	[SerializeField]
	private InGameAnimUI _changeAnimGlowUI;

	[SerializeField]
	private InGameAnimUI _changeAnimFlareUI;

	[SerializeField]
	private InGameAnimUI[] _changeAnimGlitterUI;

	[SerializeField]
	private InGameAnimUI _changeAnimIconUI;

	[SerializeField]
	private Button _button;

	[SerializeField]
	private SpriteRenderer _iconImage;

	[SerializeField]
	private SpriteRenderer _changeAnimIconImage;

	[SerializeField]
	private SpriteRenderer _effectImage;

	[SerializeField]
	private SpriteRenderer _readyAnimFrameImage;

	[SerializeField]
	private float _expansionTime;

	[SerializeField]
	private int _flashCount;

	[SerializeField]
	private float _flashTime;

	[SerializeField]
	private float _maxFlashPower;

	[SerializeField]
	private float _readyAnimMaxFlashPower;

	[SerializeField]
	private CreateIconParam[] _iconParams;

	private VisibleUIObject _rootVisible;

	private VisibleUIObject _invalidVisible;

	private VisibleUIObject _noUseVisible;

	private VisibleUIObject _readyAnimFrameVisible;

	private VisibleUIObject _changeAnimVisible;

	private VisibleUIObject _changeAnimMaxLevelVisible;

	private ManagementMultipleIconData _data;

	private ManagementIconData _iconData;

	private Tweener _twExpansion;

	private Tweener _twEffectFlash;

	private bool _isLeft;

	private bool _isIconCreated;

	private const float TweenerExpansionEndValue = 1f;

	public static QuestSkillButton Create(GameObject parent, int index, Action<QuestSkillButtonBase> onClick, bool isLeft)
	{
		return null;
	}

	public void Initialize(Action<QuestSkillButtonBase> onClick, bool isLeft)
	{
	}

	public void OnDestroy()
	{
	}

	public override void FastUpdate()
	{
	}

	public override bool ApplyIcon(InGameUIConst.QuestSkillType type)
	{
		return default(bool);
	}

	public bool LoadIcon(string[] iconNames)
	{
		return default(bool);
	}

	public override bool ChangeIcon(int iconIndex, bool isForce, bool isFlashAnim = true)
	{
		return default(bool);
	}

	public override int GetIconNum()
	{
		return default(int);
	}

	public override int GetIconIndex()
	{
		return default(int);
	}

	private void SetIconRate(float rate, bool isForce = false, bool isAnim = true)
	{
	}

	public override void SetIconRateManual(float rate, bool isForce = false)
	{
	}

	public override float GetIconRate()
	{
		return default(float);
	}

	public override void Visible(bool b)
	{
	}

	public override bool IsVisible()
	{
		return default(bool);
	}

	public override void Validate(bool b, bool force = false)
	{
	}

	private void CheckInvalidObj()
	{
	}

	public override int GetCount()
	{
		return default(int);
	}

	public override void SetCount(int n)
	{
	}

	public override int GetMaxCount()
	{
		return default(int);
	}

	public override void SetUnlimited()
	{
	}

	public override bool IsUnlimited()
	{
		return default(bool);
	}

	public override void SetReadyAnim(ReadyAnimType type)
	{
	}

	public override bool IsReadyAnim()
	{
		return default(bool);
	}

	public override void SetupReadyAnim(Material frameMat)
	{
	}

	public override void SetVisibleReadyAnim(bool b)
	{
	}

	public override bool IsActiveReadyAnim()
	{
		return default(bool);
	}

	public override void OnUpdateReadyAnimFlash(float value)
	{
	}

	public override void SetChangeAnim()
	{
	}

	public override bool IsChangeAnim()
	{
		return default(bool);
	}

	private void PlayChangeAnim()
	{
	}

	private void StopChangeAnim()
	{
	}

	private void OnCompleteChangeAnim()
	{
	}

	private void PlayExpansionAnim()
	{
	}

	private void OnUpdateExpansion(float value)
	{
	}

	private void OnCompleteExpansion()
	{
	}

	private void OnUpdateButtonEffectFlash(float value)
	{
	}

	public override void SetOnClick(Action onClick)
	{
	}

	public override void CopyData(ManagementMultipleIconData data)
	{
	}

	public override void ApplyData(ManagementMultipleIconData data)
	{
	}
}
