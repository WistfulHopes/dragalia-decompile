using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class InGameScoringEventInfoUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _adjustRt;

	[SerializeField]
	private Text _killText;

	[SerializeField]
	private Text _pointText;

	private VisibleUIObject _rootVisible;

	private int _lastKill;

	private int _lastPoint;

	private bool _isLeft;

	private const int MaxValue = 999999999;

	public static InGameScoringEventInfoUI Create(GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	protected virtual void Initialize()
	{
	}

	public void SetLayout(bool isLeft)
	{
	}

	public void SetKillNum(int value, bool isForce = false)
	{
	}

	public void SetPoint(int value, bool isForce = false)
	{
	}
}
