using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class LinkAfterSunsetInquiryPopup : PopupBase
{
	[SerializeField]
	private Text mailAdressText;

	private const string prefabPath = "Prefabs/OutGame/Close/LinkAfterEOSInquiryPopup";

	private const string mailAdressStr = "support@dragalialost.com";

	public static LinkAfterSunsetInquiryPopup Create()
	{
		return null;
	}

	public void OnPressButtonCopy()
	{
	}
}
