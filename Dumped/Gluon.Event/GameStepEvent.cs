namespace Gluon.Event;

public class GameStepEvent : EventBase<GameStepEvent>
{
	public enum StepTypes
	{
		None,
		BRRequestInitWorld,
		BRCompleteInitWorld,
		JoinBeginPartySwitch,
		JoinChangeCharacter
	}

	public StepTypes step;
}
