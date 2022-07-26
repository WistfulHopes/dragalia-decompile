using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon;

[Serializable]
public class PointerEventHandler : FastUpdateMonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
	[Serializable]
	public class TouchEvent : UnityEvent<PointerEventData>
	{
	}

	public static WeakReference globalTouchingHandler;

	public UnityEvent onClick;

	public UnityEvent onLongClick;

	public Toggle.ToggleEvent onToggleClicked;

	private TouchEvent _onPointerEnter;

	private TouchEvent _onPointerExit;

	private TouchEvent _onPointerDown;

	private TouchEvent _onPointerUp;

	[HideInInspector]
	public UnityEvent onDelayPressReleased;

	[SerializeField]
	public bool canLongTouch;

	[SerializeField]
	public bool canKeepLongTouch;

	[SerializeField]
	public bool needHandleMultiTouch;

	public float longTouchThreshold;

	public float keepLongTouchDuration;

	public float doubleTouchThreshold;

	private bool isCanceled;

	public static DateTime lastTouchDownDateTime;

	private float touchTime;

	private Vector3 startTouchPos;

	private float lastKeepLongTouchCalledTime;

	private bool isRepeatClick;

	private StandaloneInputModuleCustom inputModule;

	private Selectable targetSelectable;

	private bool isOn;

	private bool isToggle;

	private Coroutine watchTouchCoroutine;

	[HideInInspector]
	public bool isBlockingByUIAnimation;

	public static bool suppressBigEffect;

	public Action onClickAnimation;

	public UnityAction<float> onFlickVertical;

	public float shrinkTouchGap;

	public bool isMultiSelect;

	private bool isPointerDownChecked;

	[SerializeField]
	public bool isShowTapEffect;

	[SerializeField]
	private bool checkExitOnPointerUp;

	public TouchEvent onPointerEnter
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TouchEvent onPointerExit
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TouchEvent onPointerDown
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TouchEvent onPointerUp
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private float touchGap
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private float realShrinkTouchGap
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	private void StopWatchTouchCoroutine()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	private void RemoveGlobalTouch()
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void PreventFortCursol()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void PlaySE()
	{
	}

	private IEnumerator WatchTouch(PointerEventData eventData)
	{
		return null;
	}

	private bool IsMoved(Vector3 curTouchPos)
	{
		return default(bool);
	}

	private float FlickVertical(Vector3 curTouchPos)
	{
		return default(float);
	}

	private bool IsValidClick(PointerEventData pointEventData)
	{
		return default(bool);
	}

	private bool IsTargetValid()
	{
		return default(bool);
	}

	protected override void OnDisable()
	{
	}

	private void ResetToggleState()
	{
	}

	public void ResetFlagWhenIsOnChangedByScript()
	{
	}

	public void ForceReleaseTargetSelectable()
	{
	}

	public void ReplaceCallback(UnityAction callback)
	{
	}
}
