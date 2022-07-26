using System;
using UnityEngine;

namespace Gluon;

public class CommonTabController : MonoBehaviour
{
	[SerializeField]
	public CommonTabButtonBase[] tabButtons;

	[SerializeField]
	private Sprite[] onSprites;

	[SerializeField]
	private Sprite[] offSprites;

	[SerializeField]
	private Color onTextColor;

	[SerializeField]
	private Color offTextColor;

	[SerializeField]
	private GameObject[] tabPages;

	private Action<int, bool> onTabSwitched;

	public void Awake()
	{
	}

	public void SetTabSwitchedCallback(Action<int, bool> onTabSwitched)
	{
	}

	public void SwitchToTab(int index, bool callOnTabSwitched = true)
	{
	}

	public void SetTabDisableState(int index, bool toDisable)
	{
	}
}
