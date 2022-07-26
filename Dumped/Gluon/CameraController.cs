using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon;

public class CameraController : MonoBehaviour
{
	[Serializable]
	public class FollowCameraData
	{
		public float distance;

		public float minDistance;

		public float maxDistance;

		public Vector3 rotate;

		public float battleBaseSpeed;

		public float dashBaseSpeed;

		public float dashFrontLength;

		public float frontLengthVerticalRatio;

		public float dashZoomOutLength;

		public float dashZoomOutTime;

		public float longRangeAttackZoomOutLength;

		public float longRangeAttackZoomOutTime;

		public float longRangeAttackZoomKeepTime;

		public float longRangeAttackFrontOffset;

		public float longRangeAttackFrontInBaseSpeed;

		public float longRangeAttackFrontOutBaseSpeed;

		public float moveSpeedCoefOnZoomKeepTime;

		public float fov;

		public float rotateLimitY;

		public float lookAtOffsetDistance;
	}

	[Serializable]
	public enum ShakeType
	{
		shakeR_xs_00,
		shakeR_s_01,
		shakeR_m_02,
		shakeR_l_03,
		shakeR_xl_04,
		shakeV_xs_05,
		shakeV_s_06,
		shakeV_m_07,
		shakeV_l_08,
		shakeV_xl_09,
		shakeS_xs_10,
		shakeS_s_11,
		shakeS_m_12,
		shakeS_l_13,
		shakeS_xl_14,
		shakeZodiarc_Roar,
		shakeR_4xl_16,
		shakeDragon_Trans,
		shakeR_dr_ss_18,
		shakeR_dr_sw_19,
		shakeR_dr_ms_20,
		shakeR_dr_mw_21,
		shakeR_dr_ls_22,
		shakeR_dr_lw_23,
		shakeHard_Hit,
		shakeHitS,
		shakeHitM,
		shakeHitL,
		MAX
	}

	public enum ShakePriority
	{
		Default,
		ActionParts01,
		ActionParts02,
		ActionParts03,
		ActionParts04,
		ActionParts05,
		HitAttack,
		HitAttack01,
		HitAttack02,
		HitAttack03
	}

	public enum MODE
	{
		ANIMATION,
		CUTSCENE,
		FOLLOW,
		DRAGON,
		FINISH,
		SKILL,
		GATE,
		EXTRAACTION,
		BATTLESTART,
		TARGETPOSITION,
		CUTT,
		VIEWER,
		CMNSKILL_CHECKER
	}

	public const string InGameCameraName = "Animations/InGame/Camera";

	private FollowCameraData[] _followCameraData;

	private GameObject goFollowCameraDataContainer;

	private CameraType camType;

	private Animator animator;

	private MODE mode;

	private uint updateCount;

	private uint updateCountPlay;

	public Transform target;

	[SerializeField]
	public float distance;

	[SerializeField]
	public Vector3 rotate;

	public Vector3 targetRotate;

	private Vector3 rotateAnimationStart;

	private float rotateLerpTime;

	private float rotateTime;

	[NonSerialized]
	public float lastFollowDistance;

	private Vector3 _targetPosition;

	[NonSerialized]
	public Vector3 atPosition;

	[NonSerialized]
	public bool initializeCameraPos;

	[NonSerialized]
	public float targetDistance;

	private float lastDistanceOnFollow;

	[SerializeField]
	private float collisionRadius;

	[SerializeField]
	private Vector3 collisionCenterPos;

	private CameraShakeData[] shakeData;

	private GameObject goCameraShakeDataContainer;

	public CameraModeFollow modeFollow;

	public CameraModeTargetPosition modeTargetPosition;

	private bool isChangeTarget;

	private int targetPartyIndex;

	private int targetMemberIndex;

	private bool enableConvertFovToMatchWidth;

	public Func<bool> canUpdateTransformFunc;

	public Func<float> getFollowRateFunc;

	private RuntimeAnimatorController ingameCuttAnimLoad;

	private RuntimeAnimatorController ingameCuttAnimLog;

	private float defaultNearClipPlane;

	private float defaultFarClipPlane;

	private float dragonBackupDistance;

	private int cameraStep;

	private float cameraTime;

	[SerializeField]
	private float dragonZoomInWaitTime;

	[SerializeField]
	private float dragonStartDistance;

	[SerializeField]
	private float dragonStartWaitTime;

	[SerializeField]
	private float dragonDefaultDistance;

	[SerializeField]
	private float dragonZoomInSpeed;

	[SerializeField]
	private float dragonZoomInAcceleration;

	[SerializeField]
	private float dragonZoomInMaxSpeed;

	[SerializeField]
	private float dragonZoomInMinSpeed;

	[SerializeField]
	private float dragonZoomOutSpeed;

	[SerializeField]
	private float dragonZoomOutAcceleration;

	[SerializeField]
	private float dragonZoomOutMaxSpeed;

	[SerializeField]
	private float dragonZoomOutMinSpeed;

	[SerializeField]
	private float fogDistanceOffset;

	private float cameraSpeed;

	[SerializeField]
	private float finishStartTime;

	[SerializeField]
	private float finishWaitTime;

	private Vector3 finishStartPos;

	[SerializeField]
	private float finishZoomInSpeed;

	[SerializeField]
	private float finishZoomInAcceleration;

	[SerializeField]
	private float finishZoomInMaxSpeed;

	[SerializeField]
	private float finishZoomInMinSpeed;

	private float finishDistance;

	private bool _finishEnd;

	[SerializeField]
	private float skillWaitTime;

	private Vector3 skillStartPos;

	[SerializeField]
	private float skillZoomInSpeed;

	[SerializeField]
	private float skillZoomInAcceleration;

	[SerializeField]
	private float skillZoomInMaxSpeed;

	[SerializeField]
	private float skillZoomInMinSpeed;

	[SerializeField]
	private float skillZoomInRotateTime;

	[SerializeField]
	private float skillZoomOutSpeed;

	[SerializeField]
	private float skillZoomOutAcceleration;

	[SerializeField]
	private float skillZoomOutMaxSpeed;

	[SerializeField]
	private float skillZoomOutMinSpeed;

	[SerializeField]
	private float skillZoomOutRotateTime;

	private float zoomInValue;

	[SerializeField]
	public Vector3 skillRotate;

	private SkillDataElement skillDataElement;

	private bool isSupportSkill;

	private bool initSkillTargetPosition;

	private bool enableSkillTargetPosition;

	private Vector3 skillTargetPosition;

	private CameraShakeData currentShakeData;

	private bool shakeActive;

	private float shakeTime;

	private Vector2 shakeRand;

	private AnimationCurve dampingCoef;

	private const float ShakeDistance = 400f;

	public FollowCameraData[] followCameraData => null;

	public CameraType CamType => default(CameraType);

	public CameraGroupCtrl cameraGroupCtrl
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public CameraGroup mainCmeraGroup
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public CameraGroup silhouetteCameraGroup
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public MODE Mode => default(MODE);

	public Vector3 defaultRotate
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float pinchFollowDistance
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Vector3 targetPosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public CameraModeExtraAction modeExtraAction
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool EnableConvertFovToMatchWidth
	{
		private get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool finishEnd => default(bool);

	public GameObject finishFocusObject
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Vector3 gatePos
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void SetCameraGroupCtrl(CameraGroupCtrl cg)
	{
	}

	public void SetCameraField(float fieldOfView, float nearClipPlane, float farClipPlane)
	{
	}

	public void SetCameraFieldOfView(float fieldOfView)
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void LoadCutScene(string path, bool preLoadFlag = false)
	{
	}

	public void SetAnimatorController(bool start)
	{
	}

	public void PlayCut(string cutName, float startTime = 0f)
	{
	}

	public void SetBossCameraType(BossCamera type)
	{
	}

	public void SetFollowCameraData(CameraType type)
	{
	}

	public void LoadAnimationController(string controllerName)
	{
	}

	public void SkipAnimation([Optional] string stateName, float normalizedTime = 1f)
	{
	}

	public void SetAnimationSpeed(float speed)
	{
	}

	public void SetDefaultFollow()
	{
	}

	public void SetDefaultNearFar()
	{
	}

	private void SetCameraMode(MODE camMode, bool clear)
	{
	}

	public void SetMode(MODE camMode, bool clear = true)
	{
	}

	public bool SetExtraAction(CameraModeExtraAction.StyleType style, GameObject target, float dist, Vector3 rot, float time, float interpolationTime)
	{
		return default(bool);
	}

	public void SetExtraAction(CameraModeExtraAction.StyleType style, GameObject target, float time)
	{
	}

	public void FinishExtraAction(bool isSkillCutInCamera)
	{
	}

	public MODE GetMode()
	{
		return default(MODE);
	}

	public Vector3 GetLastTargetPosition()
	{
		return default(Vector3);
	}

	public void CheckNeedToStepIn()
	{
	}

	public void SetPosition(Vector3 pos)
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	public void SetRotation(Quaternion rot)
	{
	}

	public Transform GetTransform()
	{
		return null;
	}

	public Vector3 GetDefaultRotation()
	{
		return default(Vector3);
	}

	public Quaternion GetRotation()
	{
		return default(Quaternion);
	}

	public float GetBossCameraMinRotX()
	{
		return default(float);
	}

	public float GetBossCameraMaxRotX()
	{
		return default(float);
	}

	public void Play(string animName)
	{
	}

	private float GetFieldOfView()
	{
		return default(float);
	}

	public bool IsPlaying()
	{
		return default(bool);
	}

	public float PlayingLength()
	{
		return default(float);
	}

	public void InitailizeCameraPosition()
	{
	}

	public void ResetCameraPosition()
	{
	}

	public Vector3 GetPlayerPosition(bool useSkillStart = false)
	{
		return default(Vector3);
	}

	public CharacterBase GetChangeTargetChara()
	{
		return null;
	}

	public Vector3 GetPlayerDirection(bool useSkillStart = false)
	{
		return default(Vector3);
	}

	public void SetTargetRotate(Vector3 rot, float time)
	{
	}

	public void UpdateRotateAnimation()
	{
	}

	public void SetLookAt(float dist, Vector3 addVector)
	{
	}

	public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
	{
	}

	public void SetCameraCollision(Vector3 pos, float radius)
	{
	}

	public void UpdateFollow()
	{
	}

	public static float CalcZoomSpeed(float spd, float acc, float min, float max)
	{
		return default(float);
	}

	private void UpdateChangeDragon()
	{
	}

	private void UpdateFinish()
	{
	}

	public void SetSkillCamera(SkillDataElement element, bool isSupport)
	{
	}

	private Vector3 GetSkillTargetPosition()
	{
		return default(Vector3);
	}

	private Vector3 GetPlayerForwardPosition(float distance, bool useSkillStart = false)
	{
		return default(Vector3);
	}

	private void UpdateSkill()
	{
	}

	private void UpdateGate()
	{
	}

	private void LateUpdate()
	{
	}

	public bool IsFollowing()
	{
		return default(bool);
	}

	public void SetShake(ShakeType type, ShakePriority prio = ShakePriority.Default, bool needsCheckMode = true)
	{
	}

	public void SetShakeDampingCoef(AnimationCurve animCurve)
	{
	}

	public void SetShake(ShakeType type, Vector3 pos)
	{
	}

	public void SetShake(float duration, float power)
	{
	}

	public Vector3 UpdateShake()
	{
		return default(Vector3);
	}

	public float GetDistance()
	{
		return default(float);
	}

	public void ReloadCameraShakeData()
	{
	}

	public void ReloadFollowCameraData()
	{
	}

	public void SetTargetId(int partyIndex, int memberIndex)
	{
	}

	public void ResetTarget()
	{
	}

	public void CheckWall(Vector3 prevPos)
	{
	}

	public bool IsSkillCutInCameraHiddenEffectsEmpty()
	{
		return default(bool);
	}

	public bool IsPlayingSkillCutInCamera()
	{
		return default(bool);
	}
}
