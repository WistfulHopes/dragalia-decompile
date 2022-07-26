using System.Collections.Generic;

namespace Gluon.Event;

public class ChangeAbnormalStatus : EventBase<ChangeAbnormalStatus>
{
	[Required]
	public CharacterId character;

	[Required]
	public List<AbnormalStatusSyncData> abnormalStatus;

	public byte[] dummy;

	public short[] abnormalResists;
}
