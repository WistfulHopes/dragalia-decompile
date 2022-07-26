using UnityEngine;
using UnityEngine.Events;

namespace Gluon;

public class MatchingPartyMenuPopup : PopupBase
{
	[SerializeField]
	public UnityEvent autoPartyButtonPressed;

	[SerializeField]
	public UnityEvent charaPartyButtonPressed;

	[SerializeField]
	public UnityEvent bgButtonPressed;

	public void OnAutoPartyButtonPressed()
	{
	}

	public void OnCharaPartyButtonPressed()
	{
	}

	public void OnBgButtonPressed()
	{
	}
}
