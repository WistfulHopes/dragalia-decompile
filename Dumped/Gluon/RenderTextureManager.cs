using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class RenderTextureManager : FastUpdateMonoBehaviour
{
	[Flags]
	public enum CameraLabelFlags
	{
		Main = 1,
		Story3D = 2,
		Story2D = 4
	}

	[Serializable]
	private class RenderTextureData
	{
		public string name;

		public Vector2Int size;

		public int depth;

		public bool isAlwaysScreenSize;

		[EnumFlags]
		public CameraLabelFlags createFlags;

		public RenderTextureFormat format;

		[NonSerialized]
		public RenderTexture renderTexture;
	}

	public delegate bool RenewRenderTexture(RenderTexture oldTexture, RenderTexture newTexture);

	private const CameraLabelFlags CameraLabelFlagsNone = (CameraLabelFlags)0;

	private const CameraLabelFlags CameraLabelFlagsAll = (CameraLabelFlags)2147483647;

	[SerializeField]
	private RenderTextureData[] _renderTextureData;

	private Dictionary<string, RenderTextureData> _renderTextureDataDictionary;

	public event RenewRenderTexture eventRenewRenderTexture
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void CreateTexture(CameraLabelFlags createFlags)
	{
	}

	public void ReleaseTexture(CameraLabelFlags releaseFlags)
	{
	}

	private void OnDestroy()
	{
	}

	public RenderTexture GetRenderTexture(int id)
	{
		return null;
	}

	public RenderTexture GetRenderTexture(string name)
	{
		return null;
	}

	public override void FastUpdate()
	{
	}
}
