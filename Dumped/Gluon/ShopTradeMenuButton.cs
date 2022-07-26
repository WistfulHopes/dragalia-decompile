using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class ShopTradeMenuButton : MonoBehaviour
{
	public ShopTradeModel.PanelType type;

	[SerializeField]
	public Text disableReasonText;
}
