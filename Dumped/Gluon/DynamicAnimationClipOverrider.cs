using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon;

public class DynamicAnimationClipOverrider : MonoBehaviour
{
	[Serializable]
	public class OverrideData
	{
		[SerializeField]
		public string stateName;

		[SerializeField]
		public AnimationClip overrideClip;

		[SerializeField]
		public string triggerStateName;

		[SerializeField]
		public bool revertAfterPlay;

		[SerializeField]
		public float triggerNormalizedTime;
	}

	[Serializable]
	public class OverrideDataSet
	{
		public OverrideData[] data;
	}

	public OverrideDataSet[] dataSetArray;

	[SerializeField]
	private string revertDummyStateName;

	[SerializeField]
	private float revertMotionBlendSec;

	private Animator animator;

	private int reservedState;

	private AnimatorOverrideController newAnimatorOverrideController;

	private List<KeyValuePair<AnimationClip, AnimationClip>> originalOverriders;

	private List<KeyValuePair<AnimationClip, AnimationClip>> overriders;

	private AnimatorStateInfo[] stateCache;

	private string revertCheckStateName;

	private string trrigerStateName;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void SetState(int state)
	{
	}

	private bool CanChangeState()
	{
		return default(bool);
	}

	private void Override(int index)
	{
	}

	private void Revert()
	{
	}
}
