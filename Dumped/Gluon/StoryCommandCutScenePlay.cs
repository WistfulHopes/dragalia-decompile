using System.Collections;

namespace Gluon;

public class StoryCommandCutScenePlay : IStoryCommand
{
	private IEnumerator coroutine;

	public void Start(string cutName)
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
