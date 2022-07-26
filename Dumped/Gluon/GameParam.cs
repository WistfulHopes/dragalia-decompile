using System;
using UnityEngine;

namespace Gluon;

[Serializable]
public class GameParam
{
	[SerializeField]
	private int _Id;

	[SerializeField]
	private float _SpAttack;

	[SerializeField]
	private float _SpDamage;

	[SerializeField]
	private int _ConsumeDp;

	[SerializeField]
	private int _DropDpOnEnemyDead;

	[SerializeField]
	private int _DropDpOnBossHpRate;

	[SerializeField]
	private float _ChainTime;

	[SerializeField]
	private float _MoveSpeed;

	[SerializeField]
	private float _DurationTime;

	[SerializeField]
	private float _DashStopTimeMin;

	[SerializeField]
	private float _DashStopTimeMax;

	[SerializeField]
	private float _DashAttackInputTime;

	[SerializeField]
	private float _DashMaxTime;

	[SerializeField]
	private float _DashSpeedRatio;

	[SerializeField]
	private float _DefenseHumanDashSpeedRatio;

	[SerializeField]
	private float _DefenseDragonDashSpeedRatio;

	[SerializeField]
	private float _ChargeStartTime;

	[SerializeField]
	private float _ChargePullThreshold;

	[SerializeField]
	private float _PlayerMass;

	[SerializeField]
	private float _DragonMass;

	[SerializeField]
	private float _MaxDepenetrationVelocity;

	[SerializeField]
	private float _SearchAbsoluteRange;

	[SerializeField]
	private float _SearchRangeCoefEnemy;

	[SerializeField]
	private float _SearchRangeCoefObject;

	[SerializeField]
	private float _SearchRangeCoefSwitch;

	[SerializeField]
	private float _BattleBgOffset;

	[SerializeField]
	private float _CriticalCoef;

	[SerializeField]
	private float _DragonDamageCoef;

	[SerializeField]
	private float _BreakDamageCoef;

	[SerializeField]
	private float _HealCoef;

	[SerializeField]
	private float _RaidHealCoef;

	[SerializeField]
	private float _MaxTensionAttackCoef;

	[SerializeField]
	private float _MaxTensionHealCoef;

	[SerializeField]
	private float _ReduceSecBurn;

	[SerializeField]
	private float _ReleaseFreezeAttackNum;

	[SerializeField]
	private float _ReduceSecSwoon;

	[SerializeField]
	private float _ReduceSecSlowMove;

	[SerializeField]
	private float _BlastSpGravity;

	[SerializeField]
	private float _BlastSpAngle;

	[SerializeField]
	private float _BlastSpHeight;

	[SerializeField]
	private float _BlastSpCoefficient;

	[SerializeField]
	private float _BlastRecoveryHeight;

	[SerializeField]
	private float _BlastRecoveryCoefficient;

	[SerializeField]
	private float _BlastLimitHeight;

	[SerializeField]
	private CameraController.ShakeType _BlastSpShakeType;

	[SerializeField]
	private CameraController.ShakeType _CriticalShakeType;

	[SerializeField]
	private float _FalloutHeight;

	[SerializeField]
	private float _PlayerDownLoopSec;

	[SerializeField]
	private float _PlayerDownLoopSecInBattleQuest;

	[SerializeField]
	private float _PlayerDownLoopSecWhenThrown;

	[SerializeField]
	private float _EnemyDownLoopSec;

	[SerializeField]
	private float _EnemyDownInvincibleSec;

	[SerializeField]
	private float _EnemyDownDamageCoefficient;

	[SerializeField]
	private float _RespawnInvincibleSec;

	[SerializeField]
	private float _RecoveryInvincibleSec;

	[SerializeField]
	private float _RecoverySafetyInvincibleSec;

	[SerializeField]
	private float _BlastRecoveryInvincibleSec;

	[SerializeField]
	private float _RecoveryLimitAngle;

	[SerializeField]
	private float _DragonTransformSec;

	[SerializeField]
	private float _DragonTransformBonusSec;

	[SerializeField]
	private float _DragonTransformRecastSec;

	[SerializeField]
	private float _DragonTransformPauseSec;

	[SerializeField]
	private float _DragonTransformMotionLoopSec;

	[SerializeField]
	private float _ReleaseDragonInvincibleSec;

	[SerializeField]
	private float _DragonHitEffectScale;

	[SerializeField]
	private float _EnemyPopInvincibleSec;

	[SerializeField]
	private float _HitStopDefaultFrameForHumanPlayer;

	[SerializeField]
	private float _HitStopDefaultFrameForDragonPlayer;

	[SerializeField]
	private float _HitStopDefaultFrameForBossEnemy;

	[SerializeField]
	private float _HitStopMotionSpeedScale;

	[SerializeField]
	private float _SkillFadeOutTime;

	[SerializeField]
	private float _SkillFadeInTime;

	[SerializeField]
	private float _SkillFadeInStartTime;

	[SerializeField]
	private float _SupportSkillRecastSec;

	[SerializeField]
	private float _UniqueTransformRecastSec;

	[SerializeField]
	private float _OthersSEVolumeRatio;

	[SerializeField]
	private float _FontEffectScale;

	[SerializeField]
	private int _RecoveryValueOnHitCount;

	[SerializeField]
	private int _MaxRecoveryValueOnHitCount;

	[SerializeField]
	private float[] _SwipeLength;

	[SerializeField]
	private float _ChargeMarkerEdgeSize;

	[SerializeField]
	private float _ChargeMarkerEdgePower;

	[SerializeField]
	private float _MaxCarrySec;

	[SerializeField]
	private float _PortalRegeneRate;

	[SerializeField]
	private float _PortalRegeneInterval;

	[SerializeField]
	private float _HpRecoveryFormulaCoef;

	[SerializeField]
	private float _FollowerDisableAvoidSec;

	[SerializeField]
	private float _DamageCutRateForHpShareDragon;

	[SerializeField]
	private float _DamageCutRateForServantMode;

	[SerializeField]
	private float _DamageCutRateForFollower;

	[SerializeField]
	private float _DamageAdjustCoef;

	[SerializeField]
	private float _HpRecoveryAdjustCoef;

	[SerializeField]
	private float _HpRecoveryAdjustCoefDependsOnHp;

	[SerializeField]
	private float _HpRecoveryAdjustCoefDependsOnAttack;

	[SerializeField]
	private float _HpDrainBuffLimitRate;

	[SerializeField]
	private string _HpDrainHitAttribute;

	[SerializeField]
	private int _SuperArmorLvForParameterDisparity;

	[SerializeField]
	private float _FreeFallSpeed;

	[SerializeField]
	private float[] _DebuffSlipPower;

	[SerializeField]
	private int _ActiveGaugeMaxValue;

	[SerializeField]
	private float _ActiveGaugeDiffMoveTime;

	[SerializeField]
	private float _ActiveGaugeResetGaugeAnimDelayTime;

	[SerializeField]
	private bool _ActiveGaugeResetGaugeAnimFlag;

	[SerializeField]
	private int _EnemyRouteModeSearchIntervalMin;

	[SerializeField]
	private int _EnemyRouteModeSearchIntervalMax;

	[SerializeField]
	private float _MultiPlayRetryVoteWaitTime;

	[SerializeField]
	private float _MultiPlayRetryDeniedRemainTime;

	[SerializeField]
	private float _InvincibleSecAfterAlloutAssault;

	[SerializeField]
	private float _OverdriveCounterLimitSolo;

	[SerializeField]
	private float _OverdriveCounterLimitMulti;

	[SerializeField]
	private float _MoveSpeedRateBMin;

	[Space]
	[SerializeField]
	private float _BuffHPMax;

	[SerializeField]
	private float _BuffHPMin;

	[SerializeField]
	private float _BuffAttackMax;

	[SerializeField]
	private float _BuffAttackMin;

	[SerializeField]
	private float _BuffDefenseMax;

	[SerializeField]
	private float _BuffDefenseMin;

	[SerializeField]
	private float _BuffDefenseBMax;

	[SerializeField]
	private float _BuffDefenseBMin;

	[SerializeField]
	private float _BuffCriticalMax;

	[SerializeField]
	private float _BuffCriticalMin;

	[SerializeField]
	private float _BuffSkillPowerMax;

	[SerializeField]
	private float _BuffSkillPowerMin;

	[SerializeField]
	private float _BuffBurstPowerMax;

	[SerializeField]
	private float _BuffBurstPowerMin;

	[SerializeField]
	private float _BuffRecoveryMax;

	[SerializeField]
	private float _BuffRecoveryMin;

	[SerializeField]
	private float _BuffRecoverySpMax;

	[SerializeField]
	private float _BuffRecoverySpMin;

	[SerializeField]
	private float _BuffAttackSpeedMax;

	[SerializeField]
	private float _BuffAttackSpeedMin;

	[SerializeField]
	private float _BuffDamageCutMax;

	[SerializeField]
	private float _BuffDamageCutBMax;

	[SerializeField]
	private float _BuffNickedMin;

	[SerializeField]
	private float _BuffChargeSpeedMax;

	[SerializeField]
	private float _BuffChargeSpeedMin;

	[SerializeField]
	private float _BuffGetHpRecoveryMax;

	[SerializeField]
	private float _BuffGetHpRecoveryMin;

	[Space]
	[SerializeField]
	private float _AbilityDragonTimeForPartyMaxValue;

	[SerializeField]
	private float _EnemyAbiityAttackRangeToleranceMin;

	public int Id => default(int);

	public float SpAttack => default(float);

	public float SpDamage => default(float);

	public int ConsumeDp => default(int);

	public int DropDpOnEnemyDead => default(int);

	public int DropDpOnBossHpRate => default(int);

	public float ChainTime => default(float);

	public float MoveSpeed => default(float);

	public float DurationTime => default(float);

	public float DashStopTimeMin => default(float);

	public float DashStopTimeMax => default(float);

	public float DashAttackInputTime => default(float);

	public float DashMaxTime => default(float);

	public float DashSpeedRatio => default(float);

	public float DefenseHumanDashSpeedRatio => default(float);

	public float DefenseDragonDashSpeedRatio => default(float);

	public float ChargeStartTime => default(float);

	public float ChargePullThreshold => default(float);

	public float PlayerMass => default(float);

	public float DragonMass => default(float);

	public float MaxDepenetrationVelocity => default(float);

	public float SearchAbsoluteRange => default(float);

	public float SearchRangeCoefEnemy => default(float);

	public float SearchRangeCoefObject => default(float);

	public float SearchRangeCoefSwitch => default(float);

	public float BattleBgOffset => default(float);

	public float CriticalCoef => default(float);

	public float DragonDamageCoef => default(float);

	public float BreakDamageCoef => default(float);

	public float HealCoef => default(float);

	public float RaidHealCoef => default(float);

	public float MaxTensionAttackCoef => default(float);

	public float MaxTensionHealCoef => default(float);

	public float ReduceSecBurn => default(float);

	public float ReleaseFreezeAttackNum => default(float);

	public float ReduceSecSwoon => default(float);

	public float ReduceSecSlowMove => default(float);

	public float BlastSpGravity => default(float);

	public float BlastSpAngle => default(float);

	public float BlastSpHeight => default(float);

	public float BlastSpCoefficient => default(float);

	public float BlastRecoveryHeight => default(float);

	public float BlastRecoveryCoefficient => default(float);

	public float BlastLimitHeight => default(float);

	public CameraController.ShakeType BlastSpShakeType => default(CameraController.ShakeType);

	public float FalloutHeight => default(float);

	public float PlayerDownLoopSec => default(float);

	public float PlayerDownLoopSecInBattleQuest => default(float);

	public float PlayerDownLoopSecWhenThrown => default(float);

	public float EnemyDownLoopSec => default(float);

	public float EnemyDownInvincibleSec => default(float);

	public float EnemyDownDamageCoefficient => default(float);

	public float RespawnInvincibleSec => default(float);

	public float RecoveryInvincibleSec => default(float);

	public float RecoverySafetyInvincibleSec => default(float);

	public float BlastRecoveryInvincibleSec => default(float);

	public float RecoveryLimitAngle => default(float);

	public float DragonTransformSec => default(float);

	public float DragonTransformBonusSec => default(float);

	public float DragonTransformRecastSec => default(float);

	public float DragonTransformPauseSec => default(float);

	public float DragonTransformMotionLoopSec => default(float);

	public float ReleaseDragonInvincibleSec => default(float);

	public float DragonHitEffectScale => default(float);

	public float EnemyPopInvincibleSec => default(float);

	public float HitStopDefaultFrameForHumanPlayer => default(float);

	public float HitStopDefaultFrameForDragonPlayer => default(float);

	public float HitStopDefaultFrameForBossEnemy => default(float);

	public float HitStopMotionSpeedScale => default(float);

	public float SkillFadeOutTime => default(float);

	public float SkillFadeInTime => default(float);

	public float SkillFadeInStartTime => default(float);

	public float SupportSkillRecastSec => default(float);

	public float UniqueTransformRecastSec => default(float);

	public float OthersSEVolumeRatio => default(float);

	public float FontEffectScale => default(float);

	public int RecoveryValueOnHitCount => default(int);

	public int MaxRecoveryValueOnHitCount => default(int);

	public float ChargeMarkerEdgeSize => default(float);

	public float ChargeMarkerEdgePower => default(float);

	public float MaxCarrySec => default(float);

	public float PortalRegeneRate => default(float);

	public float PortalRegeneInterval => default(float);

	public float HpRecoveryFormulaCoef => default(float);

	public float FollowerDisableAvoidSec => default(float);

	public float DamageCutRateForHpShareDragon => default(float);

	public float DamageCutRateForServantMode => default(float);

	public float DamageCutRateForFollower => default(float);

	public float DamageAdjustCoef => default(float);

	public float HpRecoveryAdjustCoef => default(float);

	public float HpRecoveryAdjustCoefDependsOnHp => default(float);

	public float HpRecoveryAdjustCoefDependsOnAttack => default(float);

	public float HpDrainBuffLimitRate => default(float);

	public string HpDrainHitAttribute => null;

	public int SuperArmorLvForParameterDisparity => default(int);

	public float FreeFallSpeed => default(float);

	public float[] DebuffSlipPower => null;

	public int ActiveGaugeMaxValue => default(int);

	public float ActiveGaugeDiffMoveTime => default(float);

	public float ActiveGaugeResetGaugeAnimDelayTime => default(float);

	public bool ActiveGaugeResetGaugeAnimFlag => default(bool);

	public int EnemyRouteModeSearchIntervalMin => default(int);

	public int EnemyRouteModeSearchIntervalMax => default(int);

	public float MultiPlayRetryVoteWaitTime => default(float);

	public float MultiPlayRetryDeniedRemainTime => default(float);

	public float InvincibleSecAfterAlloutAssault => default(float);

	public float OverdriveCounterLimitSolo => default(float);

	public float OverdriveCounterLimitMulti => default(float);

	public float MoveSpeedRateBMin => default(float);

	public float BuffHPMax => default(float);

	public float BuffHPMin => default(float);

	public float BuffAttackMax => default(float);

	public float BuffAttackMin => default(float);

	public float BuffDefenseMax => default(float);

	public float BuffDefenseMin => default(float);

	public float BuffDefenseBMax => default(float);

	public float BuffDefenseBMin => default(float);

	public float BuffCriticalMax => default(float);

	public float BuffCriticalMin => default(float);

	public float BuffSkillPowerMax => default(float);

	public float BuffSkillPowerMin => default(float);

	public float BuffBurstPowerMax => default(float);

	public float BuffBurstPowerMin => default(float);

	public float BuffRecoveryMax => default(float);

	public float BuffRecoveryMin => default(float);

	public float BuffRecoverySpMax => default(float);

	public float BuffRecoverySpMin => default(float);

	public float BuffAttackSpeedMax => default(float);

	public float BuffAttackSpeedMin => default(float);

	public float BuffDamageCutMax => default(float);

	public float BuffDamageCutBMax => default(float);

	public float BuffNickedMin => default(float);

	public float BuffChargeSpeedMax => default(float);

	public float BuffChargeSpeedMin => default(float);

	public float BuffGetHpRecoveryMax => default(float);

	public float BuffGetHpRecoveryMin => default(float);

	public float AbilityDragonTimeForPartyMaxValue => default(float);

	public float EnemyAbiityAttackRangeToleranceMin => default(float);

	public float SwipeLength(int idx)
	{
		return default(float);
	}
}
