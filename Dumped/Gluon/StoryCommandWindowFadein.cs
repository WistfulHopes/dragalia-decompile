using System.Collections;

namespace Gluon;

public class StoryCommandWindowFadein : IStoryCommand
{
	private IEnumerator coroutine;

	private bool visible;

	private float sec;

	private bool isWithAnimation;

	public void Start(float sec, bool isWithAnimation = false)
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
