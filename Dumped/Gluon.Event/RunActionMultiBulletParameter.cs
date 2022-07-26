using System.Collections.Generic;

namespace Gluon.Event;

public class RunActionMultiBulletParameter : RunActionParameterBase
{
	public uint randomSeed;

	public List<int> appearChildTaskIds;

	public int generateNum;

	public List<CharacterId> listLockOnDebuff;
}
