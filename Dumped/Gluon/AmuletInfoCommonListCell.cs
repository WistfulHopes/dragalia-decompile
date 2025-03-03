using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class AmuletInfoCommonListCell : CommonIconListCell
{
	public const float amuletCellWideWidth = 284f;

	public const float amuletCellWideHieght = 195f;

	[SerializeField]
	private Transform iconParentTransform;

	[SerializeField]
	private Transform cellBaseTransform;

	[SerializeField]
	private Text crestName;

	[SerializeField]
	private Text hpParamText;

	[SerializeField]
	private Text atkParamText;

	[SerializeField]
	private Text plusParamText;

	[SerializeField]
	private Text buildupText;

	[SerializeField]
	private Text abilityLabelText;

	[SerializeField]
	private Text equipLabelText;

	[SerializeField]
	private GameObject equipLabelObject;

	[SerializeField]
	private GameObject abilityLabelObject;

	[SerializeField]
	private Badge growBadge;

	[SerializeField]
	private Image eventBonusIcon;

	[SerializeField]
	private GameObject statusBaseObject;

	[SerializeField]
	private GameObject abilityIconBaseObject;

	[SerializeField]
	private Image[] abilityIcons;

	private List<int> abilityIdList;

	private bool isTalisman;

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	public override void UpdateContent(CommonIconListCellData data)
	{
	}

	public override void LoadUnitIcon()
	{
	}
}
