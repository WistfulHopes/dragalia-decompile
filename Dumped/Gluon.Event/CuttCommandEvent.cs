namespace Gluon.Event;

public class CuttCommandEvent : EventBase<CuttCommandEvent>
{
	public enum CuttCommandTypes
	{
		None,
		Finished
	}

	public CuttCommandTypes type;

	public int cuttNumber;

	public int frame;
}
