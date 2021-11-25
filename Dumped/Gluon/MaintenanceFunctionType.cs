using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum MaintenanceFunctionType
	{
		NONE = 0,
		ALL = 2000,
		QUEST_MAIN = 2010,
		QUEST_EVENT = 2020,
		QUEST_MULTI = 2030,
		QUEST_MULTI_MAIN = 2040,
		QUEST_MULTI_EVENT = 2045,
		BUILDUP = 2050,
		BUILDUP_CHARA = 2051,
		BUILDUP_MANA_CIRCLE = 2052,
		BUILDUP_WEAPON_BODY = 2053,
		LIMIT_BREAK_WEAPON = 2054,
		BUILDUP_DRAGON = 2055,
		LIMIT_BREAK_DRAGON = 2056,
		BUILDUP_ABILITY_CREST = 2057,
		LIMIT_BREAK_AMULET = 2058,
		PARTY_EDIT = 2060,
		FORT = 2070,
		FORT_FORT = 2071,
		FORT_KNIGHTS_STORY = 2072,
		FORT_DRAGON_STORY = 2073,
		FORT_DRAGON_CONTACT = 2074,
		FORT_CASTLE_STORY = 2075,
		SUMMON = 2080,
		ITEM = 2090,
		MISSION = 2100,
		FRIEND = 2110,
		STAMP = 2120,
		MUSEUM = 2130,
		CRAFT = 2140,
		SHOP_ALL = 2150,
		SHOP_SPECIAL = 2151,
		SHOP_MATERIAL = 2152,
		SHOP_MATERIAL_SUMMON = 2153,
		SHOP_MATERIAL_SHOP = 2154,
		SHOP_NORMAL = 2155,
		SHOP_NORMAL_DIA = 2156,
		SHOP_NORMAL_STAMINA = 2157,
		SHOP_NORMAL_EXTENSION = 2158,
		SHOP_TRADE = 2159,
		SHOP_GET_BONUS_STONE = 2160,
		SHOP_GET_BONUS_STAMINA = 2161,
		PAYMENT_IOS = 2162,
		PAYMENT_ANDROID = 2163,
		SHOP_ABILITY_CREST_TRADE = 2164,
		SHOP_BONUS = 2165,
		SHOP_BONUS_STONE = 2166,
		SHOP_BONUS_STAMINA = 2167,
		SHOP_BONUS_QUEST = 2168,
		MATCHING_FRIEND = 2170,
		QUEST_WALL = 2180,
		RESET_PLUS_COUNT = 2190,
		RESET_PLUS_COUNT_CHARA = 2191,
		RESET_PLUS_COUNT_WEAPON = 2192,
		RESET_PLUS_COUNT_DRAGON = 2193,
		RESET_PLUS_COUNT_ABILITY_CREST = 2194,
		GUILD = 2200,
		BATTLE_ROYAL_EVENT = 2210,
		BATTLE_ROYAL = 2211,
		STORY_SKIP = 2220,
		EXCHANGE_TICKET = 2230
	}
}