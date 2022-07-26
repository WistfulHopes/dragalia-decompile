using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class SummonPrizeOddsTableViewController : TableViewController<SummonPrizeOddsTableViewData>
{
	[SerializeField]
	public Text topText;

	public GameObject topPart;

	[SerializeField]
	public RectTransform verticalLayout;

	[SerializeField]
	public SummonPrizeOddsPopupOverallTotalBlock[] normalOverallTotal;

	public SummonPrizeOddsPopupOverallTotalBlock[] guaranteedOverallTotal;

	protected override void Awake()
	{
	}

	protected override float GetCellHeightAtIndex(int index)
	{
		return default(float);
	}

	public void ReloadByData(List<SummonPrizeOddsTableViewData> data)
	{
	}

	public void SetTopPadding(float height)
	{
	}

	public void SetupTotalBlocks(SummonPrizeOddsRateList oddsRate)
	{
	}
}
