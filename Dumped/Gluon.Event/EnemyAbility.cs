namespace Gluon.Event;

public class EnemyAbility : EventBase<EnemyAbility>
{
	public enum States
	{
		None,
		Show,
		Hide,
		Rampage,
		PlayDirection,
		CancelGoldenBarrier,
		ChildPlay,
		BookOfGenesis,
		BookOfDoomCount,
		ScapegoatTarget,
		TuningCount,
		TuningSwitch,
		TuningReset,
		PhoenixWallStop,
		BurningCount,
		BurningPlay,
		DevilFieldBurst,
		DevilFieldOnActive,
		ForcedBurstOfElementalTrap,
		MeteorStrikePlay,
		MeteorStrikeStop,
		MeteorStrikeProgress,
		TentacleLifeDown
	}

	public int dataId;

	public States state;

	public int value;

	public CharacterId target;

	public CharacterId owner;

	public int intParam;

	public string strParam;

	public float[] floatParams;
}
