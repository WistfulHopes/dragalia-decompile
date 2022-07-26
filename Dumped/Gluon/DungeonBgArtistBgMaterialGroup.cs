using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon;

public class DungeonBgArtistBgMaterialGroup : MonoBehaviour
{
	public enum MaterialGroupID
	{
		A,
		B,
		C,
		D,
		E,
		H,
		G,
		I,
		J,
		K,
		L,
		M,
		N,
		O,
		P,
		Q,
		R,
		S,
		T,
		U,
		V,
		W,
		X,
		Y,
		Z
	}

	public enum MaterialPropertyLabel
	{
		Color,
		SubTextureAlpha,
		SubPaletteAlpha
	}

	public class MpbData
	{
		public Renderer targetRenderer;

		public MaterialPropertyBlock targetMpb;
	}

	[Serializable]
	public class MaterialGroupData
	{
		public string name;

		public MaterialGroupID id;

		public List<Material> materialList;

		public List<MpbData> mpbList;
	}

	[SerializeField]
	private GameObject productionObject;

	[SerializeField]
	private List<MaterialGroupData> _materialGroupDataList;

	private static int[] materialPropertyIDArray;

	public List<MaterialGroupData> materialGroupDataList => null;

	public void SetFloat(MaterialGroupID groupID, MaterialPropertyLabel propertyLabel, float value)
	{
	}

	public void SetVector(MaterialGroupID groupID, MaterialPropertyLabel propertyLabel, Vector4 vec)
	{
	}

	public void SetColor(MaterialGroupID groupID, MaterialPropertyLabel propertyLabel, Color color)
	{
	}

	private void Awake()
	{
	}

	public IEnumerator Start()
	{
		return null;
	}
}
