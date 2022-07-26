using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class FortAreaExtensionController : MonoBehaviour
{
	public enum FinishFlashAnimType
	{
		AreaExtension,
		Complete
	}

	[SerializeField]
	private float step1WaitTime;

	[SerializeField]
	private float step1BackMoveDistance;

	[SerializeField]
	private float step1BackMoveDuration;

	[SerializeField]
	private Ease step1Easing;

	[SerializeField]
	private float[] mainFacilityLvUpMoveSpeeds;

	private const float defaultSpeed = 30f;

	[SerializeField]
	private Ease step2Easing;

	[SerializeField]
	private Vector3[] smithPosDiff;

	[SerializeField]
	private float step3WorkingWait;

	[SerializeField]
	private float step3VanishingWait;

	[SerializeField]
	private float step3ExtensionWait;

	[SerializeField]
	private float step3FadeOutDuration;

	[SerializeField]
	private float step4FadeOutKeepWait;

	[SerializeField]
	private float step4FadeInDuration;

	private Sequence sequence;

	private GameObject[] dragonSmithObjs;

	private bool isFadingOut;

	private readonly float areaExtensionEffectAdjustY;

	private readonly float completeEffectAdjustY;

	public void OnFinishedMainFacilityFocusAnim(FacilityViewController facilityViewController)
	{
	}

	public void PlayDragonSmithTrioBuildAnimation(Vector3 newAreaPos, Transform cameraCtrlTransform, FacilityViewController facilityViewController, FinishFlashAnimType type = FinishFlashAnimType.AreaExtension)
	{
	}

	public void OnFinishSmishRemoveTrigger()
	{
	}

	public void OnFinishSmishAnim(FacilityViewController facilityViewController, Vector3 areaGroundPos, FinishFlashAnimType type)
	{
	}

	private void SetEffectOrder(EffectObject eo)
	{
	}

	public void QuitAreaExtensionAnimation()
	{
	}
}
