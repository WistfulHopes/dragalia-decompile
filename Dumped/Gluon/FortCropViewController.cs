using UnityEngine;

namespace Gluon;

public class FortCropViewController : MonoBehaviour
{
	[SerializeField]
	private GameObject cropRoot;

	[SerializeField]
	private bool isSwitchDisp;

	[SerializeField]
	private GameObject cropDispOn;

	[SerializeField]
	private GameObject cropDispOff;

	private Renderer[] _renderers;

	private FortSortingOrderSetter[] _sortingOrderSetters;

	public Renderer[] renderers => null;

	public FortSortingOrderSetter[] sortingOrderSetters => null;

	public void Disp(bool value)
	{
	}

	public void SetCropDispActive(bool value)
	{
	}
}
