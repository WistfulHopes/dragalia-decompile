using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Mission;

public class MissionWidgetDetailReward : MonoBehaviour
{
	[SerializeField]
	public MissionWidgetRewardIcon rewardIcon;

	[SerializeField]
	public GameObject imageComplete;

	[SerializeField]
	public GameObject imageReceived;

	[SerializeField]
	public Text textItemDesc;

	[SerializeField]
	public Text textItemRuby;

	[SerializeField]
	public MissionWidgetAchievement achievement;
}
