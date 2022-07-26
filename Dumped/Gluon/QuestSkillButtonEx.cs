using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class QuestSkillButtonEx : QuestSkillButtonBase
{
	[Serializable]
	public class AnimData
	{
		public Vector3 scale;

		public float animTime;

		public float afterWaitTime;

		public Ease ease;

		[HideInInspector]
		public Vector3 prevScale;
	}

	[Serializable]
	public class OffsetPosData
	{
		public Vector3 offsetPos_JP;

		public Vector3 offsetPos_EN_US;

		public Vector3 offsetPos_ZH_CN;

		public Vector3 offsetPos_ZH_TW;

		public Vector3 offsetPos_EN_EU;

		public Vector3 GetOffsetPos()
		{
			return default(Vector3);
		}
	}

	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _invalidRt;

	[SerializeField]
	private RectTransform _offsetRt;

	[SerializeField]
	private SpriteRenderer _iconImage;

	[SerializeField]
	private SpriteRenderer _bgImage;

	[SerializeField]
	private Button _button;

	[SerializeField]
	private Vector3 _outsideInitialPos;

	[SerializeField]
	private float _moveTime;

	[SerializeField]
	private Ease _showMoveEase;

	[SerializeField]
	private Ease _hideMoveEase;

	[SerializeField]
	protected AnimData[] _iconAnimData;

	[SerializeField]
	protected AnimData[] _bgAnimData;

	[SerializeField]
	protected OffsetPosData _iconOffsetPosData;

	private VisibleUIObject _rootVisible;

	private VisibleUIObject _invalidVisible;

	private RectTransform _iconImageRt;

	private RectTransform _bgImageRt;

	private Tweener _twAnim;

	private Sequence _seqButtonAnim;

	private ManagementMultipleIconData _data;

	private Vector3 _offsetInitialPos;

	private bool _isLeftFlag;

	private bool _isButtonValidate;

	private void Awake()
	{
	}

	public static QuestSkillButtonEx Create(GameObject parent, int index, Action<QuestSkillButtonBase> onClick, bool isLeft)
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

	public override bool ApplyIcon(InGameEventExtendAtlasManager eeAtlasManager)
	{
		return default(bool);
	}

	public override void Show(bool isForce = false, bool isImmediate = false)
	{
	}

	public override void Hide(bool isForce = false, bool isImmediate = false)
	{
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

	private void PlayShowAnim(bool isImmediate = false)
	{
	}

	private void PlayHideAnim(bool isImmediate = false)
	{
	}

	private void ApplyAnimData(AnimData data, RectTransform imageRt)
	{
	}

	private Sequence CreateButtonAnim()
	{
		return null;
	}

	protected virtual void OnUpdateIconImageScale(Vector3 scale)
	{
	}

	protected virtual void OnUpdateBgImageScale(Vector3 scale)
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
