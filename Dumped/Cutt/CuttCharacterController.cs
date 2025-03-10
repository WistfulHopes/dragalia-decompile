using FLATOUT.Main;
using Gluon;
using Gluon.GraphicParameter;
using UnityEngine;
using UnityEngine.UI;

namespace Cutt;

public class CuttCharacterController : MonoBehaviour
{
	public static readonly float[] height;

	[HideInInspector]
	public CuttCharacterInitializeData initializeData;

	public const int animatorStateInfoMax = 5;

	private Animator animator;

	private AnimatorStateInfo[] info;

	private Transform rootTransform;

	private CuttCharacterFaceAnimation eye;

	private CuttCharacterFaceAnimation mouth;

	private GameObject shadow;

	private Vector3 shadowOffset;

	private Vector3 shadowScale;

	private CuttCharacterFaceData faceData;

	private MeshRenderer[] meshrenerers2D;

	private Image[] image;

	private Color color;

	private FlRoot flRoot;

	private float scaleFactor;

	private RectTransform canvasRect;

	private Camera flCamera;

	private RenderPartsData renderPartsData;

	public CuttCharacterInitializeData.PrefabType prefabType;

	public CuttCharacterFaceAnimation.ModelType modelType;

	private void Start()
	{
	}

	private void InitializeFlashData()
	{
	}

	public void InitializeCharacterData()
	{
	}

	private void InitializeUIData()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public void SetShadow(Vector3 offset, Vector2 shadowScale)
	{
	}

	public void UpdateShadowPosition()
	{
	}

	public void PlayMotion(int layerIndex, string stateName, float time)
	{
	}

	public void TriggerMotion(int layerIndex, string triggerName)
	{
	}

	public Vector3 GetMotionPosition()
	{
		return default(Vector3);
	}

	public float GetCurrentMotionLength(int layerIndex)
	{
		return default(float);
	}

	public void UpdateMotion(float deltaTime)
	{
	}

	public void SetExpressionHiModel(CuttTimelineControl control, CuttCharaEye expressionType, CuttCharacterFaceAnimation.Type animationType, int startFrame)
	{
	}

	public void SetExpressionHiModel(CuttTimelineControl control, CuttCharaMouth expressionType, CuttCharacterFaceAnimation.Type animationType, int startFrame)
	{
	}

	public void SetExpressionNormalModel(CuttTimelineControl control, CharaFaceEye type, CuttCharacterFaceAnimation.Type animationType, int startFrame)
	{
	}

	public void SetExpressionNormalModel(CuttTimelineControl control, CharaFaceMouth type, CuttCharacterFaceAnimation.Type animationType, int startFrame)
	{
	}

	public void AltherUpdate(int frame)
	{
	}

	public void SetFtuInitializeData(CuttFtuInitializeData data, string folderPath)
	{
	}

	public void SetEyeTextureOffset(int index)
	{
	}

	public void SetEyeTextureOffset(Vector2 offset)
	{
	}

	public void SetMouthTextureOffset(int index)
	{
	}

	public void SetMouthTextureOffset(Vector2 offset)
	{
	}
}
