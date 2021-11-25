using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum PaymentType
	{
		NONE = 0,
		MONEY = 1,
		DIAMOND = 2,
		CRYSTAL = 3,
		CRYSTAL_OR_DIAMOND = 4,
		COIN = 5,
		MANA_POINT = 6,
		DEW_POINT = 7,
		SUMMON_TICKET = 8,
		SUMMON_CAMPAIGN = 9,
		SUMMON_BEGINNER_CAMPAIGN = 10,
		BUILD_TIME_POINT = 11,
		ITEM_SUMMON_CAMPAIGN = 12,
		TUTORIAL_TICKET_SUMMON = 13,
		SUMMON_CAMPAIGN_ONE_HUNDRED = 14,
		OTHER = 99
	}
}