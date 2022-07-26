using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon;

public class DungeonBgMaterialProduction : MonoBehaviour
{
	[Serializable]
	private class MaterialProductionCommon
	{
		public bool enable;

		public DungeonBgArtistBgMaterialGroup.MaterialGroupID materialGroupID;

		public DungeonBgArtistBgMaterialGroup.MaterialPropertyLabel materialPropertyLabel;
	}

	[Serializable]
	private class MaterialProductionFloat : MaterialProductionCommon
	{
		public AnimationCurve curveF;
	}

	[Serializable]
	private class MaterialProductionVector : MaterialProductionCommon
	{
		public AnimationCurve curveX;

		public AnimationCurve curveY;

		public AnimationCurve curveZ;
	}

	[Serializable]
	private class MaterialProductionColor : MaterialProductionCommon
	{
		public Gradient gradient;
	}

	[Serializable]
	private class MaterialProductionData
	{
		public string name;

		public bool enable;

		public float timeScale;

		public DungeonBgModelProduction.ChangeBgTextureProductionKind productionKind;

		public MaterialProductionFloat[] floatDataArray;

		public MaterialProductionVector[] vectorDataArray;

		public MaterialProductionColor[] colorDataArray;

		public float endTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void CalcEndTime()
		{
		}
	}

	[SerializeField]
	private DungeonBgModelProduction.ChangeBgTextureProductionKind actionOn;

	[SerializeField]
	private float actionOnEvaluateTime;

	[SerializeField]
	private DungeonBgModelProduction.ChangeBgTextureProductionKind actionOff;

	[SerializeField]
	private float actionOffEvaluateTime;

	[SerializeField]
	private MaterialProductionData[] materialProductionDataArray;

	public DungeonBgArtistBgMaterialGroup dungeonBgArtistBgMaterialGroup
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

	private void CalcEndTime()
	{
	}

	public bool SetBgTextureParam(DungeonBgModelProduction.ChangeBgTextureProductionKind srcKind, float time)
	{
		return default(bool);
	}

	private void Start()
	{
	}
}
