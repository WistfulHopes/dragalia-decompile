namespace Gluon;

public enum TrackRecordType
{
	ENTITY_GET = 10101,
	ENTITY_TARGET_GET = 10102,
	ENTITY_GET_OVER = 10103,
	ENTITY_TARGET_GET_OVER = 10104,
	UNIT_BUILDUP = 10201,
	UNIT_BUILDUP_TARGET = 10210,
	UNIT_LEVEL = 10214,
	UNIT_BUILDUP_COUNT = 10215,
	UNIT_LEVEL_MAX = 10202,
	UNIT_STATUS_PLUS_COUNT_MAX = 10203,
	UNIT_LIMIT_BREAK = 10204,
	UNIT_LIMIT_BREAK_COUNT = 10211,
	UNIT_GET = 10212,
	UNIT_GET_TARGET_WEAPON = 10206,
	UNIT_GET_TARGET_ELEMENT = 10207,
	UNIT_STORY_READ_TARGET = 10209,
	UNIT_STORY_READ = 10223,
	UNIT_BUILDUP_USE_MATERIAL_QUANTITY = 10208,
	UNIT_BUILDUP_OR_LIMIT_BREAK_USE_UNIT_QUANTITY = 10220,
	UNIT_AWAKE = 10221,
	CHARA_MANA_PIECE_UNLOCK_COUNT = 10213,
	CHARA_MANA_PIECE_ALL_UNLOCK_COUNT = 10222,
	CHARA_MANA_PIECE_UNLOCK_COUNT_TARGET_ELEMENT = 10244,
	ALL_UNIT_GET_TARGET_RARITY = 10224,
	UNIT_TARGET_LEVEL = 10230,
	CHARA_TARGET_MANA_PIECE_UNLOCK_COUNT = 10231,
	UNIT_TARGET_LIMIT_BREAK_COUNT = 10232,
	UNIT_TARGET_BUILDUP_COUNT = 10233,
	UNIT_HP_PLUS_COUNT = 10241,
	UNIT_ATTACK_PLUS_COUNT = 10242,
	UNIT_RESET_PLUS_COUNT = 10243,
	UNIT_LEVEL_TARGET_ELEMENT = 10245,
	UNIT_BUILDUP_COUNT_TARGET_ELEMENT = 10246,
	WEAPON_TARGET_CRAFT_SERIES_GET = 10250,
	WEAPON_TARGET_ABILITY_RARITY_GET = 10251,
	WEAPON_TARGET_CRAFT_STYLE_GROUP_GET = 10252,
	PARTY_ENTRUST_TARGET_ELEMENT = 10260,
	WEAPON_BODY_CRAFT = 12001,
	WEAPON_BODY_CRAFT_RARITY = 12002,
	WEAPON_BODY_CRAFT_RARITY_ELEMENTAL = 12003,
	WEAPON_BODY_CRAFT_ELEMENTAL = 12004,
	WEAPON_BODY_TARGET_CRAFT_SERIES_GET = 12005,
	WEAPON_BODY_LIMIT_OVER_COUNT = 12006,
	WEAPON_BODY_LIMIT_OVER_COUNT_ELEMENTAL_RARITY_SERIES = 12007,
	QUEST_CLEAR = 10301,
	QUEST_TARGET_CLEAR = 10302,
	QUEST_TARGET_FIRST_CLEAR = 10330,
	QUEST_TARGET_CLEAR_TIME = 10320,
	QUEST_TARGET_WAVE_CLEAR = 10321,
	QUEST_TARGET_WAVE_ALL_CLEAR = 10322,
	QUEST_TARGET_CLEAR_DAMAGE_COUNT = 10334,
	QUEST_GROUP_TARGET_CLEAR = 10303,
	QUEST_GROUP_TARGET_CLEAR_WITH_EQUIP_ABILITY_CREST = 10323,
	QUEST_GROUP_TARGET_GET_TREASURE = 10324,
	QUEST_BASE_GROUP_TARGET_CLEAR = 10335,
	QUEST_BASE_GROUP_TARGET_CLEAR_MULTI = 10336,
	QUEST_BASE_GROUP_DIFFICULTY_TARGET_CLEAR = 10337,
	QUEST_CLEAR_WITH_FRIEND = 10305,
	QUEST_CLEAR_WITH_OTHER_USER = 10331,
	QUEST_CLEAR_WITH_OTHER_USER_TOTAL_COUNT = 10332,
	QUEST_CLEAR_WITH_WEAPON_TYPE = 10333,
	QUEST_DEFENCE_COMPLETE_TARGET_CLEAR = 10341,
	QUEST_STORY_TARGET_CLEAR = 10311,
	QUEST_GET_TARGET_RAID_EVENT_ITEM = 10325,
	QUEST_GET_TARGET_MAZE_EVENT_ITEM = 10326,
	QUEST_GET_TARGET_BUILD_EVENT_ITEM = 10327,
	QUEST_GET_TARGET_COLLECT_EVENT_ITEM = 10328,
	QUEST_GET_TARGET_CLB_01_EVENT_ITEM = 10329,
	QUEST_GET_TARGET_SIMPLE_EVENT_ITEM = 10360,
	QUEST_GET_TARGET_EX_HUNTER_EVENT_ITEM = 10361,
	QUEST_GET_TARGET_COMBAT_EVENT_ITEM = 10362,
	QUEST_CARRY_BONUS_COUNT = 10370,
	QUEST_CLEAR_REBORN_COUNT_ZERO = 10371,
	QUEST_TARGET_CLEAR_REBORN_COUNT_ZERO = 10372,
	QUEST_GROUP_TARGET_SKIP_CLEAR = 10373,
	QUEST_CLEAR_BY_CHARA_WEAPON_TYPE = 10374,
	QUEST_CLEAR_BY_CHARA_ELEMENTAL_TYPE = 10375,
	QUEST_CLEAR_BY_CHARA_UNIT_TYPE = 10376,
	QUEST_TARGET_ENEMY_KILL = 10377,
	QUEST_TARGET_GET_QUEST_SCORING_MAX = 10378,
	QUEST_WALL_CLEAR = 10351,
	ENEMY_KILL = 10410,
	ENEMY_TARGET_KILL = 10401,
	ENEMY_TARGET_RARE_KILL = 10406,
	ENEMY_TARGET_BOSS_KILL = 10430,
	ENEMY_TARGET_TRIBE_TYPE_KILL = 10438,
	ENEMY_BROKEN = 10402,
	ENEMY_ALL_BROKEN = 10420,
	ENEMY_TARGET_KILL_WITH_EQUIP_ABILITY_CREST = 10439,
	RAID_HOST_BUTTLE = 10404,
	RAID_GUEST_BUTTLE = 10405,
	RAID_CLEAR_HOST_WITH_GUEST = 10421,
	RAID_CLEAR_WITH_EQUIP_ABILITY_CREST = 10422,
	BATTLE_COMBO_COUNT = 10411,
	BATTLE_DRAGON_CHANGE_COUNT = 10412,
	BATTLE_SKILL_USE_COUNT = 10431,
	BATTLE_TREASURE_BOX_OPEN_COUNT = 10432,
	BATTLE_DROP_OBJ_BROKEN_COUNT = 10433,
	BATTLE_DRAGON_PILLAR_BROKEN_COUNT = 10434,
	BATTLE_ENEMY_GUARD_BROKEN_COUNT = 10435,
	BATTLE_ENEMY_BREAK_COUNT = 10436,
	BATTLE_GIVE_DAMAGE = 10437,
	FORT_BUILD = 10501,
	FORT_LEVEL = 10520,
	FORT_LEVEL_UP = 10511,
	FORT_TARGET_PUT = 10512,
	FORT_TARGET_LEVEL = 10502,
	FORT_TARGET_ITEM_GET = 10503,
	FORT_DRAGON_PRESENT = 10504,
	FORT_DRAGON_CONTACT = 10510,
	FORT_DRAGON_RELIABILITY = 10521,
	FORT_DRAGON_RELIABILITY_MAX = 10505,
	FORT_TARGET_DRAGON_RELIABILITY = 10506,
	FORT_TOTAL_LEVEL = 10522,
	EVENT_CHARA_POINT = 10601,
	EVENT_ENTRY = 10602,
	EVENT_TRADE_GET = 10603,
	EVENT_TRADE_TARGET_GET = 10604,
	EVENT_STORY_READ_TARGET = 10611,
	EVENT_STORY_READ_COUNT = 10612,
	USER_LEVEL = 10801,
	MATERIAL_TRADE_GET = 10802,
	TREASURE_TRADE_COUNT = 10841,
	TREATURE_TRADE_TARGET_GET = 10843,
	ABILITY_CREST_TRADE_OPEN = 10850,
	FRIEND_SEND_REQUEST_COUNT = 10803,
	LOGIN_TOTAL = 10804,
	SET_SUPPORT_CHARA = 10805,
	TRANSITION = 10806,
	SET_EMBLEM = 10807,
	PARTY_SAME_ELEMENT = 10808,
	MISSION_TARGET_CLEAR = 10811,
	DAILY_MISSION_TARGET_CLEAR = 10830,
	PERIOD_MISSION_TARGET_CLEAR = 10831,
	NORMAL_MISSION_TARGET_CLEAR = 10832,
	BEGINNER_MISSION_TARGET_CLEAR = 10833,
	PLATFORM_MISSION_TARGET_CLEAR = 10834,
	MEMORY_MISSION_TARGET_CLEAR = 10845,
	ALBUM_MISSION_TARGET_CLEAR = 10846,
	ENEMY_BOOK_PIECE_MAX = 10812,
	ENEMY_BOOK_TARGET_TRIBE_PIECE_MAX = 10813,
	ENEMY_BOOK_TARGET_RARE_PIECE_MAX = 10814,
	CRAFT_CREATE_OR_ASSEMBLE_TARGET = 10815,
	CRAFT_CREATE_OR_ASSEMBLE_WEAPON_ELEMENTAL = 10816,
	CRAFT_CREATE_OR_ASSEMBLE_WEAPON_TYPE = 10817,
	CRAFT_CREATE = 10818,
	CRAFT_ASSEMBLE = 10819,
	CRAFT_CREATE_RARITY = 10820,
	CRAFT_ASSEMBLE_RARITY = 10821,
	CRAFT_CREATE_RARITY_ELEMENTAL = 10822,
	CRAFT_ASSEMBLE_RARITY_ELEMENTAL = 10823,
	CRAFT_CREATE_ELEMENTAL = 10824,
	CRAFT_ASSEMBLE_ELEMENTAL = 10825,
	CRAFT_CREATE_TARGETS = 10842,
	SUMMON_EXEC = 10835,
	ITEM_SUMMON_EXEC = 10840,
	PARTY_POWER = 10836,
	COIN_USE_TOTAL = 10837,
	MANA_USE_TOTAL = 10838,
	STAMINA_SINGLE_USE_TOTAL = 10839,
	NA_LINKAGE = 10900,
	GUILD_ATTEND_BONUS = 11000,
	DREAM_ADVENTURE_PLAY = 11101,
	DREAM_ADVENTURE_DIFFICULTY_CLEAR = 11102,
	WALKER_RELIABILITY_LEVEL = 11103,
	ALBUM_ENTITY_COMPLETE_COUNT = 11200,
	HONOR_GET_COUNT = 11211,
	BATTLE_ROYAL_CLEAR = 12000,
	DMODE_DUNGEON_CLEAR_FLOOR = 13000,
	DMODE_EXPEDITION_CLEAR_TOTAL_FLOOR = 13001,
	DMODE_DUNGEON_AND_EXPEDITION_CLEAR_TOTAL_FLOOR = 13002,
	DMODE_DUNGEON_CHARA_CLEAR_COUNT_FLOOR_20 = 13003,
	DMODE_DUNGEON_CHARA_CLEAR_COUNT_FLOOR_30 = 13004,
	DMODE_DUNGEON_CHARA_CLEAR_COUNT_FLOOR_40 = 13005,
	DMODE_DUNGEON_CHARA_CLEAR_COUNT_FLOOR_50 = 13006,
	DMODE_DUNGEON_CHARA_CLEAR_COUNT_FLOOR_60 = 13007,
	DMODE_DUNGEON_CHARA_CLEAR_COUNT_FLOOR_70 = 13008
}
