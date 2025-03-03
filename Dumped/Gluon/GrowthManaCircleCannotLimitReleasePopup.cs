using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class GrowthManaCircleCannotLimitReleasePopup : CommonPopup, ICustomMessage
{
	public Text insufficientText;

	public CommonIcon[] icons;

	public Image[] requiredLabels;

	public Text[] requiredNumText;

	public Image[] havingLabels;

	public Text[] havingNumText;

	public Text[] havingText;

	public Image[] tradeIcons;

	private readonly Color insufficientTextColor;

	private readonly Color insufficientRequiredColor;

	private readonly Color insufficientHavingColor;

	private readonly Color sufficientRequiredColor;

	private readonly Color sufficientHavingColor;

	private int circleIndex;

	private GrowthManaCircleModel model;

	protected override void Awake()
	{
	}

	public static GrowthManaCircleCannotLimitReleasePopup Create()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetParameters(int circleIndex, GrowthManaCircleModel model, ref bool canAutoRelease)
	{
	}

	public void OnMessagReceived(CustomMessageType messageType, object data)
	{
	}
}
