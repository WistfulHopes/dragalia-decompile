using System.Collections.Generic;
using UnityEngine;

namespace Gluon;

public class ImageEffectPlayer : MonoBehaviour
{
	[SerializeField]
	private bool enableAlpha;

	[SerializeField]
	[ReadOnly]
	private List<ImageEffectBase> _imageEffectList;

	[SerializeField]
	[ReadOnly]
	private List<ImageEffectBase> _imageEffectWorkList;

	[SerializeField]
	[ReadOnly]
	private PostEffectExternalMode[] _postEffectExternalModeArray;

	[SerializeField]
	[ReadOnly]
	private ImageEffectAttachment[] _imageEffectAttachmentArray;

	[SerializeField]
	[ReadOnly]
	private Material material;

	private Camera _cacheCamera;

	private const int IMAGEEFFECT_SORTSCALE = 100;

	private const float OUTLINE_FOV_BASE = 30f;

	public bool AddImageEffect(ImageEffectBase imageEffectBase)
	{
		return default(bool);
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPreRender()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
