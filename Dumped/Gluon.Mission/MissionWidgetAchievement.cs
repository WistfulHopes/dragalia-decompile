using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Mission;

public class MissionWidgetAchievement : MonoBehaviour
{
	public int numCleared;

	public int numQuota;

	[SerializeField]
	public Slider gauge;

	[SerializeField]
	public Text textRate;

	private void UpdateRateText()
	{
	}

	private void UpdateGauge()
	{
	}

	public void SetClearedValue(int numCleared)
	{
	}

	public void Set(int numCleared, int numQuota)
	{
	}
}
