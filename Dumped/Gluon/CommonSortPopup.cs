using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class CommonSortPopup : PopupBase
{
	[SerializeField]
	private Text titleText;

	[SerializeField]
	public TabBase tabController;

	[SerializeField]
	private CommonSortFilterUI[] commonSortFilters;

	[SerializeField]
	private TabBase obtainedItemTypeTab;

	[SerializeField]
	public Image filterAllElementalCheckImage;

	public CommonSortSettingToggle[] filterEachElementToggleList;

	[SerializeField]
	public Image filterAllWeaponTypeCheckImage;

	public CommonSortSettingToggle[] filterEachWeaponTypeToggleList;

	[SerializeField]
	public CommonSortSettingToggle filterWeaponUpgradableToggle;

	public CommonSortSettingToggle filterInvertWeaponUpgradableToggle;

	[SerializeField]
	public Image filterAllUnionAbilityCheckImage;

	public CommonSortSettingToggle[] filterEachUnionAbilityToggleList;

	[SerializeField]
	private CommonSortSettingToggle[] filterAbilityToggleList;

	[SerializeField]
	private CommonSortFilterUI[] abilitySortFilters;

	[SerializeField]
	private CommonSortFilterUI[] needSetupAbilities;

	[SerializeField]
	public CommonSortSettingToggle[] filterExAbilityToggleList;

	[SerializeField]
	public CommonSortSettingToggle[] filterCharaSkillToggleList;

	[SerializeField]
	public CommonSortSettingToggle[] filterHpPlusParamToggleList;

	public CommonSortSettingToggle[] filterAtkPlusParamToggleList;

	[SerializeField]
	public CommonSortSettingToggle[] sortTypeToggleList;

	public ToggleGroup sortTypeToggleGroup;

	public CommonSortFilterUI plusSortLine;

	public CommonSortFilterUI priorMatchElementLine;

	public CommonSortSettingToggle priorMatchElementToggle;

	public CommonSortFilterUI priorFavoriteLine;

	public CommonSortSettingToggle priorFavoriteToggle;

	[SerializeField]
	public CommonSortSettingToggle sortOrderAscendingToggle;

	public CommonSortSettingToggle sortOrderDescendingToggle;

	public ToggleGroup sortOrderToggleGroup;

	[SerializeField]
	public Text countText;

	public Text preCountText;

	public Button okButton;

	[SerializeField]
	protected Button closeButton;

	private bool isShowObtainedItem;

	private bool useSelfSortAndFilter;

	private List<WeaponType> limitedWeaponTypeList;

	private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForCharacter;

	private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForDragon;

	private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForWeapon;

	private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForAmulet;

	private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForDragonPetting;

	private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForDreamSelect;

	private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForDreamSelectDragon;

	private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForSkinWeapon;

	private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForCharaSkill;

	private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForAlbum;

	private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForAlbumDragon;

	private readonly CommonSortModel.Condition.SortCondition.SortType[] sortTypeListForTalisman;

	private CommonSortModel.Condition editingCondition;

	private CommonIconListController controller;

	private GiftType giftType;

	private bool shouldIgnoreNoElement;

	private ulong[] originalKeyIds;

	private CommonSortModel.Preset preset;

	private Action onSortSettingApplied;

	private Func<List<ulong>, List<ulong>> filteredListCustomizeAction;

	private const string prefabPath = "Prefabs/OutGame/Common/CommonSortPopup";

	public CommonSortFilterUI ObtainedItemTypeLine => null;

	public CommonSortFilterUI elementalTypeLine => null;

	public CommonSortFilterUI weaponTypeLine => null;

	public CommonSortFilterUI weaponUpgradableLine => null;

	public CommonSortFilterUI unionAbilityLine => null;

	public CommonSortFilterUI filterAbilityLine => null;

	public CommonSortFilterUI eventSpecificAbilityLine => null;

	public CommonSortFilterUI eventSpecificToggleGO => null;

	public CommonSortFilterUI memoryEventSpecificToggleGO => null;

	public CommonSortFilterUI buffDebuffAbilityLine => null;

	public CommonSortFilterUI filterExAbilityLine => null;

	public CommonSortFilterUI filterCharaSkillLine => null;

	public CommonSortFilterUI plusParamLine => null;

	public static CommonSortPopup Create(CommonIconListController controller, GiftType giftType, ulong[] originalKeyIds, CommonSortModel.Preset preset = CommonSortModel.Preset.AutoCommon, bool shouldClearFilter = false, ElementalType charaElement = ElementalType.NONE, [Optional] Func<List<ulong>, List<ulong>> filteredListCustomizeAction)
	{
		return null;
	}

	public static CommonSortPopup CreateWithData(GiftType giftType, ulong[] originalKeyIds, CommonSortModel.Preset preset = CommonSortModel.Preset.AutoCommon, bool shouldClearFilter = false, bool showObtainedItem = true)
	{
		return null;
	}

	protected override void Start()
	{
	}

	public void SetupByControllerAndType(CommonIconListController controller, GiftType giftType, ulong[] originalKeyIds, CommonSortModel.Preset preset, bool shouldClearFilter, ElementalType charaElement, Func<List<ulong>, List<ulong>> filteredListCustomizeAction)
	{
	}

	private void SetUIByCondition()
	{
	}

	public void SetCountText(int countNow, int countMax = -1)
	{
	}

	private void OnObtainedItemFilterChanged(int index, bool calledFromUI)
	{
	}

	public void OnAllElementalFilterButtonPressed()
	{
	}

	public void OnElementalFilterToggled(bool isOn, ElementalType elem)
	{
	}

	public void OnAllWeaponTypeFilterButtonPressed()
	{
	}

	public void OnWeaponTypeFilterToggled(bool isOn, WeaponType weaponType)
	{
	}

	public void OnWeaponUpgradeFilterToggled(bool isOn)
	{
	}

	public void OnAllUnionAbilityFilterButtonPressed()
	{
	}

	public void OnUnionAbilityFilterToggled(bool isOn, int unionAbilityId)
	{
	}

	public void OnAbilityTypeFilterToggled(bool isOn, CommonSortModel.Condition.FilterCondition.AbilityTypeFilter.AbilityTypeForFilter type)
	{
	}

	public void OnExAbilityTypeFilterToggled(bool isOn, CommonSortModel.Condition.FilterCondition.ExAbilityTypeFilter.ExAbilityTypeForFilter type)
	{
	}

	public void OnCharaSkillTypeFilterToggled(bool isOn, CommonSortModel.Condition.FilterCondition.CharaSkillTypeFilter.CharaSkillTypeForFilter type)
	{
	}

	public void OnHpPlusFilterToggled(bool isOn, CommonSortSettingToggle.SortPlusParamType sortPlusParamType)
	{
	}

	public void OnAtkPlusFilterToggled(bool isOn, CommonSortSettingToggle.SortPlusParamType sortPlusParamType)
	{
	}

	public void OnPriorMatchElementToggled(bool isOn)
	{
	}

	public void OnPriorFavoriteToggled(bool isOn)
	{
	}

	public void OnFilterConditionChanged()
	{
	}

	public void OnSortTypeToggled(CommonSortModel.Condition.SortCondition.SortType type)
	{
	}

	private void UpdateSortOrderLockStatus()
	{
	}

	public void OnSortOrderToggled(CommonSortModel.Condition.SortCondition.SortOrder order)
	{
	}

	public void OnOkButtonPressed()
	{
	}

	public void SetOnSortSettingAppliedCallback(Action onApplied)
	{
	}

	public IEnumerator ToogleLockDelay(CommonSortSettingToggle sortToggle, bool isLock)
	{
		return null;
	}

	public bool IsWeaponFilterAllOn()
	{
		return default(bool);
	}
}
