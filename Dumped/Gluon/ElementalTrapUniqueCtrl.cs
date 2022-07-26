using System.Collections;
using System.Collections.Generic;

namespace Gluon;

public class ElementalTrapUniqueCtrl : EnemyUniqueCtrl
{
	public class TrapParameter
	{
		public ElementalType _element;

		public bool _either;
	}

	private List<TrapParameter> _traps;

	private RandomXorshift _random;

	private IEnumerator _coActiveTrap;

	public override void Initialize()
	{
	}

	public void ActiveTrap(float _delay, uint randomSeed)
	{
	}

	public IEnumerator CoActveTrap(float duration)
	{
		return null;
	}

	public void SetupAbility()
	{
	}

	public void PlayAbility()
	{
	}

	public void StopTrap()
	{
	}

	public void AllBurst()
	{
	}

	private void Shuffle(List<TrapParameter> list, uint randomSeed)
	{
	}
}
