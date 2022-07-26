using System.Collections.Generic;

namespace Gluon.Event;

public class ChangeBuff : EventBase<ChangeBuff>
{
	[Required]
	public CharacterId character;

	[Required]
	public List<ParameterSyncData> addParameters;

	[Required]
	public List<RemoveSyncData> removeParameters;

	[Required]
	public List<RegenerationSyncData> addRegenerations;

	[Required]
	public List<RemoveSyncData> removeRegenerations;

	[Required]
	public List<GrantSyncData> addGrants;

	[Required]
	public List<RemoveSyncData> removeGrants;

	[Required]
	public List<UnifiedParameterSyncData> addUnifiedParameters;

	[Required]
	public List<RemoveSyncData> removeUnifiedParameters;
}
