using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon;

public class FortCameraController : FastUpdateMonoBehaviour, FortCameraEventInterface, IEventSystemHandler
{
	public enum CameraState
	{
		None,
		Static,
		Dragging,
		AfterDragging,
		Zooming,
		AfterZooming,
		Cropping
	}

	[Serializable]
	private struct DistanceBlurSetting
	{
		public float distStart;

		public float distEnd;

		public float blurAreaStart;

		public float blurAreaEnd;
	}

	[Serializable]
	private struct PointIrisSetting
	{
		public Transform[] targets;

		public int[] maxLevels;

		public float[] widths;

		public float[] heights;
	}

	private const float FOCUS_ANIM_DURATION = 0.5f;

	private const float FOCUS_ANIM_ZOOM_FORWARD_VALUE = 10f;

	private const float FOCUS_ANIM_WAIT_TIME = 1f;

	private float oldDeltaDis;

	[SerializeField]
	public Vector2 viewLeftBottomPosMinDistance;

	[SerializeField]
	public Vector2 viewRightUpPosMinDistance;

	[SerializeField]
	public Vector2 viewLeftBottomPosMaxDistance;

	[SerializeField]
	public Vector2 viewRightUpPosMaxDistance;

	private Vector2 curViewLeftBottomPos;

	private Vector2 curViewRightUpPos;

	private Tweener moveIn;

	private Tweener targetIn;

	[SerializeField]
	private Transform target;

	private Vector3 focusTargetPos;

	[SerializeField]
	public Vector2 distanceRange;

	public float distance;

	public float focusDistance;

	private Vector3 originalPos;

	private Vector3 touchDownPos;

	[SerializeField]
	public Vector3[] cameraPosAfterSceneIn;

	[SerializeField]
	public float distanceCameraFall;

	[SerializeField]
	public Vector2 distanceBeforeSceneInAnimation;

	[SerializeField]
	public Vector2 sceneInDuration;

	[SerializeField]
	private float sceneInShowDragonDelay;

	[SerializeField]
	public Vector3 cameraRotationAfterSceneIn;

	private GameObject currentFocusAnimTarget;

	[SerializeField]
	public float dragFollowSpeed;

	[SerializeField]
	public float zoomFollowSpeed;

	public float mouseScrollWheelSpeed;

	private bool _canTouch;

	[SerializeField]
	public float maxDeltaY;

	[SerializeField]
	private float scrollBackDuration;

	private SmoothMove smoothMove;

	[SerializeField]
	private float outRangeDistance;

	private const float zoomThresholdValueMax = 400f;

	private StandaloneInputModuleCustom inputModule;

	private Sequence sequence;

	private Plane plane;

	private float distToPlane;

	private Ray rayToPlane;

	private FortAreaExtensionController _areaExtensionController;

	private bool isStartToDrag;

	[SerializeField]
	private GameObject fogTarget;

	[SerializeField]
	private float easingFogChangeModulus;

	[SerializeField]
	private float minFog;

	[SerializeField]
	private Color fogColor;

	[SerializeField]
	private float fogStartDistance;

	[SerializeField]
	private float fogEndDistance;

	[SerializeField]
	private Color bgFadeColor;

	[SerializeField]
	private DistanceBlurSetting[] distanceBlurSettings;

	[SerializeField]
	private float xzDistModulus;

	[SerializeField]
	private PointIrisSetting[] castlePointIrisSettings;

	[SerializeField]
	private PointIrisSetting[] dragonStagePointIrisSettings;

	private PostEffect fortPostEffect;

	private Vector3 pivot;

	private Transform cachedTransform;

	private bool isReflectTiltSettings;

	private List<RaycastResult> raycastResultCache;

	private PointerEventData pointerData;

	public CameraState cameraState
	{
		[CompilerGenerated]
		get
		{
			return default(CameraState);
		}
		[CompilerGenerated]
		private set
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

	public bool isSelectedUI
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool isSelectedFacility
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool isProdctFaciliy
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool isPullMenuButtonPressed
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public FortScene fortScene
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

	public bool canTouch
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool autoFollow
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Vector3 originalDirTargetToCamera
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float zoomThresholdValue
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

	public float dragThresholdValue
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

	private Vector3 previousScreenPos
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

	public FortAreaExtensionController areaExtensionController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void OnInit(FortScene scene)
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void UpdateCamera()
	{
	}

	public void RunSceneInAnimation()
	{
	}

	public void CameraInAnimationStart()
	{
	}

	private IEnumerator ShowTutorialSceneInDragon()
	{
		return null;
	}

	public void OnSceneInFinished()
	{
	}

	private void Drag()
	{
	}

	private bool IsSelectFacilityCanceled()
	{
		return default(bool);
	}

	private void UpdateDragBegin()
	{
	}

	public bool GetTouchDownPos(Vector3 screenPos, out Vector3 pos)
	{
		return default(bool);
	}

	private void UpdateDragging()
	{
	}

	private void UpdateDragEnd()
	{
	}

	private void UpdateTouchUp()
	{
	}

	private void Pinch(OutGameTouchManager.PinchState pinchState)
	{
	}

	private void PinchForDevice(OutGameTouchManager.PinchState pinchState)
	{
	}

	private void UpdateTiltShiftSetting()
	{
	}

	private void RefrectPointIrisSetting(PointIrisSetting[] settings, int startIndex = 0)
	{
	}

	private void Zoom(float deltaDistance)
	{
	}

	private void UpdateAfterZooming()
	{
	}

	private void RefreshDistToPlane()
	{
	}

	private void ZoomCamera(float deltaDistance)
	{
	}

	private bool IsZooming()
	{
		return default(bool);
	}

	public void MoveToTargetPos(GameObject focusTarget, float duration, [Optional] Action onCompleted, bool isEnableDragOnComplete = true)
	{
	}

	void FortCameraEventInterface.OnFacilityBuildFnishedAnimStart(GameObject focusTarget, Facility.eFacilityStatus status)
	{
	}

	public void OnFinishedBuild(GameObject focusTarget, Facility.eFacilityStatus status)
	{
	}

	private void OnFinishCompleteBuildAnimation(GameObject facilityObj, bool playSlideIn)
	{
	}

	private void ShowTutorialWindow()
	{
	}

	void FortCameraEventInterface.OnMainFacilityLevelUpFnishedAnimStart(GameObject focusTarget, FacilityViewController facilityViewController)
	{
	}

	public void OnFinishedMainFacilityFocusReverseAnim()
	{
	}

	private void UpdateCameraPosition(Vector3 aimPos)
	{
	}

	public Vector3 SetTargetPosition(Vector3 position)
	{
		return default(Vector3);
	}

	public Vector3 CalculateCameraTargetPos(Vector3 targetPos, float distanceFromTargetToCamera)
	{
		return default(Vector3);
	}

	private Vector3 CalculateCameraFocusPoint(Vector3 cameraPos)
	{
		return default(Vector3);
	}

	public Vector3 CalculateCameraTargetPos()
	{
		return default(Vector3);
	}

	public bool IsSelectedFacility()
	{
		return default(bool);
	}

	public bool IsSelectedProcutFacility()
	{
		return default(bool);
	}

	public bool IsSelectedUI()
	{
		return default(bool);
	}

	private void RefreshViewRect()
	{
	}

	private float CalculateViewRectValue(float factor, float valueMinDistance, float valueMaxDistance)
	{
		return default(float);
	}

	private float GetDistanceFromFogTarget()
	{
		return default(float);
	}

	private void ApplyBgFade()
	{
	}

	private void Tutorial_2_6_2()
	{
	}

	private IEnumerator Tutorial_2_6_2_Coroutine()
	{
		return null;
	}

	public float AcquireMagnification()
	{
		return default(float);
	}
}
