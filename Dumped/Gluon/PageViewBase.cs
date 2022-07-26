using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class PageViewBase : MonoBehaviour
{
	public enum PageViewType
	{
		Normal,
		OnePage
	}

	public PageViewType pageViewType;

	public Transform contentParent;

	[SerializeField]
	private PageScrollViewRect scrollRect;

	public bool showLeftRightArrows;

	[SerializeField]
	public Button leftArrowButton;

	[SerializeField]
	public Button rightArrowButton;

	public bool showPager;

	[SerializeField]
	public GameObject pagerCenter;

	[SerializeField]
	public float pagerWidth;

	public bool enablePagerPress;

	[SerializeField]
	public bool shouldAutoExpandScrollRect;

	[HideInInspector]
	public bool isDisableCheckMoveToPageWhenIsTouchGuardEnable;

	protected List<CommonPager> pagers;

	protected int _currentPageIndex;

	protected List<GameObject> pages;

	public const int constCachedPageCount = 3;

	private int _cachedPageCount;

	protected int _pageCount;

	private bool _canScroll;

	public Action onBeforeMovePage;

	public Action<int> onBeforePagerSelect;

	private bool isMoveNextPage;

	public Action<int> onPageChanged;

	public Action<int> onPageReadyToChange;

	public Action<bool> onBeforeMovingCurrentPage;

	public Action<bool> onBeforeMovingNewPage;

	private int startIndex;

	public bool isResetPage;

	public Action<GameObject, int> setContentCallback;

	public bool isCycle;

	public bool enableQuickFlipToChangePage;

	public bool isPreIn;

	public bool isLoading;

	[SerializeField]
	public bool hasFadeWhileChangingPage;

	public float fadeDuration;

	public float delayFadeInTime;

	[SerializeField]
	public bool hasMoveBackAnimation;

	[SerializeField]
	public float autoFadeWidth;

	private float autoFadeCellWidth;

	[SerializeField]
	public List<MaintenanceFunctionType> maintenanceTypes;

	public float animationDuration => default(float);

	public int currentPageIndex
	{
		get
		{
			return default(int);
		}
		protected set
		{
		}
	}

	public GameObject currentPage => null;

	public GameObject rightPage => null;

	public GameObject leftPage => null;

	public int cachedPageCount => default(int);

	public int pageCount
	{
		get
		{
			return default(int);
		}
		private set
		{
		}
	}

	public int rawPageCount => default(int);

	public bool canScroll
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool isNewPageComing
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public PageScrollViewRect GetScrollRect()
	{
		return null;
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public virtual void RemoveAllPages(bool immediately = false)
	{
	}

	public void SetPageWidthToFullScreen(GridLayoutGroup gridLayoutGroup, Canvas canvas, float space = 0f, float keepMinimumSize = 0f)
	{
	}

	public void InitPages(GameObject prefab, int pageCount, int startPageIndex, Action<GameObject, int> setContentCallback)
	{
	}

	public void Reset()
	{
	}

	public void SetContentCallback(Action<GameObject, int> callback)
	{
	}

	private void CreatePages(GameObject prefab)
	{
	}

	public void SetStartPage(int index)
	{
	}

	private void SetHorizontalNormalizedPosition(float position, bool updateStartX = false)
	{
	}

	public void CheckMoveToPage(bool isNextPage, bool fromDragging)
	{
	}

	public void CheckMoveToPage(bool isNextPage)
	{
	}

	public void PlayMoveToPage()
	{
	}

	public void MoveToPreviousPage(bool fromDragging)
	{
	}

	private void MoveToPreviousPage(int index, bool fromDragging)
	{
	}

	public void MoveToNextPage(bool fromDragging)
	{
	}

	private void MoveToNextPage(int index, bool fromDragging)
	{
	}

	public void MoveToNextPage()
	{
	}

	public void MoveToPreviousPage()
	{
	}

	private void FadePage(GameObject go, bool isFadeIn, float delay = 0f)
	{
	}

	protected virtual void CreatePager()
	{
	}

	protected void OnPagerPressed(int pageIndex)
	{
	}

	public void MovePagerPage(int index)
	{
	}

	protected virtual void UpdatePager()
	{
	}

	private void UpdateArrows()
	{
	}

	public void UpdatePages(int indexDelta)
	{
	}

	public GameObject GetRawPageAtIndex(int index)
	{
		return null;
	}

	public void SetArrowPosOffetY(float offsetY)
	{
	}

	public void SetPageArrow(Button rightButton, Button leftBUtton)
	{
	}

	public void SetArrowButtonEnable(bool isLock)
	{
	}

	private void OnPageOrScrollPositionChangedForAutoFade()
	{
	}
}
