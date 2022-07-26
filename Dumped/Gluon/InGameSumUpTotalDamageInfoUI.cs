using Cute.Core;
using UnityEngine;

namespace Gluon;

public class InGameSumUpTotalDamageInfoUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private InGameCounterUI _counterCtrl;

	private float _headerMargin;

	public static InGameSumUpTotalDamageInfoUI Create(GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize()
	{
	}

	public override void FastUpdate()
	{
	}

	public void SetCount(long count)
	{
	}

	public void Visible(bool b)
	{
	}
}
