using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon;

public class StampControllerIngame : PageScrollController<StampPageData>
{
	[SerializeField]
	private StampCarsouseIcons carsouselIcons;

	[SerializeField]
	private float carsouseIconMergin;

	public UnityAction<int> pageButtonCallBack;

	protected int pageDataNum;

	private const string changePageSe = "SE_OUT_COMMON_0005";

	public bool Initialized
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

	protected override void Start()
	{
	}

	private void OnIconPressed(int selectStampID)
	{
	}

	protected override void ChangePage(int index)
	{
	}

	public void ChangePageButton(int direction)
	{
	}

	private void UpdateCarsousel()
	{
	}

	public void ApplyCarsouselIcon()
	{
	}
}
