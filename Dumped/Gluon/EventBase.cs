using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using MessagePack;

namespace Gluon;

public class EventBase<T> where T : EventBase<T>
{
	public ushort _raiseEventSequenceId;

	[IgnoreMember]
	public int actorId
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public byte[] Serialize(ushort nextSequenceId)
	{
		return null;
	}

	public static T Deserialize(EventData photonEvent)
	{
		return null;
	}
}
