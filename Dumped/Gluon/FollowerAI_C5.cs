namespace Gluon;

public class FollowerAI_C5 : FollowerAIBase
{
	private bool skipNextBurstCharge;

	public override bool ShouldSkipBurstCharge(PlayerCharacter owner)
	{
		return default(bool);
	}

	public override int GetChargeLevel(PlayerCharacter owner, CharacterBase target)
	{
		return default(int);
	}

	public override bool ShouldSkipCheckComboCancel(PlayerCharacter owner, int combo)
	{
		return default(bool);
	}
}
