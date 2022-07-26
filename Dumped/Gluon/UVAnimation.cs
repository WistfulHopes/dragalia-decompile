using System;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class UVAnimation : FastUpdateMonoBehaviour
{
	[Serializable]
	public struct FrameWaitInfo
	{
		public int frame;

		public float waitTime;
	}

	[Serializable]
	public struct LoopInfo
	{
		public bool loop;

		public int startFrame;

		public int endFrame;

		public int loopNum;
	}

	[Serializable]
	public struct InterruptionInfo
	{
		[SerializeField]
		public int interruptionFrame;

		[SerializeField]
		public float delay;

		[SerializeField]
		public float delayRandom;

		[NonSerialized]
		public float totalDelay;
	}

	[SerializeField]
	public Rect rect;

	[SerializeField]
	private Vector2 marginSize;

	[SerializeField]
	private int imageCount;

	[SerializeField]
	private bool modifyTextureTiling;

	[SerializeField]
	private float speed;

	private float speedInverse;

	[SerializeField]
	private FrameWaitInfo[] frameWaitInfoArray;

	[SerializeField]
	private LoopInfo loopInfo;

	[SerializeField]
	private float delay;

	[SerializeField]
	private float delayRandom;

	private float totalDelay;

	[SerializeField]
	private InterruptionInfo[] interruptionInfo;

	[SerializeField]
	private Material _sharedMaterial;

	[SerializeField]
	private bool isCreateAddtionalMeshForUV;

	private MeshRenderer orgMeshRenderer;

	private MeshFilter orgMeshFilter;

	private Mesh orgMesh;

	private Vector2[] addtionalUVs;

	private Mesh addtionalUvStream;

	private float duration;

	private float timeCount;

	private float delayTime;

	private Material _material;

	private int textureWidth;

	private int textureHeight;

	private int frame;

	private Vector2 mainTextureScale;

	private int remainingLoopNum;

	private float loopStartFrameX;

	private float loopStartFrameY;

	private float lastRowHeight;

	private bool hasAlphaTex;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Scroll()
	{
	}
}
