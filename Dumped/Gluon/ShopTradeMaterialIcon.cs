using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class ShopTradeMaterialIcon : MonoBehaviour
{
	[SerializeField]
	public CommonIcon icon;

	public Text useCount;

	public Image bottomCountPlate;

	[SerializeField]
	public GameObject amuletDeco;

	public GameObject amuletCover;

	[SerializeField]
	public GameObject countMask;

	[SerializeField]
	private Image[] limitBreakImages;

	private Text[] displayTextList;

	private Color insufficientCountColor;

	private Color insufficientCountPlateColor;

	private Color insufficientCountPlateColorBottom;

	private Color normalCountPlateColorBottom;

	private Color normalCountColor;

	private Color normalPlateColor;

	private static readonly int needOmitDigitsCounts;

	private void Awake()
	{
	}

	public void SetMaterial(int id, int useCount, GiftType giftType = GiftType.MATERIAL, int limitBreakCount = 0, ulong keyId = 0uL, bool shouldTurnInsufficient = false)
	{
	}

	public void SetMaterialUseCount(int useCount, bool isSufficient)
	{
	}

	private void SetLimitBreakImage(int limitBreakCount)
	{
	}
}
