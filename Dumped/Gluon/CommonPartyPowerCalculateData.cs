using Gluon.Http;

namespace Gluon;

public class CommonPartyPowerCalculateData
{
	public int charaId;

	public int charaAtk;

	public int charaDef;

	public int charaHp;

	public int charaHpPlus;

	public int charaAtkPlus;

	public int charaSkillLvTotal;

	public int[] charaHasAbility;

	public int exAbilityLv;

	public int exAbility2Lv;

	public int burstLv;

	public int comboLv;

	public int charaRarity;

	public int skill3CharaId;

	public int skill4CharaId;

	public int dragonId;

	public int dragonLv;

	public int dragonLimitBreak;

	public int dragonPlus;

	public int dragonHpPlus;

	public int dragonAtkPlus;

	public int dragonSkillLv;

	public int dragonAbilityLv1;

	public int dragonAbilityLv2;

	public int dragonReliabilityLv;

	public int weaponId;

	public int weaponBuildupCount;

	public int weaponSkillLv;

	public int weaponLimitBreak;

	public int weaponLimitOver;

	public int talismanId;

	public int talismanAbility1Id;

	public int talismanAbility2Id;

	public int talismanAbility3Id;

	public int talismanAddAtk;

	public int talismanAddHp;

	public CommonPartyPowerCalculateAbilityCrestData[] crestType1List;

	public CommonPartyPowerCalculateAbilityCrestData[] crestType2List;

	public CommonPartyPowerCalculateAbilityCrestData[] crestType3List;

	public void SetData(CommonPartyPowerCalculateData baseData)
	{
	}

	public void SetCrestData(AbilityCrestList abilityCrestData, int typeNo, int num)
	{
	}

	public void SetAmuletData(UnitDetailModel.AmuletDetailData amuletDetailData, int typeNo, int num)
	{
	}

	public void SetTalismanData(UnitDetailModel.TalismanDetailData talismanDetailData)
	{
	}

	public CommonPartyPowerCalculateAbilityCrestData GetCrestData(int typeNo, int num)
	{
		return null;
	}
}
