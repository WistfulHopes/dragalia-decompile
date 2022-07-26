using System.Collections.Generic;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class InGameRemainLifeIconCtrl : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform rootIconRt;

	private InGameRemainLifeIconUI baseIconUI;

	private List<InGameRemainLifeIconUI> iconUIList;

	private int remainLifeNum;

	private bool isInitialized;

	private InGameRemainLifeIconUI.IconType iconType;

	public void Initialize(InGameRemainLifeIconUI.IconType iconType)
	{
	}

	public void SetRemainLifeNum(int num, bool isDragon, bool isForce = false)
	{
	}
}
