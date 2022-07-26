using Cute.Core;
using UnityEngine;

namespace Gluon.Dungeon;

public class ProximityObjectRabbit : FastUpdateMonoBehaviour
{
	private enum State
	{
		Idle,
		Surprise,
		MoveAway,
		MoveWaiting,
		MoveReturn
	}

	[SerializeField]
	private float SurpriseDistance;

	[SerializeField]
	private float AwayDistance;

	[SerializeField]
	private float WaitTimeSecond;

	[SerializeField]
	private Transform targetTransform;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float MoveEndTime;

	private Animator anim;

	private int hashMoveEnd;

	private int hashMoveIn;

	private int hashSurprise;

	private Vector3 initialPos;

	private Vector3 startPos;

	private Vector3 targetPos;

	private float moveWaitingTimer;

	private State state;

	private void Start()
	{
	}

	public override void FastUpdate()
	{
	}

	private void StartMove(Vector3 spos, Vector3 epos)
	{
	}

	private void OnSurpriseDistance()
	{
	}

	private void OnMoveStartDistance()
	{
	}

	private void OnDistanceExit()
	{
	}
}
