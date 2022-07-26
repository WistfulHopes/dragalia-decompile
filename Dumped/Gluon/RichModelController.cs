using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon;

public class RichModelController : MonoBehaviour
{
	[Serializable]
	public class MultiMaskData
	{
		public static readonly string allMaterialName;

		public string materialName;

		public Texture2D multiMask;
	}

	[Serializable]
	public class ToonShadingData : IShaderData<ToonShadingData>
	{
		public bool enable;

		public Color toonShadowColor;

		public HSVParameterBase toonShadowHSV;

		public bool overwriteShadowEdge;

		public HSVParameterBase shadowEdgeHSV;

		public MultiMaskData[] multiMaskDataArray;

		public void Copy(ToonShadingData src)
		{
		}
	}

	[Serializable]
	public class OutlineData : IShaderData<OutlineData>
	{
		public bool enable;

		public Color color;

		public Color addColor;

		public float addColorPower;

		public float width;

		public bool useColor2;

		public Color color2;

		public void Copy(OutlineData src)
		{
		}
	}

	[Serializable]
	public class RichGraphicData : IShaderData<RichGraphicData>
	{
		public ToonShadingData toonShadingData;

		public OutlineData outlineData;

		public void Copy(RichGraphicData src)
		{
		}
	}

	[SerializeField]
	private RichGraphicData _richGraphicData;

	private List<Material> _materialList;

	private Transform _cacheTransform;

	public RichGraphicData richGraphicData => null;

	public GameObject rootObject
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Renderer[] renderers
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	protected virtual void Update()
	{
	}

	private void SetMaterialParameter()
	{
	}

	public void SetupToonShading(GameObject obj, [Optional] ShaderLodDataObject shaderLodDataObject)
	{
	}

	private void LateUpdate()
	{
	}
}
