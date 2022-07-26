using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon;

public class AnimationBlendDurationOverrider : MonoBehaviour
{
	[Serializable]
	private class Data
	{
		public string fromClipName;

		public string toStateName;

		public float blendSec;
	}

	[SerializeField]
	private Data[] dataArray;

	[SerializeField]
	private float allBlendSec;

	private Animator animator;

	private Dictionary<string, Data> dataDict;

	private void Start()
	{
	}

	public bool GetBlendDuration(string nextState, out float blendDuration)
	{
		return default(bool);
	}

	private static string GetKeyString(string fromClipName, string toStateName)
	{
		return null;
	}
}
