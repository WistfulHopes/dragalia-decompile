using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class DmodeSkipResultPopup : PopupBase
{
	[SerializeField]
	public Text titleText;

	[SerializeField]
	public Text hpText;

	public Text attackText;

	[SerializeField]
	public DmodeCommonInGameIcon weaponIcon;

	public DmodeCommonInGameIcon[] abilityCrestIcons;

	[SerializeField]
	public DmodeCommonInGameIcon dragonIconTemplate;

	[SerializeField]
	public DmodeCommonInGameIcon skillIconTemplate;

	public static readonly string prefabPath;

	private List<DmodeCommonInGameIcon> dragonIcons;

	private List<DmodeCommonInGameIcon> skillIcons;

	public static DmodeSkipResultPopup Create(Action onClose)
	{
		return null;
	}

	protected override void Start()
	{
	}

	private void OnEquippedDefaultWeaponButtonPressed(DmodeDungeonItemType type, int id)
	{
	}

	protected override void OnDestroy()
	{
	}
}
