using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Gluon;

public class ModeSelectButton : FastUpdateMonoBehaviour
{
	public delegate void ButtonDelegate(ModeSelectButton sender);

	public enum FrameType
	{
		Top,
		Center,
		Bottom
	}

	[SerializeField]
	private Button _button;

	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _offsetRt;

	[SerializeField]
	private RectTransform _buttonOnRt;

	[SerializeField]
	private RectTransform _buttonOffRt;

	[SerializeField]
	private RectTransform _buttonIconRt;

	[SerializeField]
	private RectTransform _iconRt;

	[SerializeField]
	private RectTransform _invalidRt;

	[SerializeField]
	private RectTransform _frameRt;

	[SerializeField]
	private SpriteRenderer _onButtonImage;

	[SerializeField]
	private SpriteRenderer _onAddButtonImage;

	[SerializeField]
	private SpriteRenderer _offButtonImage;

	[SerializeField]
	private SpriteRenderer _onNoUseImage;

	[SerializeField]
	private SpriteRenderer _offNoUseImage;

	[SerializeField]
	private SpriteRenderer _onFrameImage;

	[SerializeField]
	private SpriteRenderer _offFrameImage;

	[SerializeField]
	private SpriteRenderer _iconImage;

	[SerializeField]
	private Material _colorAdjustMaterial;

	[SerializeField]
	private SortingGroup _sortingGropup;

	[SerializeField]
	private Sprite[] _onFrameSprites;

	[SerializeField]
	private Sprite[] _offFrameSprites;

	[SerializeField]
	private Vector3 _buttonBasePos;

	[SerializeField]
	private float _buttonOffsetY;

	[SerializeField]
	private int _activeModeSortingOrder;

	[SerializeField]
	private int _deactiveModeSortingOrder;

	private VisibleUIObject _rootVisible;

	private VisibleUIObject _offsetVisible;

	private VisibleUIObject _invalidVisible;

	private Sequence _seqSelected;

	private Material _material;

	private Sprite _sprite;

	private bool _buttonOn;

	private bool _validate;

	private bool _inactive;

	private FrameType _frameType;

	public HumanCharacter human
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int index
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int modeId
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Vector3 ButtonBasePos => default(Vector3);

	public float ButtonOffsetY => default(float);

	public static ModeSelectButton Create(GameObject parent, HumanCharacter human, ButtonDelegate func, int index, int modeId, bool isLext, int siblingIndex = -1)
	{
		return null;
	}

	public void Initialize(HumanCharacter human, ButtonDelegate func, int index, int modeId, bool isLeft)
	{
	}

	private void OnDestroy()
	{
	}

	public override void FastUpdate()
	{
	}

	private void SetIconImage(int modeId)
	{
	}

	private void CheckInactive()
	{
	}

	public void Visible(bool b)
	{
	}

	public bool IsVisible()
	{
		return default(bool);
	}

	public void Validate(bool validate, bool on, bool playSe, bool force = false)
	{
	}

	public void SetFrameType(FrameType type, bool force = false)
	{
	}

	public Vector2 GetButtonPosition()
	{
		return default(Vector2);
	}

	public Vector2 GetButtonSize()
	{
		return default(Vector2);
	}

	public void SetEnabled(bool b)
	{
	}

	private void SetSortingGroup(int sortingOrder)
	{
	}

	private void PlaySelectedAnim()
	{
	}
}
