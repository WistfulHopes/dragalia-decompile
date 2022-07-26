using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class ShopDailyCrystalClaimDonePopup : PopupBase
{
	[SerializeField]
	public Text commentText;

	public Text remainText;

	public CommonIcon[] icons;

	[SerializeField]
	public GameObject closeButtonGO;

	public GameObject okCancelButtonGO;

	[SerializeField]
	public PointerEventHandler closeButtonPE;

	public PointerEventHandler cancelButtonPE;

	private int remainDays;

	private bool preOrderable;

	private EntityData[] receivedData;

	public static ShopDailyCrystalClaimDonePopup Create(int remainDays, bool preOrderable, EntityData[] receivedData)
	{
		return null;
	}

	protected override void Start()
	{
	}

	public void OnPurchaseButtonPressed()
	{
	}
}
