using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class RefundPopup : PopupBase
{
	[SerializeField]
	private Text text;

	[SerializeField]
	private Button refundButton;

	private const string prefabPath = "Prefabs/OutGame/Close/RefundPopup";

	public static RefundPopup Create()
	{
		return null;
	}

	protected override void Start()
	{
	}

	private bool DoesShowRefundButton()
	{
		return default(bool);
	}

	public void OnPressInquiry()
	{
	}

	public void OnPressRefund()
	{
	}
}
