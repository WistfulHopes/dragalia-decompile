using UnityEngine;

namespace Gluon;

public class CommonSortFilterUI : MonoBehaviour
{
	[SerializeField]
	private GiftType[] disableTargetSortTypes;

	[SerializeField]
	private CommonSortModel.Preset[] disableTargetSortPresets;

	[HideInInspector]
	public GiftType targetSortType;

	[HideInInspector]
	public CommonSortModel.Preset targetSortPreset;

	private bool isForceSetActive;

	private bool isFilterActive;

	private bool isStartTaskEnded;

	private void Start()
	{
	}

	public void SetActive(bool isActive)
	{
	}
}
