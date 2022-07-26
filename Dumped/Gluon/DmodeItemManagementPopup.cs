using System.Collections.Generic;
using UnityEngine;

namespace Gluon;

public class DmodeItemManagementPopup : PopupBase
{
	[SerializeField]
	public DmodeCommonInGameIcon charaBagIconTemplate;

	[SerializeField]
	public DmodeCommonInGameIcon fafnirBagIconTemplate;

	[SerializeField]
	public GameObject emptyGO;

	public static readonly string prefabPath;

	private List<DmodeCommonInGameIcon> charaBagIcons;

	private List<DmodeCommonInGameIcon> fafnirBagIcons;

	private DmodeDungeonItemManager.ContainerType selectedContainerType;

	private int selectedPos;

	private DmodeDungeonItemType selectedItemType;

	private List<int> charaBagItems;

	private List<int> fafnirBagItems;

	public static DmodeItemManagementPopup Create()
	{
		return null;
	}

	protected override void Start()
	{
	}

	private void OnCharaBagButtonPressed(DmodeDungeonItemType type, int index)
	{
	}

	private void OnFafnirBagButtonPressed(DmodeDungeonItemType type, int index)
	{
	}

	private void OnBagButtonPressed(DmodeDungeonItemManager.ContainerType containerType, DmodeDungeonItemType type, int index)
	{
	}

	private void SwitchItems(DmodeDungeonItemManager.ContainerType fromContainer, int fromIndex, DmodeDungeonItemManager.ContainerType toContainer, int toIndex)
	{
	}

	public void OnOKButtonPressed()
	{
	}

	private void UpdateView()
	{
	}
}
