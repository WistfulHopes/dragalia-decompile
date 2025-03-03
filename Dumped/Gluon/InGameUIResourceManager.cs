using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using Cute.UI;
using Gluon.Master;
using UnityEngine;

namespace Gluon;

public class InGameUIResourceManager : FastUpdateMonoBehaviour
{
	public enum AtlasRefType
	{
		UI,
		Dmode
	}

	[SerializeField]
	private float _shaderSaturationMonochromeValue;

	[SerializeField]
	private float _shaderBrightnessMonochromeValue;

	private Dictionary<int, InGameUICharaResourceData> _charaResourceDic;

	private Dictionary<int, InGameUIDragonResourceData> _dragonResourceDic;

	private Dictionary<int, InGameUIDragonResourceData> _reserveDragonResourceDic;

	private InGameUIMatarialData _emptyItemSkillMaterialData;

	private InGameUIMatarialData _shareSkillSelectMaterialData;

	private Material _dragonSelectButtonMaterial;

	private Dictionary<AtlasRefType, AtlasReference> _atlasRefDataDic;

	private Dictionary<AtlasRefType, Dictionary<string, Sprite>> _iconNameResourceDic;

	private Dictionary<string, Sprite> _buffIconNameResourceDic;

	private Dictionary<AbnormalStatusType, Sprite> _abnormalStatusTypeIconResourceDic;

	private Dictionary<EnemyAbilityType, Sprite> _enemyAbilityTypeIconResourceDic;

	private Dictionary<int, Sprite> _usedBuffIconIdResourceDic;

	private Dictionary<TribeType, Sprite> _tribeTypeIconResourceDic;

	private Dictionary<DmodeDungeonItemType, Sprite> _dmodeCommonItemIconResourceDic;

	public static readonly string SkillItemEmptyIconName;

	public static readonly string ShareSkillSelectIconName;

	public static readonly string DragonSelectIconName;

	public static readonly string TribeIconBgName;

	public static readonly string WeaponSkillIconName;

	private static readonly Dictionary<AbnormalStatusType, string> AbnormalStatusIconNameDic;

	private static readonly Dictionary<EnemyAbilityType, string> EnemyAbilityIconNameDic;

	private static readonly Dictionary<TribeType, string> TribeIconNameDic;

	private static readonly Dictionary<DmodeDungeonItemType, string> DmodeCommonItemIconNameDic;

	public static InGameUIResourceManager instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public int shaderSaturationPropertyID
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

	public int shaderBrightnessPropertyID
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

	public float shaderSaturationMonochromeValue => default(float);

	public float shaderBrightnessMonochromeValue => default(float);

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	public void Initialize()
	{
	}

	private void SetupAtlasRefData(AtlasRefType type, AtlasReference atlasRefData, Action<Sprite> onUpdate)
	{
	}

	private void AddIconSprite(AtlasRefType type, Sprite sprite)
	{
	}

	private void AddIconSpriteForBuff(Sprite sprite)
	{
	}

	private void AddIconSpriteForAbnormalStatus(Sprite sprite)
	{
	}

	private void AddIconSpriteForEnemyAbility(Sprite sprite)
	{
	}

	private void AddIconSpriteForTribe(Sprite sprite)
	{
	}

	private void AddIconSpriteForDmodeCommonItem(Sprite sprite)
	{
	}

	private int GetCharaId(CharacterBase chara)
	{
		return default(int);
	}

	public bool SetupCharaResource(HumanCharacter human)
	{
		return default(bool);
	}

	public bool SetupCharaResource(ref Dictionary<int, InGameUIDragonResourceData> resourceDic, DragonCharacter dragon)
	{
		return default(bool);
	}

	public bool SetupCharaResource(DragonCharacter dragon)
	{
		return default(bool);
	}

	public bool SetupReserveDragonResource(CharacterSelector selector)
	{
		return default(bool);
	}

	public IEnumerator LoadDmodeWeaponSkillResource(CharacterBase chara, List<int> skillIdList, Action onLoaded)
	{
		return null;
	}

	public bool IsLoadedSkillMaterialData(Dictionary<int, InGameUIMatarialData> materialDataDict)
	{
		return default(bool);
	}

	public bool GetCharaFaceResource(CharacterBase chara, out Material material, out Material materialMono, out Sprite sprite, out Sprite spriteMono)
	{
		return default(bool);
	}

	public bool GetCharaResourceForPartyButton(CharacterBase chara, out Material material, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetCharaBustupResource(CharacterBase chara, out Material material, out Material damageMaterial)
	{
		return default(bool);
	}

	public bool GetCharaBustupResource(CharacterBase chara, out Material material)
	{
		return default(bool);
	}

	public bool GetCharaDmodeStrategyResource(CharacterBase chara, out Material material)
	{
		return default(bool);
	}

	public bool GetDragonButtonResource(CharacterBase chara, out Material material)
	{
		return default(bool);
	}

	public bool GetUniqueTransButtonResource(CharacterBase chara, out Material material)
	{
		return default(bool);
	}

	public bool GetSkillButtonResource(CharacterBase chara, int skillId, out string iconName, out Material material, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetEmptyItemSkillButtonResource(out string iconName, out Material material, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetShareSkillSelectButtonResource(out string iconName, out Material material, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetDragonSelectButtonResource(out Material material)
	{
		return default(bool);
	}

	public bool GetIconResource(AtlasRefType type, string name, out Material material, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetBuffIconResource(int id, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetAbnormalStatusIconResource(AbnormalStatusType type, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetEnemyAbilityTypeIconResource(EnemyAbilityType type, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetTribeTypeIconResource(TribeType type, out Sprite sprite, out Material material)
	{
		return default(bool);
	}

	public bool GetDmodeCommonItemIconResource(DmodeDungeonItemType type, out Sprite sprite, out Material material)
	{
		return default(bool);
	}

	public bool GetAtlasMaterial(AtlasRefType type, out Material material)
	{
		return default(bool);
	}

	public bool HasAtlasRefData(AtlasRefType type)
	{
		return default(bool);
	}

	public bool LoadCharaFaceResource(InGameUICharaResourceData resourceData, HumanCharacter human)
	{
		return default(bool);
	}

	public bool LoadDragonFaceResource(InGameUIDragonResourceData resourceData, DragonCharacter dragon)
	{
		return default(bool);
	}

	public bool LoadCharaBustupResource(InGameUICharaResourceData resourceData, HumanCharacter human)
	{
		return default(bool);
	}

	public bool LoadDragonBustupResource(InGameUIDragonResourceData resourceData, DragonCharacter dragon)
	{
		return default(bool);
	}

	public bool LoadCharaDmodeStrategyResource(InGameUICharaResourceData resourceData, HumanCharacter human)
	{
		return default(bool);
	}

	public bool LoadDragonDmodeStrategyResource(InGameUIDragonResourceData resourceData, DragonCharacter dragon)
	{
		return default(bool);
	}

	private bool LoadDragonButtonResource(InGameUIDragonResourceData resourceData, DragonCharacter dragon)
	{
		return default(bool);
	}

	private bool LoadDragonButtonMaterial(string iconName, out Material iconMaterial)
	{
		return default(bool);
	}

	private bool LoadUniqueTransButtonResource(InGameUICharaResourceData resourceData, HumanCharacter human)
	{
		return default(bool);
	}

	private void LoadSkillButtonResource(InGameUICommonResourceData resourceData, CharacterBase chara)
	{
	}

	private void LoadSkillButtonResource(Dictionary<int, InGameUIMatarialData> materialDataDict, CharacterBase chara, SkillDataElement sde, bool isSync = false)
	{
	}

	private void LoadSkillButtonResource(Dictionary<int, InGameUIMatarialData> materialDataDict, CharacterBase chara, int skillId)
	{
	}

	private void LoadAdvanecedSkillButtonResource(Dictionary<int, InGameUIMatarialData> materialDataDict, CharacterBase chara, CharacterSkillData data)
	{
	}

	private void LoadBaseIdSkillButtonResource(Dictionary<int, InGameUIMatarialData> materialDataDict, CharacterBase chara, CharacterSkillData data)
	{
	}

	private void LoadAdvanecedSkillButtonResource(Dictionary<int, InGameUIMatarialData> materialDataDict, CharacterBase chara, ActionParts action)
	{
	}

	private void LoadModeChangeSkillButtonResource(Dictionary<int, InGameUIMatarialData> materialDataDict, HumanCharacter chara)
	{
	}

	private void LoadModeChangeSkillButtonResource(Dictionary<int, InGameUIMatarialData> materialDataDict, HumanCharacter chara, CharaModeDataElement cmde)
	{
	}

	private void LoadChainSkillButtonResource(Dictionary<int, InGameUIMatarialData> materialDataDict, HumanCharacter human)
	{
	}

	private void LoadChainSkillButtonResource(Dictionary<int, InGameUIMatarialData> materialDataDict, HumanCharacter human, SkillChainDataElement cde)
	{
	}

	private void LoadOverChargeSkillButtonResource(Dictionary<int, InGameUIMatarialData> materialDataDict, CharacterBase chara, CharacterSkillData data)
	{
	}
}
