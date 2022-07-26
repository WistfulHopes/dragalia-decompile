using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon;

public class PassDownEvent : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
	[SerializeField]
	private GameObject[] passTargets;

	private List<RaycastResult> raycastResults;

	private List<GameObject> lowerObjects;

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void PassEvent<T>(PointerEventData data, ExecuteEvents.EventFunction<T> function) where T : IEventSystemHandler
	{
	}

	private void GetLowerObjects(PointerEventData data, List<GameObject> lowerObjects)
	{
	}
}
