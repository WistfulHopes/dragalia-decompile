using System;
using System.Runtime.InteropServices;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class InGameCounterUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private SpriteRenderer[] _countImage;

	[SerializeField]
	private SpriteRenderer[] _animCountImage;

	[SerializeField]
	private SpriteRenderer _symbolImage;

	[SerializeField]
	private SpriteRenderer _animSymbolImage;

	[SerializeField]
	private int _minDisplayCount;

	[SerializeField]
	private Vector2 _symbolOffset;

	[SerializeField]
	private bool _isEnableSymbol;

	[SerializeField]
	private InGameAnimUI[] _changeAnimUI;

	[SerializeField]
	private Sprite[] _countSprite;

	private VisibleUIObject _rootVisible;

	private Vector3[] _countOriginalScale;

	private long _maxCount;

	private long _lastCount;

	private bool _isEnableAnim;

	private Action<long, long> _onCountChanged;

	public void Initialize([Optional] Action<long, long> onCountChanged)
	{
	}

	private void OnDestroy()
	{
	}

	public void Visible(bool b)
	{
	}

	public bool IsVisible(bool inHierarchy = true)
	{
		return default(bool);
	}

	public void SetCount(long count, bool isForce = false, bool isAnim = true)
	{
	}

	public long GetMaxCount()
	{
		return default(long);
	}

	private void SetCountSprite(long count, long maxCount)
	{
	}

	private void SetCountSprite(int index, int countIndex, bool enabled)
	{
	}

	public void SetColor(Color color, bool isApplyAnimCount)
	{
	}

	private bool PlayChangeAnim()
	{
		return default(bool);
	}
}
