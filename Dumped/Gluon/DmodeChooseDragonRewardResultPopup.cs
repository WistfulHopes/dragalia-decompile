using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class DmodeChooseDragonRewardResultPopup : PopupBase
{
	[SerializeField]
	public DmodeCommonInGameIcon icon;

	[SerializeField]
	public GameObject[] rareGOs;

	public Text afterText;

	public Text nameText;

	public static readonly string prefabPath;

	private DmodeDungeonItem item;

	private int rarePrice;

	public static DmodeChooseDragonRewardResultPopup Create(DmodeDungeonItem item, int rarePrice)
	{
		return null;
	}

	protected override void Start()
	{
	}
}
