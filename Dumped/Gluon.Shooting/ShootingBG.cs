using System;
using System.Collections;
using UnityEngine;

namespace Gluon.Shooting;

public class ShootingBG : MonoBehaviour
{
	[NonSerialized]
	public Camera mainCamera;

	[SerializeField]
	public Transform bgNode;

	[SerializeField]
	public RuntimeAnimatorController cameraController;

	[SerializeField]
	public GameObject sleepingGO;

	public Animator sleepingDragon;

	private Animator animator;

	private void Awake()
	{
	}

	public void Restart()
	{
	}

	private IEnumerator TriggerSleepCoroutine()
	{
		return null;
	}

	public void WakeDragon()
	{
	}
}
