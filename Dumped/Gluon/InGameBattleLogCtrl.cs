using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class InGameBattleLogCtrl : FastUpdateMonoBehaviour
{
	private enum ButtonImageType
	{
		On,
		On_L,
		Off
	}

	public enum LogType
	{
		SimpleText,
		DmodeCommonItemIcon
	}

	public enum ButtonSortingOrderType
	{
		Default,
		ContinueCamera
	}

	public class LogData
	{
		public LogType logType;

		public string text;

		public int value;

		public bool isDisplayed;

		public void Setup([In] ref LogData data)
		{
		}

		public void Reset()
		{
		}
	}

	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _adjustRt;

	[SerializeField]
	private RectTransform _buttonRt;

	[SerializeField]
	private RectTransform _logRt;

	[SerializeField]
	private Button _button;

	[SerializeField]
	private SpriteRenderer _buttonImage;

	[SerializeField]
	private int _logDisplayNum;

	[SerializeField]
	private Sprite[] _buttonImageList;

	private VisibleUIObject _rootVisible;

	private VisibleUIObject _logVisible;

	private List<InGameBattleLogUI> _logUIList;

	private List<InGameBattleLogUI> _workLogUIList;

	private List<InGameBattleLogUI> _displayLogUIList;

	private List<LogData> _workLogDataList;

	private List<LogData> _standbyLogDataList;

	private List<LogData> _displayLogDataList;

	private List<LogData> _removeLogDataList;

	private bool _isLeft;

	private bool _isShow;

	private bool _isEnable;

	private Canvas _buttonCanvas;

	private const int LogUIListReserveNum = 8;

	private const int LogDataListReserveNum = 64;

	private const float SystemMessageDisplayTime = 2f;

	private int LogMaxNum => default(int);

	private int LogDisplayNum => default(int);

	public bool IsLogDisplayFast
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

	public static InGameBattleLogCtrl Create(GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize()
	{
	}

	public override void FastUpdate()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void SetLogEnable(bool enable)
	{
	}

	public void OnClickLog()
	{
	}

	private void SetVisibleLog(bool visible, bool force = false)
	{
	}

	private void ChangeButtonImage(bool on)
	{
	}

	private bool IsEnableButtonInput()
	{
		return default(bool);
	}

	public bool AddLog([In] ref LogData data)
	{
		return default(bool);
	}

	private void RegistDisplayLogDataList([In] ref LogData data)
	{
	}

	private void RemoveDisplayLogDataList()
	{
	}

	private void DisplayLog([In] ref LogData data, ref List<InGameBattleLogUI> list)
	{
	}

	private void SortHiddenLogUIByLogUIList([In] ref InGameBattleLogUI hiddenLogUI)
	{
	}

	public void ResetLog()
	{
	}

	public bool IsDisplayableUI(bool ignoreInside = false)
	{
		return default(bool);
	}

	private void SetDisplayFast([In] ref List<InGameBattleLogUI> list)
	{
	}

	private void GetDisplayLogUIList(ref List<InGameBattleLogUI> list)
	{
	}

	private InGameBattleLogUI GetHiddenLogUI()
	{
		return null;
	}

	public void SetLayout(bool isLeft, bool force = false)
	{
	}

	public void SetButtonSortingOrder(ButtonSortingOrderType type)
	{
	}
}
