using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class InventoryButton : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform _badgeIconRt;

	[SerializeField]
	private Button _button;

	public bool isVisibleBadgeIcon
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static InventoryButton Create(GameObject parent, int index, Action<InventoryButton> onClick, bool isLeft)
	{
		return null;
	}

	public void Initialize(Action<InventoryButton> onClick)
	{
	}

	public void VisibleBadgeIcon(bool b, bool isForce = false)
	{
	}
}
