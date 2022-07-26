using System.Collections;

namespace Gluon;

public class StoryCommandCutSceneSoundStop : IStoryCommand
{
	private IEnumerator coroutine;

	public void Start()
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
