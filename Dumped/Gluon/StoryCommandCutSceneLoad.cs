using System.Collections;

namespace Gluon;

public class StoryCommandCutSceneLoad : IStoryCommand
{
	private IEnumerator coroutine;

	public void Start(string cutScenePath)
	{
	}

	public override bool Update()
	{
		return default(bool);
	}

	private IEnumerator _Update()
	{
		return null;
	}
}
