using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon;

public class FortMovingBackground : MonoBehaviour
{
	[Serializable]
	public class MovingCurve
	{
		public AnimationCurve x;

		public AnimationCurve y;

		public AnimationCurve z;
	}

	[SerializeField]
	private bool isEnabled;

	[SerializeField]
	private string[] movingObjectName;

	private List<GameObject> movingObjectInstanceList;

	[SerializeField]
	private GameObject[] movingObjectRoot;

	[SerializeField]
	private MovingCurve[] movingCurve;

	[SerializeField]
	private float[] movingDuration;

	private float[] movingTimer;

	[SerializeField]
	private float[] movingStartRatio;

	private List<Vector3> initialPositionList;

	private const string prefabFolderPath = "Prefabs/OutGame/Fort/Layout/3D/";

	private void Start()
	{
	}

	private IEnumerator LoadMovingObjectAsync()
	{
		return null;
	}

	private void Update()
	{
	}
}
