using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class QuestResultRankingCell : MonoBehaviour
{
	[SerializeField]
	private CommonIcon[] commonIcons;

	[SerializeField]
	private GameObject[] emptyIcons;

	[SerializeField]
	private Transform[] charaListSortDecoTrans;

	[SerializeField]
	private GameObject newIcon;

	[SerializeField]
	private Text rankingFactorText;

	[SerializeField]
	private Image bgFront;

	[SerializeField]
	private float fadeInTime;

	[SerializeField]
	private float fadeOutTime;

	[SerializeField]
	private Text currentDamageText;

	private CommonIconListSortDeco[] charaListSortDeco;

	private const int fontSizeUseIntergerClearTime = 40;

	private const int fontSizeUseFloatClearTime = 31;

	public void InitSetting(TimeAttackRanking.RankingInfo data)
	{
	}

	public void InitSetting(TotalDamageEventRankingData.RankingInfo rankingData)
	{
	}

	public void RankInAnimation()
	{
	}
}
