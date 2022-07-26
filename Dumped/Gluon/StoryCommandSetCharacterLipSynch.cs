namespace Gluon;

public class StoryCommandSetCharacterLipSynch : IStoryCommand
{
	public void Start(string charaId, float intervalMin = 1f / 15f, float intervalMax = 1f / 15f, float lipSynchingTime = 0.1f, int maxLipSynchFrame = 2)
	{
	}

	private void SetCharacterLipSynch(string charaId, float intervalMin, float intervalMax, float lipSynchingTime, int maxLipSynchFrame)
	{
	}
}
