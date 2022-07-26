using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class RefundBalancePopup : PopupBase
{
	[SerializeField]
	private Text balanceText;

	[SerializeField]
	private Text warningText;

	private const string prefabPath = "Prefabs/OutGame/Close/RefundBalancePopup";

	public static RefundBalancePopup Create()
	{
		return null;
	}

	protected override void Start()
	{
	}
}
