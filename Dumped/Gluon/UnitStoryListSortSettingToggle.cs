using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class UnitStoryListSortSettingToggle : CommonSettingToggleBase
{
	[SerializeField]
	public GameObject layoutParentGameObject;

	public Text title;

	[SerializeField]
	public ElementalType elemental;

	public WeaponType weaponType;

	[SerializeField]
	public UnitStoryListSortModel.Condition.SortCondition.SortType sortType;

	public UnitStoryListSortModel.Condition.SortCondition.SortOrder sortOrder;

	private UnitStoryListSortPopup popup;

	public void SetupByCondition(UnitStoryListSortModel.Condition condition, UnitStoryListSortPopup popup)
	{
	}

	public override void OnToggleValueChanged(bool value)
	{
	}

	public void ResetInitValueBySortType(UnitStoryListSortModel.Condition.SortCondition.SortType sortType)
	{
	}
}
