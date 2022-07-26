using System;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class QuestSkillButtonSelector : QuestSkillButtonBase
{
	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _buttonRootRt;

	[SerializeField]
	private float _outsideInitialPosX;

	[SerializeField]
	private float _moveTime;

	[SerializeField]
	private Ease _showMoveEase;

	[SerializeField]
	private Ease _hideMoveEase;

	[SerializeField]
	private CreateButtonParam[] _buttonParams;

	private VisibleUIObject _rootVisible;

	private Tweener _twMove;

	private Tweener _twButtonMove;

	private QuestSkillButton[] _buttons;

	private Action<QuestSkillButtonBase> _onClick;

	private ManagementMultipleButtonData _data;

	private int _showTargetIndex;

	private int _hideTargetIndex;

	private bool _isLeft;

	private bool _isIconCreated;

	public static QuestSkillButtonSelector Create(GameObject parent, int index, Action<QuestSkillButtonBase> onClick, bool isLeft)
	{
		return null;
	}

	public void Initialize(Action<QuestSkillButtonBase> onClick, bool isLeft)
	{
	}

	public void OnDestroy()
	{
	}

	public override bool ApplyIcon(InGameUIConst.QuestSkillType type)
	{
		return default(bool);
	}

	public override bool ChangeIcon(int iconIndex, bool isForce, bool isFlashAnim = true)
	{
		return default(bool);
	}

	public override bool ChangeIcon(int buttonIndex, int iconIndex, bool isForce, bool isFlashAnim = true)
	{
		return default(bool);
	}

	public override void Show(bool isForce = false, bool isImmediate = false)
	{
	}

	public override void Hide(bool isForce = false, bool isImmediate = false)
	{
	}

	public override void SetIconRateManual(float rate, bool isForce = false)
	{
	}

	public override void SetIconRateManual(int buttonIndex, float rate, bool isForce = false)
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

	public override void SetCount(int buttonType, int n)
	{
	}

	public override void ChangeButton(int buttonType, bool isImmediate = false)
	{
	}

	public override int GetButtonType()
	{
		return default(int);
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

	public override void SetOnClick(int buttonType, Action onClick)
	{
	}

	public override void CopyDara(ManagementMultipleButtonData data)
	{
	}

	public override void ApplyData(ManagementMultipleButtonData data)
	{
	}
}
