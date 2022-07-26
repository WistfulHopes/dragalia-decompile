using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class FriendSortSettingToggle : CommonSettingToggleBase
{
	[SerializeField]
	public GameObject layoutParentGameObject;

	public Text title;

	[SerializeField]
	public ElementalType elemental;

	public WeaponType weaponType;

	[SerializeField]
	public FriendSortModel.Condition.SortCondition.SortType sortType;

	public FriendSortModel.Condition.SortCondition.SortOrder sortOrder;

	private FriendSortPopup popup;

	public void SetupByCondition(FriendSortModel.Condition condition, FriendSortPopup popup)
	{
	}

	public override void OnToggleValueChanged(bool value)
	{
	}

	public void ResetInitValueBySortType(FriendSortModel.Condition.SortCondition.SortType sortType)
	{
	}
}
