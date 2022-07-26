using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class UnitManaCirclePage : MonoBehaviour
{
	[SerializeField]
	public Text releasedCountText;

	public Text releasedMaxText;

	[SerializeField]
	public Text limitBreakCountText;

	public Text limitBreakMaxText;

	[SerializeField]
	public CommonIcon[] rewardIcons;

	public Text[] rewardItemNames;

	public GameObject[] rewardFrames;

	[SerializeField]
	public Image[] getMarks;

	private const int manaCircleFullReleaseBorder = 50;

	public void SetupManaCirclePage(UnitDetailModel.UnitDetailType type)
	{
	}
}
