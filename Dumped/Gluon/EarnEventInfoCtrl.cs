using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class EarnEventInfoCtrl : EventInfoCtrlBase
{
	[SerializeField]
	private Image[] materialImages;

	[SerializeField]
	private Text[] materialTexts;

	[SerializeField]
	private Text hintText;

	[SerializeField]
	private Text hintTitleText;

	protected override void Start()
	{
	}

	public static EarnEventInfoCtrl Create(Transform parent)
	{
		return null;
	}

	public override void SetEventInfo()
	{
	}

	private void SetEventHintText()
	{
	}

	private void SetEventHintTitle()
	{
	}
}
