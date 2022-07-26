namespace Gluon.Event;

public class Statistics : EventBase<Statistics>
{
	public int roundTripTime;

	public int roundTripTimeVariance;

	public float incommingByteCountPerSec;

	public float outgoingByteCountPerSec;

	public int maxQueuedIncommingCommands;

	public int maxQueuedOutgoingCommands;
}
