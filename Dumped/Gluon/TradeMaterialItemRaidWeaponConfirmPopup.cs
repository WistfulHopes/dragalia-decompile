using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class TradeMaterialItemRaidWeaponConfirmPopup : TradeMaterialItemConfirmPopup
{
	public enum LimitBreakSpriteIndex
	{
		Off,
		On,
		Max
	}

	[SerializeField]
	public Text hpText;

	public Text atkText;

	[SerializeField]
	public Sprite[] limitBreakStateSprites;

	public Image[] limitBreakImages;

	[SerializeField]
	public Image[] skillAbilityIcons;

	public Text[] skillAbilityNames;

	public GameObject[] skillAbilitySingleLines;

	private List<Action> onIconTouchedCallbacks;

	public void OnSkillAbilityPressed(int i)
	{
	}

	public void OnTradeButtonPressed()
	{
	}

	protected override void OnTradeDone()
	{
	}

	protected override void Start()
	{
	}
}
