using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon;

public class CommonScrollRect : ScrollRect
{
	public bool resetPositionOnResume;

	[SerializeField]
	public bool isShowTapEffect;

	private bool isNativeDraggin;

	private float lastValue;

	private bool isForceCancelScroll;

	protected override void Start()
	{
	}

	protected override void LateUpdate()
	{
	}

	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	public override void OnDrag(PointerEventData eventData)
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	public void StopScroll()
	{
	}

	public void RestartScroll()
	{
	}
}
