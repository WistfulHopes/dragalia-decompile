using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Event;

public class MultiWeakEvent : EventBase<MultiWeakEvent>
{
	public enum MultiWeakEventTypes
	{
		StartWeakPoint,
		AllWeakPontDefeated,
		TimerAction,
		NextWeakPoint,
		ClearWeakPoint,
		TurnAllWeak
	}

	public MultiWeakEventTypes type;

	public CharacterId character;

	public byte mode;

	public byte weakType;

	public byte appearanceNum;

	public int actionId;

	public float intervalTime;

	public float uiTimer;

	public int timerActionId;

	public List<Vector3> popPositionList;

	public bool waitDefeatedActionOnTimer;

	public bool showTimerUi;

	public bool isPlayActionOnShapeShit;

	public float effScale;

	public bool isCalcPopPositionRemotely;

	public bool waitDefeatedActionAfterExtra;

	public bool waitTimerActionAfterExtra;

	public bool enabledForEA;

	public int axis;

	public float offsetRotate;

	public string effectName;
}
