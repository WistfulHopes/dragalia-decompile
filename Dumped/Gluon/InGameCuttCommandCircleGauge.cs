using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;
using FLATOUT.Main;
using UnityEngine;

namespace Gluon;

public class InGameCuttCommandCircleGauge : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform adjustRt;

	[SerializeField]
	private CircleGauge gaugeCtrl;

	[SerializeField]
	private string parentObjName;

	[SerializeField]
	private string replacePlaneName;

	[SerializeField]
	private int targetPlaneSortOrder;

	private RectTransform rootRt;

	private RectTransform gaugeRt;

	private FlPlane targetFlPlane;

	private Vector3 gaugeInitScale;

	private float gaugeRate;

	public bool isVisible
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

	public static InGameCuttCommandCircleGauge Create([Optional] GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize(GameObject parent, int siblingIndex)
	{
	}

	public void SetParent(GameObject parent, int siblingIndex = -1)
	{
	}

	public override void FastUpdate()
	{
	}

	private void UpdateFlPlane()
	{
	}

	public void SetGaugeRate(float rate, bool isForce = false)
	{
	}

	public void Visible(bool b, bool isForce = false)
	{
	}

	public void SetFlRoot(FlRoot flRoot, bool isSetParent = true)
	{
	}
}
