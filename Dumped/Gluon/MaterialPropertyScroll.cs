using System;
using UnityEngine;

namespace Gluon;

public class MaterialPropertyScroll : MaterialControlComponent
{
	[Serializable]
	public class ScrollData
	{
		[SerializeField]
		private string _texturePropertyName;

		private int _texturePropertyID;

		[SerializeField]
		private bool _animationCurveMode;

		[SerializeField]
		private float _Speed;

		[SerializeField]
		private int _IntervalFrame;

		[SerializeField]
		private int _randomOffsetMaxFrame;

		[SerializeField]
		private float _animationTotalTime;

		[SerializeField]
		private float _animationStartOffsetTime;

		[SerializeField]
		private AnimationCurve _animationCurve;

		private int _oldFrame;

		private float _intervalTime;

		private int _randomOffsetFrame;

		public float speed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public void Start()
		{
		}

		public void Update(float time, int frame, Material material, MaterialPropertyBlock materialPropertyBlock)
		{
		}
	}

	[SerializeField]
	private ScrollData[] _scrollData;

	public ScrollData[] scrollData => null;

	protected override void Awake()
	{
	}

	protected void Reset()
	{
	}

	private void Update()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}
}
