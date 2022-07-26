using System.Collections.Generic;

namespace Gluon.Event;

public class RoomEntryCondition
{
	public struct Objective
	{
		public int textId;

		public static Objective GetEmptyObjective()
		{
			return default(Objective);
		}

		public bool IsEmpty()
		{
			return default(bool);
		}
	}

	public HashSet<ElementalType> unacceptedElementals;

	public HashSet<WeaponType> unacceptedWeapons;

	public int requiredPower;

	public Objective objective;

	public RoomEntryCondition()
	{
	}

	public RoomEntryCondition(RoomEntryCondition c)
	{
	}

	public static RoomEntryCondition Anyone()
	{
		return null;
	}
}
