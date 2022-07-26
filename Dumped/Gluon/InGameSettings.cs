using System;
using System.Collections.Generic;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon;

[CreateAssetMenu]
public class InGameSettings : ScriptableObject
{
	[Serializable]
	public class RebornParams
	{
		[SerializeField]
		public float hpRatio;

		[SerializeField]
		public float waitingSec;

		[SerializeField]
		public float invincibleSec;

		[SerializeField]
		public int debuffId;
	}

	[Serializable]
	public class UnitScaleParam
	{
		[SerializeField]
		public string modelId;

		[SerializeField]
		public float scale;
	}

	[Serializable]
	public class PlayerAIParam
	{
		[Serializable]
		public class ModeParam
		{
			[SerializeField]
			public string skillId;

			[SerializeField]
			public int count;
		}

		[Serializable]
		public class DisableMoveParam
		{
			[SerializeField]
			public int actionId;

			[SerializeField]
			public float durationSec;

			[SerializeField]
			public int buffIconId;
		}

		[SerializeField]
		public string charaId;

		[SerializeField]
		public PlayerAIType type;

		[SerializeField]
		public ModeParam[] modeParams;

		[SerializeField]
		public DisableMoveParam disableMoveParam;

		[SerializeField]
		public float overrideChargeWaitTime;
	}

	public enum PlayerAIType
	{
		Normal,
		Burst_00,
		Mode_00,
		DisableMove_00
	}

	[Serializable]
	public class WalkingParam
	{
		[Serializable]
		public class BallLotteryTable
		{
			[SerializeField]
			public int prob_1;

			[SerializeField]
			public int prob_2;

			[SerializeField]
			public int prob_3;

			[SerializeField]
			public int prob_4;
		}

		[Serializable]
		public class ChangePartsData
		{
			[SerializeField]
			public int charaId;

			[SerializeField]
			public string partsName;

			[SerializeField]
			public RenderPartsData.PartsNo partsNo;
		}

		[SerializeField]
		public float cameraFocusTiming;

		[SerializeField]
		public float moveMargin;

		[SerializeField]
		public float moveMargin_back;

		[SerializeField]
		public float motionBlendSec_wait;

		[SerializeField]
		public float runTransitionSec;

		[SerializeField]
		public float giveUpCatchSec;

		[SerializeField]
		public float moveSpeed;

		[SerializeField]
		public float dashSpeedRatio;

		[SerializeField]
		public BallLotteryTable[] ballLotteryTables;

		[SerializeField]
		public int sleepSkillDataId;

		[SerializeField]
		public List<int> existsOnlyCharaOrDragonList;

		[SerializeField]
		public List<ChangePartsData> changePartsList;

		[SerializeField]
		public List<int> needsDragonTransformActionDragons;
	}

	[Serializable]
	public class DragonRelayParam
	{
		[SerializeField]
		public float beforeCharaChangeSec;

		[SerializeField]
		public float afterCharaChangeSec;
	}

	[Serializable]
	public class SwitchParam
	{
		[SerializeField]
		public bool disableClearMultiOldEventsBeforeInitializeEnemy;

		[SerializeField]
		public bool revertCheckBurstForCamera;

		[SerializeField]
		public bool auraEnableLevelDown;

		[SerializeField]
		public bool isEnemyModelTypeNormalOnCreate;

		[SerializeField]
		public bool isFollowerChargeTargetFixed;

		[SerializeField]
		public bool enableHideEffectsForSkillCutInCamera;

		[SerializeField]
		public bool disableCheckFollowerStateIdleMotion;

		[SerializeField]
		public bool disableDrainHitCharasBugFix;

		[SerializeField]
		public bool disableCheckCharacterAuraCtrlResetDirty;
	}

	[Serializable]
	public class CameraParam
	{
		[SerializeField]
		public List<int> continueCameraChangeInstantlyQuestIds;

		[SerializeField]
		public List<string> ignoreHideEffectsForSkillCutInCamera;

		[SerializeField]
		public List<int> ignoreHideEnemiesForSkillCutInCamera;

		[SerializeField]
		public bool disableSetDistanceForDragonCameraToSkillCamera;

		[SerializeField]
		public bool disableUseTargetDistanceForDragonBackupDistance;

		[SerializeField]
		public List<string> needsCheckLastKickTriggerEffectsForSkillCutInCamera;

		[SerializeField]
		public List<int> dontOverrideCameraNearFarQuestIds;
	}

	[Serializable]
	public class RaidParam
	{
		[SerializeField]
		public List<int> useNormalHitCheckQuestIds;

		[SerializeField]
		public List<int> useMyModelForOthersModelsQuestIds;

		[SerializeField]
		public List<int> cutsceneForceDisabledQuestIds;
	}

	[Serializable]
	public class BRParams
	{
		[SerializeField]
		public List<BattleRoyalDungeonItem> fixedDropItemsOnCharaDead;

		[SerializeField]
		public float dropWeaponItemsRatioOnCharaDead;

		[SerializeField]
		public int dpOnCharaDead;

		[SerializeField]
		public float botEscapeHpRatio;

		[SerializeField]
		public List<int> skillIdsDependsOnHiding;

		[SerializeField]
		public float hidingDamageRatio;

		[SerializeField]
		public int changeBgmCharaCount;

		[SerializeField]
		public float changeBgmElapsedSec;

		[SerializeField]
		public Color hidingColor;

		[SerializeField]
		public float tutorialDamageRatio;

		[SerializeField]
		public float tutorialBotStartSec;

		[SerializeField]
		public List<int> tutorialCantPosEnemyParamIds;

		[SerializeField]
		public DungeonManager.eStageDifficulty tutorialStageDifficulty;

		[SerializeField]
		public int tutorialStartIndex;

		[SerializeField]
		public float itemPopRadius;
	}

	[Serializable]
	public class BuffParams
	{
		[SerializeField]
		public List<int> partySwitchResetIds;

		[SerializeField]
		public List<float> burstDamageAttenuationRate;

		[SerializeField]
		public float applyVesselBombCoolTime;

		[SerializeField]
		public float countDownVesselBombCoolTime;

		[SerializeField]
		public float showVesselBombUITime;
	}

	[Serializable]
	public class CharaParams
	{
		[SerializeField]
		public float dragonTimeSpeedRateMin;

		[SerializeField]
		public float dragonTimeSpeedRateMax;
	}

	[Serializable]
	public class AnimatableObjectParam
	{
		[Serializable]
		public class AttachWeaponData
		{
			[SerializeField]
			public string prefabPath;

			[SerializeField]
			public string nodeName;
		}

		[Serializable]
		public class RootAttachObject
		{
			[SerializeField]
			public GameObject prefab;

			[SerializeField]
			public bool isOverrideTransform;

			[SerializeField]
			public Vector3 overridePos;

			[SerializeField]
			public Vector3 overrideRot;

			[SerializeField]
			public Vector3 overrideScale;
		}

		[SerializeField]
		public string name;

		[SerializeField]
		public string modelPath;

		[SerializeField]
		public string motionPath;

		[SerializeField]
		public bool enableLimit;

		[SerializeField]
		public int chacheCount;

		[SerializeField]
		public AttachWeaponData[] attachWeaponData;

		[SerializeField]
		public RootAttachObject[] rootAttachObjects;
	}

	[Serializable]
	public class DefenseQuestParam
	{
		[SerializeField]
		public List<int> openNextAreaGateWithoutFinalWaveClearQuestIds;
	}

	[Serializable]
	public class ScoringQuestParam
	{
		[SerializeField]
		public float enemyPopInvincibleSec;
	}

	[Serializable]
	public class DmodeParam
	{
		[Serializable]
		public class DamageRateData
		{
			[SerializeField]
			public int levelDiff;

			[SerializeField]
			public int rate;
		}

		[SerializeField]
		public int characterLevelMax;

		[SerializeField]
		public float recoverySpCoef;

		[SerializeField]
		public DamageRateData[] damageRateP2E;

		[SerializeField]
		public DamageRateData[] damageRateE2P;

		[SerializeField]
		public float skillDamageCoefForTheme;

		[SerializeField]
		public float skillRecoveryCoefForTheme;

		[SerializeField]
		public float dashSpeedUpWaitingSec;
	}

	[Serializable]
	public class CharaTalkParam
	{
		[SerializeField]
		public List<int> firstAreaOnlyForBossBattleQuestIds;
	}

	[Serializable]
	public class MultiParam
	{
		[SerializeField]
		public List<int> checkPopCountAtEnemyDeadEventForQuestIds;

		[SerializeField]
		public List<int> actionIdsForForceSyncCoordsOnChangeState;
	}

	[Serializable]
	public class QteParam
	{
		[SerializeField]
		public List<float> swipeAngles;

		[SerializeField]
		public float swipeDotThreshold;

		[SerializeField]
		public float swipeLength;
	}

	[Serializable]
	public class ExtraParam
	{
		[SerializeField]
		public float autoAreaChangeWaitSec;

		[SerializeField]
		public float autoAreaChangeWaitSecWithCameraSlow;

		[SerializeField]
		public List<int> deleteBulletOnAreaChangeSkillIds;

		[SerializeField]
		public List<int> deleteBulletOnAreaChangeActionIds;

		[SerializeField]
		public List<int> needsCheckComboRangeForAutoPlayCharaAndDragonIds;

		[SerializeField]
		public List<int> needsCheckNextComboRangeForAutoPlayCharaAndDragonIds;

		[SerializeField]
		public float autoAdditionalInputIntervalSec;

		[SerializeField]
		public List<int> hostOnlyEnemyToEnemyDamageAttackerEnemyDataIds;

		[SerializeField]
		public List<int> CharacterEffectAllStopOnDisableEnemyParamIds;

		[SerializeField]
		public List<int> needsSetVisibleWeaponForWinningProductionCharaIds;

		[SerializeField]
		public List<int> ignoreReferenceOtherForCheckSuccessAbilityIds;

		[SerializeField]
		public List<int> hideUIBeforeStoryBeginsForStoryIds;

		[SerializeField]
		public bool bugfix376559;

		[SerializeField]
		public int bugfix378873;

		[SerializeField]
		public bool bugfix378972;

		[SerializeField]
		public float bugfix379245;

		[SerializeField]
		public int bugfix379672;

		[SerializeField]
		public bool bugfix379859;

		[SerializeField]
		public List<int> unloadEnemyEffectsQuestIds;

		[SerializeField]
		public List<int> bugfix380567;

		[SerializeField]
		public bool bugfix381027;
	}

	public const string path = "Settings/InGameSettings";

	public RebornParams rebornParam;

	public UnitScaleParam[] unitScaleParams;

	public UnitScaleParam[] playerDragonEffectScaleParams;

	public PlayerAIParam[] playerAIParams;

	public WalkingParam walkingParam;

	public DragonRelayParam dragonRelayParam;

	public SwitchParam switches;

	public CameraParam cameraParam;

	public RaidParam raidParam;

	public BRParams brParams;

	public BuffParams buffParam;

	public CharaParams charaParam;

	public AnimatableObjectParam[] animatableObjectParams;

	public DefenseQuestParam defenseParam;

	public ScoringQuestParam scoringQuestParam;

	public DmodeParam dmodeParam;

	public CharaTalkParam charaTalkParam;

	public MultiParam multiParam;

	public QteParam qteParam;

	public ExtraParam extraParam;

	public AnimatableObjectParam GetAnimatableObjectParam(string name)
	{
		return null;
	}
}
