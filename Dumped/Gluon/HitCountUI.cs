using Cute.Core;
using UnityEngine;

namespace Gluon;

public class HitCountUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _countAdjustRt;

	[SerializeField]
	private SpriteRenderer _captionImage;

	[SerializeField]
	private SpriteRenderer[] _countImage;

	[SerializeField]
	private Sprite[] _countSprite;

	[SerializeField]
	private Color _defaultColor;

	[SerializeField]
	private Color _dyingColor;

	[SerializeField]
	private float _digitMergin;

	[SerializeField]
	private float _dyingRate;

	private VisibleUIObject _rootVisible;

	private RectTransform[] _countRt;

	private CharacterMarkUI _mark;

	private RectTransform _markRt;

	private int _maxCount;

	private int _lastCount;

	private int _lastMaxCount;

	public static HitCountUI Create(GameObject parent, CharacterMarkUI mark, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize(CharacterMarkUI mark)
	{
	}

	public override void FastUpdate()
	{
	}

	protected void UpdatePosition()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void ResetCount()
	{
	}

	public void SetCount(int count, int maxCount)
	{
	}

	private void SetCountSprite(ref SpriteRenderer image, int index, bool isEnabled, Color color)
	{
	}
}
