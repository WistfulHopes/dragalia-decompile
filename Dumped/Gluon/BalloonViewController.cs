using System;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class BalloonViewController : FastUpdateMonoBehaviour
{
	[Serializable]
	public struct BalloonGradeOffsetInfo
	{
		public Vector3[] gradeOffsets;
	}

	[SerializeField]
	private Sprite[] balloonImages;

	[SerializeField]
	private SpriteRenderer balloonRenderer;

	[SerializeField]
	private GameObject balloonOffsetTarget;

	[SerializeField]
	private Transform balloonElementsBinder;

	[SerializeField]
	private BalloonGradeOffsetInfo[] balloonGradeOffsetInfos;

	[SerializeField]
	private float fixedDispSizeDistance;

	private Vector3 initialBalloonScale;

	private Vector3 initialBalloonPosition;

	private Vector3 animationOffset;

	[HideInInspector]
	public bool isBallonReady;

	[HideInInspector]
	public Action onBallonReady;

	public bool isFirstSetting;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetAnimation()
	{
	}

	private void SetAnimationImple(bool isUpdate)
	{
	}

	public void UpdateAnimationPos()
	{
	}

	protected void OnDestroy()
	{
	}

	public void SetImage(MaterialHarvester.HarvestType type, Facility.eFacilityModelGrade grade)
	{
	}

	private Sprite GetGivenTypeImage(MaterialHarvester.HarvestType type)
	{
		return null;
	}

	public override void FastUpdate()
	{
	}
}
