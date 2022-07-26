namespace Gluon.Event;

public struct RunActionEvent
{
	public int actionId;

	public RunActionParameterBase param;

	public bool IsEmpty()
	{
		return default(bool);
	}

	public void Clear()
	{
	}
}
