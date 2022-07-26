using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class GuildInfoTableViewCell : TableViewCell<GuildInfoCellData>
{
	[SerializeField]
	public RawImage emblemImage;

	[SerializeField]
	public Image ribbonImage;

	public Sprite[] approvalRibbons;

	public Text[] approvalTexts;

	[SerializeField]
	public Text[] activityTexts;

	[SerializeField]
	public Text populationText;

	public Text nameText;

	public Text mottoText;

	[SerializeField]
	public Button button;

	public const string prefabPath = "Prefabs/OutGame/Guild/GuildInfoTableViewCell";

	public Action<GuildInfoCellData> onCellPressed
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Action<GuildInfoCellData> rejectAction
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override void UpdateContent(GuildInfoCellData data)
	{
	}

	public void OnCellPressed()
	{
	}

	public void OnRejectButtonPressed()
	{
	}
}
