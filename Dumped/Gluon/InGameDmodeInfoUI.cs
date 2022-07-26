using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class InGameDmodeInfoUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform rootRt;

	[SerializeField]
	private Text scoreText;

	[SerializeField]
	private Text floorText;

	public static InGameDmodeInfoUI Create(GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize()
	{
	}

	public override void FastUpdate()
	{
	}

	public void SetScore(int val)
	{
	}

	public void SetFloor(int val, bool isForce = false)
	{
	}

	public void Visible(bool b)
	{
	}
}
