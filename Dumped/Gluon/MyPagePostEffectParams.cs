using System;
using Gluon.PostEffectParams;
using UnityEngine;

namespace Gluon;

public class MyPagePostEffectParams : MonoBehaviour
{
	[Serializable]
	public struct WorldIrisSetting
	{
		public Vector3 position;

		public float width;

		public float height;
	}

	[Serializable]
	public struct PointIrisSetting
	{
		public float pointIrisCenterX;

		public float pointIrisCenterY;

		public float pointIrisRadiusX;

		public float pointIrisRadiusY;
	}

	public FilterType filterType;

	public bool isColorCollect;

	public bool isUseFog;

	public bool isDof;

	public DofFocalType dofFocalType;

	public Transform dofFocalTransfrom;

	public Vector3 dofFocalPosition;

	public float dofFocalPoint;

	public float dofSmoothness;

	public float focalSize;

	public bool isEnableBloom;

	public float bloomDofWeight;

	public float bloomThreshhold;

	public float bloomIntensity;

	[SerializeField]
	public float bloomTextureScale;

	public float diffusionBlurSize;

	public float bright;

	public float saturation;

	public float contrast;

	public PostFilmMode postFilmMode;

	public float postFilmPower;

	public Vector2 postFilmOffsetParam;

	public float vignetteIntensity;

	public float vignetteDecrement;

	public Color postFilmColor0;

	public Color postFilmColor1;

	public Color postFilmColor2;

	public Color postFilmColor3;

	public float blurArea;

	public float blurPower;

	public float blurOffset;

	public float blurBaseUp;

	public WorldIrisSetting[] worldIrisSetting;

	public PointIrisSetting[] pointIrisSettings;

	[SerializeField]
	public float pointIrisCutout;

	public bool isTiltShiftDebug;

	public GaussType gaussVertical;

	public GaussType gaussHorizon;

	public float lastGaussFilterBlurPower;

	public float lastGaussFilterBlurSize;

	public Color fogColor;

	public float fogStartDistance;

	public float fogEndDistance;
}
