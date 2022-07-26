using System.Collections.Generic;

namespace Gluon.Event;

public class GoToIngameInfo
{
	public class ActorData
	{
		public int ActorId;

		public ulong ViewerId;
	}

	public class BRInitData
	{
		public int locationPattern;

		public List<int> playerPositions;

		public string multiPlayKey;
	}

	public List<ActorData> elements;

	public BRInitData brInitData;
}
