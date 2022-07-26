using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class DmodeDragonRewardDetailInfoCell : DmodeUnitItemDetailInfoCell
{
	[SerializeField]
	private GameObject[] rareGOs;

	[SerializeField]
	private Text rarePriceText;

	[SerializeField]
	private Button chooseButton;

	[SerializeField]
	private Transform balloon;

	private DmodeDungeonItem item;

	private int rarePrice;

	public void Setup(DmodeDungeonItem item, int rarePrice)
	{
	}

	public void UpdatePriceView()
	{
	}

	private void Start()
	{
	}

	public void OnChooseButtonPressed()
	{
	}
}
