using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Http;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon.Mission;

public abstract class MissionSelectPopupBase : CommonPopup
{
	private const float ScrollbarDefaultValue = 1f;

	[SerializeField]
	public TabBase tab;

	[SerializeField]
	public MissionTableViewController[] scrollViewList;

	private List<MissionTableViewData> receivableRewardList;

	public Text textNoCellEntry;

	[SerializeField]
	protected Badge[] badges;

	[SerializeField]
	protected GameObject pagerRoot;

	[SerializeField]
	protected GameObject pagerLayout;

	[SerializeField]
	protected GameObject orignailPager;

	[SerializeField]
	protected GameObject pageFrameLeftArrow;

	[SerializeField]
	protected GameObject pageFrameRightArrow;

	protected bool isReloadingByExpired;

	public UnityAction updateBadgeCallback;

	protected int currentDataCount;

	protected int currentPageIndex;

	protected int pagesCount;

	protected int currentPageFrameIndex;

	protected int pageFramesCount;

	protected List<GameObject> pagers;

	protected List<int> pageTopIndexList;

	protected const int maxCellsPerPage = 100;

	protected const int maxPagersPerFrame = 6;

	protected MissionTableViewData[][] datas;

	protected int selectedTabIndex;

	private bool isGoChallengeMissionScene;

	public bool IsGoChallengeMissionScene => default(bool);

	protected abstract void UpdateBadge();

	public static int GetReceivableRewardCount(TabCategory category)
	{
		return default(int);
	}

	public virtual void ReloadData()
	{
	}

	public override void StartShowAnimation([Optional] UnityEvent onCompleted)
	{
	}

	public abstract void InitializeTabButton();

	protected int CountReceivableRewardList()
	{
		return default(int);
	}

	protected abstract void InitializeMissionTab();

	public void SwitchMissionTab(int tabIndex)
	{
	}

	public virtual void SwitchMissionTab()
	{
	}

	private void UpdateMissionContents(bool createPagers)
	{
	}

	public override void OnCancelButtonPressed()
	{
	}

	public override void OnCloseButtonPressed()
	{
	}

	public override void OnOkButtonPressed()
	{
	}

	public void OnValueChangedScrollView()
	{
	}

	public void OnListButtonPressed(int indexInList)
	{
	}

	protected abstract TabCategory GetSelectedMissionCategory();

	protected virtual void OpenDetailPopup(int indexInList, int dataIndex)
	{
	}

	public void OnCellChallengeButtonPressed(int indexInList)
	{
	}

	private static bool CheckMaintenance(MissionTransportType type, int value)
	{
		return default(bool);
	}

	public static bool GoChallengeMissionScene(MissionTransportType type, int value)
	{
		return default(bool);
	}

	protected abstract void SetCellDatas();

	private List<MissionTableViewData> MakeAllRewardList(MissionTableViewData[] dataList)
	{
		return null;
	}

	public static void RequestGetMissionList(Action successCallback)
	{
	}

	public static void OnError(ErrorType errorType, int resultCode)
	{
	}

	public abstract void ReloadWithRequestGetList();

	public void OnToShopButtonPressed()
	{
	}

	protected abstract void SetVisibleNoCellEntry(bool isNoEntry);

	private void CalcDataNumAndCreatePager(MissionTableViewData[] dataList, bool createPagers)
	{
	}

	private void CreatePagersForCurrentPageFrame()
	{
	}

	private MissionTableViewData[] GetDataListForPage(MissionTableViewData[] srcDataList, int pageIndex, int pageFrameIndex)
	{
		return null;
	}

	private void OnPagerButtonPressed(int index)
	{
	}

	public void OnPageFrameLeftButtonPressed()
	{
	}

	public void OnPageFrameRightButtonPressed()
	{
	}
}
