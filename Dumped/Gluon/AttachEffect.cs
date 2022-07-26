using UnityEngine;

namespace Gluon;

public class AttachEffect : MonoBehaviour
{
	public enum PauseType
	{
		PLAY_SPEED,
		HIDE,
		IGNORE
	}

	public string _effectName;

	public Vector3 _offsetPos;

	public Vector3 _offsetRot;

	public Vector3 _scale;

	public EffectObject.FollowRotType _followRotType;

	public EffectObject.FollowScaleType _followScaleType;

	public EffectObject.EraseType _eraseType;

	public float _disappearTime;

	public bool _isRotateOnCharacter;

	public bool effectiveInPerfMode;

	public GameObject modelTransform;

	public int kickTrigger;

	public int matchingSubstituteEffectTrigger;

	public PauseType _pauseType;

	public bool isDisableInGameLowestQuality;

	private EffectObject _effectObject;

	private bool _needsSetup;

	private int _effectLayer;

	private GameObject _goAttachTarget;

	private Transform _characterTransform;

	private bool _isVisible;

	private int defaultKickTrigger;

	[SerializeField]
	private bool isInGameOnly;

	public int effectLayer
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public bool IsInGameOnly()
	{
		return default(bool);
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private Quaternion CalcEffectRotate()
	{
		return default(Quaternion);
	}

	private void SetupEffect()
	{
	}

	private void StopEffect()
	{
	}

	private void UpdateAttachTarget()
	{
	}

	public void SetVisible(bool isVisible)
	{
	}

	public void SetPause(bool isPause)
	{
	}

	public void SetPauseForTimeStop(bool isPause)
	{
	}

	public bool KickTrigger(int trig)
	{
		return default(bool);
	}

	public void ResetTriger()
	{
	}

	public void RequestSetup()
	{
	}
}
