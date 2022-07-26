using UnityEngine;

namespace SPFX;

public class SPFXCameraOnRenderImageFx : MonoBehaviour
{
	public enum MaterialPassName
	{
		DepthTexture,
		MainTextureBase,
		MainTextureSideY
	}

	private Camera RefCamera;

	private bool RequiredBillboardCamera;

	public Light TargetLight;

	public float SceneLightScale;

	public float SceneAmbientScale;

	public eDrawLayer[] DrawLayersBefore;

	public eDrawLayer[] DrawLayersAfter;

	public bool BillboardCamera;

	public eDebugInfoType DebugInfoType;

	private Shader CopyShader;

	public Material CopyMaterial;

	private int _DepthPass;

	private int _ColorPass;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
