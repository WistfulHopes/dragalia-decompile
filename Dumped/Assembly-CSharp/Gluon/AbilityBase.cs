﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AbilityBase
	{
		// Fields
		private float lastCheckRunOptionActionTime;
		private const float runOptionActionCheckInterval = 0.3f;
	
		// Constructors
		public AbilityBase();
	
		// Methods
		protected void Apply(CharacterBase owner, AbilityCondition conditionType, int type, int abilityId, int variousId, string variousStr, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate, float conditionValue);
		protected void Reset(CharacterBase owner, int type, AbilityTargetAction actionType, int variousId, int abilityId);
		protected void ApplyStatusUp(CharacterBase owner, int variousId, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void ApplyActionDamageUp(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void ApplyActionDamageDown(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void ApplyActionDamageUpDependsOnHitCount(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, string strDatas);
		private void AddActionPowerDependsOnHitCount(CharacterParameter.FluctuationParameter param, int actionType, int hitCount, float rate);
		public void ApplyAbnormalStatusResist(int variousId, ref CharacterParameter.FluctuationParameter param, float rate);
		public void ApplyAbnormalStatusAdd(CharacterBase owner, int variousId, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		public void ApplyCriticalUp(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		public void ApplyCriticalUpForSkillAbility(CharacterBase owner, AbilityTargetAction actionType, AbilityTargetAction defaultActionType, ref CharacterParameter.FluctuationParameter param, float rate);
		public void ApplyRecoveryHpUp(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		public void ApplyBreakGaugeDamageUp(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		public void ApplyBreakDamageUp(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void ApplyStatusUpBuffExtention(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void ApplyStatusUpDebuffExtention(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void ApplyAbnormalStatusExtention(CharacterBase owner, int variousId, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void AddCriticalParamDependsOnEnemyStatus(Dictionary<int, float> criticalCrt, int type, float rate);
		private void ApplyCrisisRate(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void ApplyAbonormalKillerDependsOnTypeCount(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, string strDatas);
		public static bool IsMatchCondition(CharacterBase owner, WeaponType weaponType);
		public static bool IsMatchCondition(CharacterBase owner, int targetUnitType, int ownerUnitType, ElementalType elementalType);
		public static bool IsMatchCondition(CharacterBase owner, int targetUnitType, ElementalType elementalType);
		public static bool IsMatchCondition(CharacterBase owner, int requiredActionConditionId, int count);
		public static bool IsMatchCondition(CharacterBase owner, int disappearToEnableBuff);
		public static bool IsMatchCondition(CharacterBase owner, AbilityCondition conditionType, float conditionValue, float conditionValue2, int probability, AbilityTargetAction targetAction = AbilityTargetAction.NONE);
		public static bool IsMatchTargetAction(CharacterBase owner, AbilityTargetAction targetAction, int actionId, bool includesEnhanced = false);
		public static AbilityTargetAction GetTargetAction(CharacterBase actor, int actionId);
		public static AbilityTargetAction ConvertTargetActionForSkillAbility(CharacterBase actor, AbilityTargetAction targetActionId);
		public static bool IsEnableApplyCharacter(CharacterBase owner);
		public static CharacterBase GetHostileTarget(CharacterBase target);
	}
}
