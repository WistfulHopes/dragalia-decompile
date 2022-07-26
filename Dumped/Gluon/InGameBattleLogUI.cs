using System.Runtime.InteropServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class InGameBattleLogUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _iconRt;

	[SerializeField]
	private RectTransform _textRt;

	[SerializeField]
	private SpriteRenderer _bgImage;

	[SerializeField]
	private SpriteRenderer _iconImage;

	[SerializeField]
	private Text _simpleText;

	[SerializeField]
	private float _windowHeight;

	[SerializeField]
	private float _showDuration;

	[SerializeField]
	private float _moveDuration;

	[SerializeField]
	private float _hideDuration;

	[SerializeField]
	private float _waitDuration;

	[SerializeField]
	private float _fastAnimTimeScale;

	[SerializeField]
	private float _fastWaitTimeScale;

	[SerializeField]
	private float[] _textAdjustPosY;

	private VisibleUIObject _rootVisible;

	private InGameBattleLogCtrl _logCtrl;

	private InGameBattleLogCtrl.LogData _logData;

	private Sequence _seqShow;

	private Sequence _seqMove;

	private Sequence _seqHide;

	private int _displayIndex;

	private bool _isLeft;

	private float _waitTime;

	public static InGameBattleLogUI Create(InGameBattleLogCtrl logCtrl, GameObject prefab, GameObject parent, int index, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize(InGameBattleLogCtrl logCtrl, int index)
	{
	}

	private void OnDestroy()
	{
	}

	public override void FastUpdate()
	{
	}

	public bool Show([In] ref InGameBattleLogCtrl.LogData data)
	{
		return default(bool);
	}

	public void Hide(bool isImmediate = false)
	{
	}

	public bool IsVisible()
	{
		return default(bool);
	}

	public bool IsShowAnim()
	{
		return default(bool);
	}

	public bool IsHideAnim()
	{
		return default(bool);
	}

	public void Move(int index)
	{
	}

	public void SetLayout(bool isLeft)
	{
	}

	private float GetTextAdjustPosY(InGameBattleLogCtrl.LogType type)
	{
		return default(float);
	}

	private void ApplyTextPos(InGameBattleLogCtrl.LogType type)
	{
	}

	private void SetFade(float fade)
	{
	}

	private void SetFade(ref SpriteRenderer sprite, float fade)
	{
	}

	private void SetFade(ref Text text, float fade)
	{
	}

	private void CreateActionShow()
	{
	}

	private void CreateActionMove(int index)
	{
	}

	private void CreateActionHide()
	{
	}
}
