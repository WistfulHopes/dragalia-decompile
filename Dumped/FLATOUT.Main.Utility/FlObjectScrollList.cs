using System;
using UnityEngine;

namespace FLATOUT.Main.Utility;

public class FlObjectScrollList : FlScrollBase
{
	protected string _itemRootObjectName;

	protected GameObject _itemRootObject;

	protected GameObject _itemParentObject;

	protected string _itemScrollPositionObjectName;

	protected GameObject _itemScrollPositionObject;

	protected string _rangeStartObjectPath;

	protected Transform _rangeStartObject;

	protected string _rangeEndObjectPath;

	protected Transform _rangeEndObject;

	protected string _itemStartPrefix;

	protected string _itemEndPrefix;

	protected float _itemEndPositionOffset;

	protected Vector3 _currentRangeStartPosition;

	protected Vector3 _prevRangeStartPosition;

	protected Vector3 _currentRangeEndPosition;

	protected Vector3 _prevRangeEndPosition;

	protected int _currentIndex;

	protected int _currentMinIndex;

	protected int _currentMaxIndex;

	protected int _indexOffset;

	protected int _prevIndex;

	protected int _prevMinIndex;

	protected int _prevMaxIndex;

	protected int _scrollStartIndex;

	protected bool _muteItemStop;

	protected bool _isItemStop;

	protected bool _itemStopOneByOne;

	protected bool _existScrollBar;

	protected string _scrollBarMotionPath;

	protected FlScrollBar _scrollBar;

	protected bool _onScrollBar;

	protected bool _existCheckButtonList;

	protected string _checkButtonListMotionPath;

	protected FlCheckButtonList _checkButtonList;

	protected bool _onCheckButtonList;

	public FlObjectScrollListComponent Component => null;

	public string ItemStartPrefix => null;

	public string ItemEndPrefix => null;

	public GameObject ItemRootObject => null;

	public GameObject ItemScrollPositionObject => null;

	public Transform RangeStartObject => null;

	public Transform RangeEndObject => null;

	public bool IsItemStop => default(bool);

	public bool ItemStopOneByOne => default(bool);

	public FlScrollBar ScrollBar => null;

	public FlCheckButtonList CheckButtonList => null;

	public int CurrentIndex => default(int);

	public int PrevIndex => default(int);

	public int CurrentMinIndex => default(int);

	public int CurrentMaxIndex => default(int);

	public int IndexOffset => default(int);

	public int ItemCount => default(int);

	public void SetOtherPath(string rangeStartObjectPath, string rangeEndObjectPath, string itemStartObjectPrefix, string itemEndObjectPrefix)
	{
	}

	public void SetScrollBarPath(string scrollBarMotionPath)
	{
	}

	public void SetCheckButtonListPath(string checkButtonListMotionPath)
	{
	}

	protected override bool _InitializeThisData()
	{
		return default(bool);
	}

	private void _UpdateDirection()
	{
	}

	public void _InitializeItemRootObject(string newName, GameObject parentObject)
	{
	}

	public void _InitializeScrollBar()
	{
	}

	private void _OnDownInScrollBar(object arg)
	{
	}

	private void _OnDownLoopScrollBar(object arg)
	{
	}

	private void _OnDownOutScrollBar(object arg)
	{
	}

	public void _InitializeCheckButtonList()
	{
	}

	private void _OnCheckStartCheckButtonList(object arg)
	{
	}

	protected override void _ResetPrevValue()
	{
	}

	public override void _Release()
	{
	}

	protected override void _Update_Loop_Init()
	{
	}

	protected override void _Update_Scroll_Init()
	{
	}

	protected override void _Update_ScrollOut_Init()
	{
	}

	protected override void _Update_ScrollSpring_Init()
	{
	}

	protected override void _UpdateValueChange()
	{
	}

	protected override void _UpdatePrevValueChange()
	{
	}

	private void _UpdateItemRootPosition()
	{
	}

	private void _UpdateAllItemLength()
	{
	}

	private void _UpdateScrollIndex()
	{
	}

	private void _UpdateItem()
	{
	}

	private void _GetFreeItemObject(FlScrollItemInfo itemInfo)
	{
	}

	private void _UpdateItemScrollPositionObject()
	{
	}

	private void _CheckItemObject()
	{
	}

	private void _UpdateScrollBar()
	{
	}

	private void _UpdateCheckButtonList()
	{
	}

	public override bool _UpdateUI(object arg)
	{
		return default(bool);
	}

	public void SetScrollModeType(ScrollModeTypes scrollModeType)
	{
	}

	public void SetIndexOffset(int indexOffset)
	{
	}

	public void SetItemStop(bool enable)
	{
	}

	public void SetItemStop(bool enable, bool oneByOne)
	{
	}

	public void SetScrollPosition(float scrollPosition)
	{
	}

	public void SetScrollPosition(float scrollPositon, bool animation)
	{
	}

	[Obsolete]
	public void SetScrollIndex(int itemIndex)
	{
	}

	[Obsolete]
	public void SetScrollIndex(int itemIndex, bool animation)
	{
	}

	public void SetScrollPositionFromItemIndex(int itemIndex, bool animation)
	{
	}

	public void SetScrollPositionInRangeFromItemIndex(int itemIndex, bool animation)
	{
	}

	private void _GetDifferPositionFromItemIndex(int itemIndex, ref float differStart, ref float differEnd)
	{
	}

	public int GetScrollItemIndexFromPosition(float position)
	{
		return default(int);
	}

	public float GetScrollPositionFromItemIndex(int itemIndex)
	{
		return default(float);
	}

	private bool _ExistItemList()
	{
		return default(bool);
	}
}
