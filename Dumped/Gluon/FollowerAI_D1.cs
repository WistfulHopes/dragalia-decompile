using UnityEngine;

namespace Gluon;

public class FollowerAI_D1 : FollowerAIBase
{
	private static readonly float searchRangeExtent;

	private static readonly Vector3 searchRangeOffset;

	public const float SQRT2 = 1.4142135f;

	public override bool IsPrioritizeBurstAttack(PlayerCharacter owner, CharacterBase target, float probabilityCoef = 1f, bool force = false)
	{
		return default(bool);
	}

	public override bool NeedsCheckPrioritizeBurstAttack()
	{
		return default(bool);
	}
}
