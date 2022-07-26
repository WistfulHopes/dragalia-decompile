using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class InGameRemainLifeIconUI : FastUpdateMonoBehaviour
{
	[Serializable]
	public class FooterParam
	{
		[SerializeField]
		public Vector2 iconAdjust;

		[SerializeField]
		public float iconOffset;

		[SerializeField]
		public float iconScale;

		[SerializeField]
		public int iconSortingOrder;

		[SerializeField]
		public bool isIconFlip;
	}

	[Serializable]
	public class PartyButtonParam
	{
		[SerializeField]
		public Vector2 iconAdjust;

		[SerializeField]
		public float iconOffset;

		[SerializeField]
		public float iconScale;

		[SerializeField]
		public int iconSortingOrder;
	}

	public enum IconType
	{
		Footer,
		PartyButton
	}

	[SerializeField]
	private SpriteRenderer iconImage;

	[SerializeField]
	private int maxNum;

	[SerializeField]
	private FooterParam footerParam;

	[SerializeField]
	private PartyButtonParam partyButtonParam;

	private RectTransform rootRt;

	private RectTransform iconRt;

	private int index;

	private IconType iconType;

	public bool isVisible
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

	public static InGameRemainLifeIconUI Create(GameObject parent, int index, IconType iconType, int siblingIndex = -1)
	{
		return null;
	}

	public void Initialize(GameObject parent, int index, IconType iconType, int siblingIndex = -1)
	{
	}

	private void Initialize(int index, IconType iconType)
	{
	}

	public void ApplyIcon()
	{
	}

	public void Visible(bool b, bool isForce = false)
	{
	}

	public int GetMaxNum()
	{
		return default(int);
	}
}
