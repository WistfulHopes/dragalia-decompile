using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon.GraphicParameter;

public class RenderPartsData : MonoBehaviour
{
	public enum PartsNo
	{
		A = 0,
		B = 1,
		C = 2,
		D = 3,
		E = 4,
		F = 5,
		G = 6,
		H = 7,
		None = -1
	}

	[Serializable]
	public class RendererData
	{
		public Renderer renderer;

		public int materialIndex;

		public void Copy(RendererData srcData, Renderer[] renderers)
		{
		}
	}

	[Serializable]
	public class RendererDataArray
	{
		public RendererData[] rendererDataArray;

		public void Copy(RendererDataArray srcData, Renderer[] renderers)
		{
		}
	}

	[Serializable]
	public class PartsMeshData
	{
		public string name;

		public bool isSyncMainColor;

		public PartsNo activeNo;

		public PartsNo cuttInitializeNo;

		public PartsNo myPageSceneInitializeNo;

		public PartsNo equipWeaponSceneInitializeNo;

		public PartsNo otherOutGameSceneInitializeNo;

		public PartsNo aoOutGameSceneInitializeNo;

		public List<RendererDataArray> rendererDataArrayList;

		[HideInInspector]
		public MaterialPropertyData materialPropertyData;

		private PartsNo currentPartsNo;

		public PartsNo CurrentPartsNo
		{
			get
			{
				return default(PartsNo);
			}
			set
			{
			}
		}

		public void SetActiveRenderer(PartsNo no)
		{
		}

		public void Copy(PartsMeshData srcData, Renderer[] renderers)
		{
		}
	}

	[SerializeField]
	private List<Renderer> bodyRenderers;

	[SerializeField]
	private List<PartsMeshData> _partsMeshDataList;

	private List<Renderer> entryRendererList;

	public static readonly string SpecialPartsName_Eye;

	public static readonly string SpecialPartsName_Mouth;

	public static readonly string[] SpecialPartsNames;

	public List<PartsMeshData> partsMeshDataList => null;

	public Dictionary<string, PartsMeshData> partsMeshDataDictionary
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public PartsMeshData GetPartsMeshData(string name)
	{
		return null;
	}

	public bool IsPartsRenderer(Renderer testRenderer)
	{
		return default(bool);
	}

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void ChangeMesh(string partsName, PartsNo partsNo)
	{
	}

	public void RestoreMeshEnable()
	{
	}

	public void ResetChangeMesh()
	{
	}

	public void CuttInitialize()
	{
	}

	public void OutGameInitialize(SimpleCharacterModelLoader.OutGameScene scene)
	{
	}

	public void SetPropertyBlock()
	{
	}

	public MaterialPropertyData GetMaterialPropertyData(string partsName)
	{
		return null;
	}

	public static PartsNo GetPartsNoFromString(string partsNoStr)
	{
		return default(PartsNo);
	}

	public List<Renderer> GetEntryRendererList()
	{
		return null;
	}

	public List<Renderer> GetBodyRendererList()
	{
		return null;
	}

	public void AddBodyRendererList(Renderer renderer)
	{
	}
}
