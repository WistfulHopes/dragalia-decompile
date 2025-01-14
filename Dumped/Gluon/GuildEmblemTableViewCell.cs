using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon;

public class GuildEmblemTableViewCell : TableViewCell<int>
{
	[Serializable]
	public class ButtonEvent : UnityEvent<int>
	{
	}

	[SerializeField]
	public RawImage icon;

	public ButtonEvent onCellPressed;

	[SerializeField]
	public GameObject selectedFrame;

	public GuildEmblemSelectPopup popup;

	public override void UpdateContent(int data)
	{
	}

	public void OnIconPressed()
	{
	}
}
