using UnityEngine;

namespace Gluon;

public class BattleRoyalRecordListPopup : PopupBase
{
	[SerializeField]
	public RectTransform layoutParent;

	public GameObject noItemComment;

	public BattleRoyalRecordListCell templateCell;

	public static void Create()
	{
	}

	protected override void Start()
	{
	}
}
