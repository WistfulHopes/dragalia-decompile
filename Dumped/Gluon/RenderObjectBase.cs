using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon;

public class RenderObjectBase : CommonObjectStatus
{
	public enum FaceType
	{
		NONE,
		NORMAL,
		BLINK,
		DAMAGE,
		DEAD,
		WIN
	}

	protected FaceType faceType;

	protected CharacterFace face;

	[SerializeField]
	[ReadOnly]
	protected MaterialPropertyRenderer _mainMaterialPropertyRenderer;

	[SerializeField]
	[ReadOnly]
	protected MaterialPropertyRenderer _mouthMaterialPropertyRenderer;

	[SerializeField]
	[ReadOnly]
	protected MaterialPropertyRenderer _eyeMaterialPropertyRenderer;

	[SerializeField]
	[ReadOnly]
	protected MaterialPropertyRenderer _weaponMaterialPropertyRenderer;

	protected List<Renderer> otherSetRendererList;

	public CharacterFace Face => null;

	public List<Renderer> allRendererList
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public MaterialPropertyRenderer mouseMaterialPropertyRenderer => null;

	public MaterialPropertyRenderer eyeMaterialPropertyRenderer => null;

	public bool enableMainMaterialPropertyBlock => default(bool);

	public List<MaterialPropertyData> materialPropertyDataList
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public RenderPartsData renderPartsData
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public List<RenderPartsData.PartsMeshData> relatedRenderPartsDataList
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public virtual void SetFaceType(FaceType type, bool force = false)
	{
	}

	public virtual void SetMaterialPropertyBlock()
	{
	}

	public void SetCharaColor(bool isStatusColorSet, CharacterColor colorCtrl)
	{
	}

	public virtual void InitializeRenderState([Optional] Renderer[] setRenderers, [Optional] Func<Renderer, bool> entryRendererFunc, [Optional] Action setInitializeRenderStateFunc)
	{
	}

	public void SetFaceMaterial(bool force = false)
	{
	}

	protected void SetRenderers(Renderer[] inRenderers)
	{
	}

	protected void UpdateRenderState()
	{
	}

	protected override void Awake()
	{
	}

	public void SetActiveRenderer(bool isActive)
	{
	}

	protected virtual MaterialPropertyData GetMaterialPropertyBlockFromName(string partsName)
	{
		return null;
	}

	public void SetMpbMixingTextureRatio(string partsName, float ratio)
	{
	}

	public void SetFaceMaterialRatio(float ratio)
	{
	}

	public void SetMpbMixingTexture(string partsName, int mainTexID, Texture2D mainTexture, int subTexID, Texture2D subTexture, float ratio, int mainTexSTID, Vector2 scale, Vector2 offset)
	{
	}

	public void SetMpbAuraColorRaito(float ratio)
	{
	}

	public void SetMpbAuraCutoutRaito(float ratio)
	{
	}

	public void SetCharacterMultiColor(Color multiColor)
	{
	}

	public virtual void LateUpdate()
	{
	}
}
