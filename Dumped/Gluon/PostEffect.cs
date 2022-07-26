using System.Collections.Generic;
using Gluon.PostEffectParams;
using UnityEngine;

namespace Gluon;

[ExecuteAlways]
public class PostEffect : PostEffectsBase
{
	private const int BLOOM_DIVIDER = 4;

	private const float BLOOM_WIDTHMOD = 0.5f;

	private const float DEFAULT_SCREEN_LONG = 1280f;

	private const float DEFAULT_SCREEN_SHORT = 720f;

	private const string keywordEnableBloomColor = "ENABLE_BLOOM_COLOR";

	private const string keywordEnableDiffusionColor = "ENABLE_DIFFUSION_COLOR";

	private const string keywordEnableColorAdjustment = "ENABLE_COLOR_ADJUSTMENT";

	private const string keywordEnableLastGaussFilter = "ENABLE_LAST_GAUSSFILTER";

	private CacheCamera _cacheCamera;

	[SerializeField]
	private bool _isMainCamera;

	private PostEffect _mainCameraPostEffectLive3D;

	[SerializeField]
	private FilterType _filterType;

	[SerializeField]
	private FilterUseType _filterLowerLimitType;

	[SerializeField]
	private bool _isNoSetNoEffect;

	[SerializeField]
	private bool _isEnableDof;

	[SerializeField]
	private bool _isEnableBloom;

	[SerializeField]
	private bool _isEnableDiffusionColor;

	[SerializeField]
	private bool _isEnableColorAdjustment;

	private FilterUseType _filterUseType;

	[SerializeField]
	private PostEffectShaderListData _postEffectShaderListData;

	[SerializeField]
	private CommonParam _commonParam;

	[SerializeField]
	private GaussFilterParam _gaussFilterParam;

	[SerializeField]
	private BloomParam _bloomParam;

	[SerializeField]
	private DepthOfFieldParam _depthOfFieldParam;

	[SerializeField]
	private TiltShiftParam _tiltShiftParam;

	[SerializeField]
	private ColorAdjustmentParam _colorAdjustmentParam;

	[SerializeField]
	private PostFilmParam _postFilmParam;

	[SerializeField]
	private LastGaussFilterParam _lastGaussFilterParam;

	private List<RenderTexture> _renderTextureList;

	private const int pointIrisMaxCount = 8;

	private const int pointIrisParamCount = 4;

	private Vector4[] pointIrisCenterPosition;

	private Vector4[] pointIrisCenterRadius;

	private int[] _PostEffectPropIDPointIrisPosition;

	private int[] _PostEffectPropIDPointIrisRadius;

	private const int PASS_POSTBLOOM_HORIZONGAUSS = 0;

	private const int PASS_POSTBLOOM_VERTICALGAUSS = 1;

	private const int PASS_POSTBLOOM_VERTICALGAUSS_BLOOM = 2;

	private const int PASS_POSTBLOOM_BLIT = 3;

	private const int PASS_POSTDOFBLOOM_HORIZONGAUSS = 0;

	private const int PASS_POSTDOFBLOOM_VERTICALGAUSS = 1;

	private const int PASS_POSTDOFBLOOM_BLOOM = 2;

	private const int PASS_POSTDOFBLOOM_COC_DEBUG = 3;

	private const int PASS_POSTDOFBLOOM_DEPTH_DEBUG = 4;

	private const int PASS_POSTDOFBLOOM_BLIT = 5;

	private const int PASS_POSTTILTSHIFTBLOOM_HORIZONGAUSS = 0;

	private const int PASS_POSTTILTSHIFTBLOOM_VERTICALGAUSS = 1;

	private const int PASS_POSTTILTSHIFTBLOOM_BLOOM = 2;

	private const int PASS_POSTTILTSHIFTBLOOM_DEBUG = 3;

	private const int PASS_POSTTILTSHIFTBLOOM_BLIT = 4;

	private const int PASS_POSTONLYSTANDARDEFFECT_HORIZONGAUSS = 0;

	private const int PASS_POSTONLYSTANDARDEFFECT_VERTICALGAUSS = 1;

	private const int PASS_POSTONLYSTANDARDEFFECT_BLIT = 2;

	public bool isMainCamera
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public FilterType filterType
	{
		get
		{
			return default(FilterType);
		}
		set
		{
		}
	}

	public bool isEnableDof
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool isEnableBloom
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool isEnableDiffusionColor
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool isEnableColorAdjustment
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public CommonParam commonParam => null;

	public GaussFilterParam gaussFilterParam => null;

	public BloomParam bloomParam => null;

	public DepthOfFieldParam depthOfFieldParam => null;

	public TiltShiftParam tiltShiftParam => null;

	public ColorAdjustmentParam colorAdjustmentParam => null;

	public PostFilmParam postFilmParam => null;

	public LastGaussFilterParam lastGaussFilterParam => null;

	public List<RenderTexture> renderTextureList => null;

	public void SetFilterUseType(FilterUseType useType)
	{
	}

	private float FocalDistance01(float worldDist)
	{
		return default(float);
	}

	public override bool CheckResources()
	{
		return default(bool);
	}

	private void OnEnable()
	{
	}

	private Vector2 CalcScreenRate()
	{
		return default(Vector2);
	}

	private void SetupColorAdjustment(Material material)
	{
	}

	private RenderTexture CreateResizeTempRenderTexture(RenderTexture source, float scale)
	{
		return null;
	}

	private void SetPixelBuff(Material material, float pixelSize, GaussType gauss)
	{
	}

	private void BlitGaussFilter(Material material, RenderTexture source, float blurSize, RenderTexture rt1, GaussType gaussH, int passH, RenderTexture rt2, GaussType gaussV, int passV)
	{
	}

	private void BlitCreateBloom(Material material, RenderTexture source, RenderTexture destination, int pass)
	{
	}

	private void LastGaussBlit(Material material, int pass, RenderTextureData srcRTData, RenderTextureData dstRTData, int horizonGaussPass, int verticaluGaussPass)
	{
	}

	private void BlitDestination(Material material, int pass, RenderTextureData srcRTData, RenderTextureData dstRTData, RenderTexture bloomTex, int horizonGaussPass, int verticaluGaussPass)
	{
	}

	private void PostFilmBlit(RenderTexture source, RenderTexture destination, Material material, int pass = 0)
	{
	}

	private void SetBloomParameter(Material material)
	{
	}

	private void SetDofParameter(Material material)
	{
	}

	public void SetPointIrisSetting(int index, float centerX, float centerY, float radiusX, float radiusY)
	{
	}

	private bool OnRenderImageBloom(RenderTextureData srcRTData, RenderTextureData dstRTData)
	{
		return default(bool);
	}

	private bool OnRenderImageDofBloom(RenderTextureData srcRTData, RenderTextureData dstRTData)
	{
		return default(bool);
	}

	private bool OnRenderImageTiltShiftBloom(RenderTextureData srcRTData, RenderTextureData dstRTData)
	{
		return default(bool);
	}

	private bool OnRenderImageTiltShiftPointIrisBloom(RenderTextureData srcRTData, RenderTextureData dstRTData)
	{
		return default(bool);
	}

	private bool OnRenderImageGaussBloom(RenderTextureData srcRTData, RenderTextureData dstRTData)
	{
		return default(bool);
	}

	private bool OnRenderImageOnlyStandardEffect(RenderTextureData srcRTData, RenderTextureData dstRTData)
	{
		return default(bool);
	}

	private void OnRenderImageTiltShiftBloomCommon(Material material, RenderTextureData srcRTData, RenderTextureData dstRTData)
	{
	}

	public override DepthTextureMode GetNeedDepthTextureMode()
	{
		return default(DepthTextureMode);
	}

	private void CreatePropertyIDTable()
	{
	}

	public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
	{
		return default(bool);
	}

	protected override void Awake()
	{
	}

	private void LateUpdateStatusFromMainCamera()
	{
	}

	private void LateUpdate()
	{
	}
}
