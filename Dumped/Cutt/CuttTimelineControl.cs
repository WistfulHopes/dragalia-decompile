using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

namespace Cutt;

public class CuttTimelineControl : MonoBehaviour
{
	public class CameraData
	{
		public CameraGroup[] mainCameraGroup;
	}

	public CuttTimelineData data;

	private bool isDataLoaded;

	private int _targetFps;

	public string story3DCameraName;

	public string story3DImageEffectName;

	public Transform cameraPositionLocatorsRoot;

	public Transform cameraLookAtLocatorsRoot;

	public Transform[] characterStandPosLocators;

	public string cameraAnimationControllerName;

	public float cameraNear;

	public float cameraFar;

	public bool orthographic;

	public List<string> soundFileList;

	private bool _isNowAlterUpdate;

	private float _currentTime;

	private float _oldTime;

	private int _currentFrame;

	private int _oldFrame;

	private float _deltaTime;

	private float _deltaTimeRatio;

	private readonly float kCameraDelayRate;

	private bool _isEnablePostEffect;

	private int waitEventFrame;

	private int pauseFrame;

	private int lastCuttEventFrame;

	private bool isTapWait;

	private bool requestingSkipFlag;

	private int ignoreSkipEventFrame;

	private Vector3 _cameraLayerOffset;

	private static readonly float kCameraLayerOffsetMinCharaHeight;

	private static readonly float kCameraLayerOffsetMaxCharaHeight;

	private static readonly float kCameraLayerOffsetBaseDiff;

	public Vector3 generalOffset;

	private CameraData[] _cameraDataArray;

	private Animator[] cameraAnimatorArray;

	private bool isPlayingCameraAnimator;

	private CuttTimelineCamera[] _cameraScriptArray;

	private MainCameraCtrl mainCameraCtrl;

	private Dictionary<string, Transform> _cameraPositionLocatorDict;

	private Dictionary<string, Transform> _cameraLookAtLocatorDict;

	private ICuttTimelineCharactorLocator[] _cuttCharactorLocators;

	private static int _cuttCharaPositionMax;

	public static readonly int cuttSceneObjectTimelineMax;

	public static readonly int cuttMaterialTimelineMax;

	public static readonly int cuttEffectTimelineMax;

	public static readonly int cuttSoundTimelineMax;

	public static readonly int cuttFlashTimelineMax;

	public static readonly int cuttCharacterTimelineMax;

	private CuttTimelineEventPublisher _eventPublisher;

	private CuttTimelineFade _fade;

	private CuttTimelinePostEffect _postEffectParam;

	private CuttTimelineSunShafts _sunShaftsParam;

	private CuttTimelineBloom _bloomParam;

	private CuttTimelineDofCtrl _dofCtrlParam;

	private CuttTimelineColorAdjustment _colorAdjustmentParam;

	private CuttTimelinePostFilm _postFilmParam;

	private CuttTimelineImageEffect _imageEffectParam;

	private CuttTimelineFog _fogParam;

	private CuttTimelineRichShader _richShaderParam;

	private CuttTimelineMotionSequence[] _motionSequenceArray;

	private CuttTimelineSceneObject[] _sceneObjectArray;

	private CuttTimelineMaterial[] _materialArray;

	private CuttTimelineEffect[] _effectArray;

	private CuttTimelineSoundFilter _soundFilterParam;

	private CuttTimelineSound[] _soundArray;

	private CuttTimelineFlash[] _flashArray;

	private CuttTimelineCharacter[] _characterArray;

	private CuttTimelineGraphicSpeed _graphicSpeed;

	private Animator ingameCuttDataAnimator;

	private RuntimeAnimatorController ingameCuttDataRuntimeAnimCtrl;

	private int _sceneObjectIndex;

	private int _materialIndex;

	private int _effectIndex;

	private int _flashIndex;

	private CuttTimelinePostFilm postfilmLog;

	private static readonly float graphicTimeScaleDefault;

	private float graphicTimeScaleNow;

	private string[] characterLabels;

	private int lastTriggeredEventFrame;

	public int targetFps
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public Vector3 cameraLayerOffset => default(Vector3);

	private static bool availableFindKeyCache => default(bool);

	public float currentTime
	{
		get
		{
			return default(float);
		}
		private set
		{
		}
	}

	public bool isEnablePostEffect
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public CameraData[] cameraDataArray
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	private CuttTimelineCamera[] cameraScriptArray => null;

	private Dictionary<string, Transform> cameraPositionLocatorDict => null;

	private Dictionary<string, Transform> cameraLookAtLocatorDict => null;

	public ICuttTimelineCharactorLocator[] cuttCharactorLocators => null;

	public static int cuttCharaPositionMax => default(int);

	public CuttTimelineEventPublisher eventPublisher => null;

	public event Action OnPreUpdateAllTimeline
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnPostUpdateAllTimeline
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<int> OnUpdateCameraSwitcher
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Color> OnUpdateFloorColor
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public bool IsBeforeFrameJump()
	{
		return default(bool);
	}

	public void SetReplayParam(int resetFrame)
	{
	}

	public CameraGroup[] GetCameraGroup(int index)
	{
		return null;
	}

	public CameraGroupCtrl GetActiveCameraGroupCtrl()
	{
		return null;
	}

	public CuttTimelineCamera GetCameraScript(int index)
	{
		return null;
	}

	public Vector3 GetCameraPos(int index)
	{
		return default(Vector3);
	}

	public Transform FindPositionLocator(string name)
	{
		return null;
	}

	public Transform FindLookAtLocator(string name)
	{
		return null;
	}

	public void SetCharactorLocator(CuttCharaPosition position, ICuttTimelineCharactorLocator locator)
	{
	}

	private PostEffect GetPostEffect(Camera cam)
	{
		return null;
	}

	public void SetTimelineCamera(CameraGroup[] cam, int index, bool loadAnimFlag)
	{
	}

	public void SetMainCameraGroupParam()
	{
	}

	public void SetIngameCuttCameraAnim()
	{
	}

	public void InitCharaMotionSequence(CuttCharaPosition position)
	{
	}

	public void InitGraphicSpeed()
	{
	}

	public void InitFade(GameObject canvasObject)
	{
	}

	public void InitPostEffect()
	{
	}

	public void InitSunShafts()
	{
	}

	public void InitBloom()
	{
	}

	public void InitDofCtrl()
	{
	}

	public void InitColorAdjustment()
	{
	}

	public void InitPostFilm()
	{
	}

	public void InitImageEffect()
	{
	}

	public void InitFog()
	{
	}

	public void InitRichShader()
	{
	}

	public void InitSoundFilter()
	{
	}

	private void CheckIndices(int[] indices)
	{
	}

	public void InitSceneObject()
	{
	}

	public void AddSceneObjectLine()
	{
	}

	public void InitMaterial()
	{
	}

	public void AddMaterialLine()
	{
	}

	public void InitEffect()
	{
	}

	public void AddEffectLine()
	{
	}

	public void InitSound()
	{
	}

	public void InitFlash(CuttFlashInitializer flashInitializer)
	{
	}

	public void AddFlashLine(CuttFlashInitializer flashInitializer)
	{
	}

	public void InitCamera()
	{
	}

	public void SetIngameCutt(bool startFlag)
	{
	}

	public float GetGraphicTimeScale()
	{
		return default(float);
	}

	public void SetGraphicTimeScale(float timeScale)
	{
	}

	private void SetPostFilm(bool startFlag)
	{
	}

	private PostEffect GetHeadPostEffect()
	{
		return null;
	}

	public void InitCharacter(CuttCharacterInitializer initializer)
	{
	}

	public void ResetCharacterIndexAndAnimator()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Initialize()
	{
	}

	private void Terminate()
	{
	}

	public void SetFadePanel(bool enableFlag)
	{
	}

	public bool GetTapWait()
	{
		return default(bool);
	}

	private void SetWaitEvent(int frame)
	{
	}

	public float GetWaitEventTime()
	{
		return default(float);
	}

	public void ResetWaitEvent()
	{
	}

	private void PauseTimeline(int pauseFrame)
	{
	}

	public bool IsRequestingSkip()
	{
		return default(bool);
	}

	public void SetSkipFlag()
	{
	}

	public void ResetPause()
	{
	}

	public float GetPauseTime()
	{
		return default(float);
	}

	public bool IsPause()
	{
		return default(bool);
	}

	public void ResetCommandData()
	{
	}

	private void SetCommandData(int frame, CuttCommandDirection.CommandData tempData)
	{
	}

	public CuttCommandDirection.CommandData GetCurrentCommandData()
	{
		return null;
	}

	public bool IsPlayingCommandData()
	{
		return default(bool);
	}

	public CuttTimelineData LoadData()
	{
		return null;
	}

	private void UnloadData()
	{
	}

	public AnimationClip LoadAnimationClip(CuttTimelineKeyCharaMotionData key)
	{
		return null;
	}

	public string GetAnimationClipLoadDir()
	{
		return null;
	}

	public void AlterUpdate(float time)
	{
	}

	public void AlterLateUpdate()
	{
	}

	public static float LerpWithoutClamp(float a, float b, float t)
	{
		return default(float);
	}

	public static Vector2 LerpWithoutClamp(Vector2 a, Vector2 b, float t)
	{
		return default(Vector2);
	}

	public static Vector3 LerpWithoutClamp(Vector3 a, Vector3 b, float t)
	{
		return default(Vector3);
	}

	public static Vector4 LerpWithoutClamp(Vector4 a, Vector4 b, float t)
	{
		return default(Vector4);
	}

	public static Color LerpWithoutClamp(Color a, Color b, float t)
	{
		return default(Color);
	}

	public static void FindTimelineKey(out CuttTimelineKey curKey, out CuttTimelineKey nextKey, ICuttTimelineKeyDataList keys, int curFrame)
	{
	}

	public static void FindTimelineKeyCurrent(out CuttTimelineKey curKey, ICuttTimelineKeyDataList keys, int curFrame)
	{
	}

	public static void FindTimelineKeyTrigger(out CuttTimelineKey triggeredKey, ICuttTimelineKeyDataList keys, int curFrame, int oldFrame)
	{
	}

	public static void FindTimelineKeyPrevious(out CuttTimelineKey previousKey, ICuttTimelineKeyDataList keys, int curFrame)
	{
	}

	public static void FindTimelineKeyNext(out CuttTimelineKey nextKey, ICuttTimelineKeyDataList keys, int curFrame)
	{
	}

	private static float LinearInterpolateKeyframes(CuttTimelineKey from, CuttTimelineKey to, float curFrame)
	{
		return default(float);
	}

	private static float CurveInterpolateKeyframes(CuttTimelineKey from, CuttTimelineKey to, float curFrame)
	{
		return default(float);
	}

	private static float EaseInterpolateKeyframes(CuttTimelineKey from, CuttTimelineKey to, float curFrame)
	{
		return default(float);
	}

	public CuttTimelineCharacter GetCuttTimelineCharacter(CuttCharacterInitializer.CharacterId charaId)
	{
		return null;
	}

	public string[] GetCuttTimelineCharacterLabels()
	{
		return null;
	}

	public Vector3 GetPositionWithCharacters(CuttCharaPositionFlag posFlags, CuttCameraLookAtCharaParts parts)
	{
		return default(Vector3);
	}

	public static float CalculateInterpolationValue(CuttTimelineKey curKey, CuttTimelineKeyWithInterpolate nextKey, int frame)
	{
		return default(float);
	}

	private void AlterUpdate_CameraPos(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	public bool CalculateCameraPos(out Vector3 pos, CuttTimelineWorkSheet sheet, int currentFrame)
	{
		return default(bool);
	}

	private void AlterUpdate_CameraLookAt(CuttTimelineWorkSheet sheet, int currentFrame, ref Vector3 outLookAt)
	{
	}

	public bool CalculateCameraLookAt(out Vector3 lookAtPos, CuttTimelineWorkSheet sheet, int currentFrame)
	{
		return default(bool);
	}

	private void AlterUpdate_CameraFov(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_CameraRoll(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_HandShake(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_CharaMotionSequence(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_CuttEvent(CuttTimelineWorkSheet sheet, int currentFrame, int oldFrame)
	{
	}

	public float GetNextCuttEventTime(float time)
	{
		return default(float);
	}

	private void AlterUpdate_GraphicSpeed(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_Fade(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_PostEffect(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_PostSunShafts(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_Bloom(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_DofTarget(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_ColorAdjustment(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_PostFilm(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_ImageEffect(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_Fog(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_RichShader(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_SceneObject(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_Material(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_Effect(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_SoundFilter(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_Sound(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	public void StopSound()
	{
	}

	public void ExitFog()
	{
	}

	public void ExitSound()
	{
	}

	public void ExitEffect()
	{
	}

	private void AlterUpdate_Flash(CuttTimelineWorkSheet sheet, int currentFrame, int oldFrame)
	{
	}

	private void AlterUpdate_Character(CuttTimelineWorkSheet sheet, int currentFrame, int oldFrame)
	{
	}

	private void AlterUpdate_CharacterBillboard(Quaternion camRot)
	{
	}

	private void AlterLateUpdate_Character(CuttTimelineWorkSheet sheet, int currentFrame, int oldFrame)
	{
	}

	private void AlterUpdate_Event(CuttTimelineWorkSheet sheet, int currentFrame, int oldFrame)
	{
	}

	public void ResetCameraAnimator(int currentFrame)
	{
	}

	private void AlterUpdate_CameraSwitcher(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}

	private void AlterUpdate_CameraLayer(CuttTimelineWorkSheet sheet, int currentFrame, ref Vector3 layerOffset)
	{
	}

	private void AlterUpdate_FloorColor(CuttTimelineWorkSheet sheet, int currentFrame)
	{
	}
}
