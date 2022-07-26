using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon;

public class ImageEffectBase : MonoBehaviour
{
	[SerializeField]
	private int _imageEffectID;

	[SerializeField]
	[ReadOnly]
	private int _imageEffectSortID;

	[SerializeField]
	private LodLevel _enableLodLevel;

	public int imageEffectID
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int imageEffectSortID
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public LodLevel enableLodLevel => default(LodLevel);

	public virtual DepthTextureMode GetNeedDepthTextureMode()
	{
		return default(DepthTextureMode);
	}

	public virtual bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
	{
		return default(bool);
	}
}
