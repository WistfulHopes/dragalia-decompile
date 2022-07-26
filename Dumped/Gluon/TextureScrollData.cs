using System;
using UnityEngine;

namespace Gluon;

[Serializable]
public class TextureScrollData
{
	[SerializeField]
	private string _texturePropertyName;

	private string _texturePropertyName_ST;

	private int _texturePropertyID;

	private int _texturePropertyID_ST;

	[SerializeField]
	private string _alphaTexturePropertyName;

	private string _alphaTexturePropertyName_ST;

	private int _alphaTexturePropertyID_ST;

	[SerializeField]
	private bool _animationCurveMode;

	[SerializeField]
	private Vector2 _Speed;

	[SerializeField]
	private int _IntervalFrame;

	[SerializeField]
	private int _randomOffsetMaxFrame;

	[SerializeField]
	private float _animationTotalTime;

	[SerializeField]
	private float _animationStartOffsetTime;

	[SerializeField]
	private AnimationCurve _animationCurveU;

	[SerializeField]
	private AnimationCurve _animationCurveV;

	private Vector4 _Texture_ST;

	private int _oldFrame;

	private float _intervalTime;

	private int _randomOffsetFrame;

	public string AlphaTexturePropertyName => null;

	public Vector2 speed
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public void Start()
	{
	}

	public void Update(float time, int frame, Material material, MaterialPropertyBlock materialPropertyBlock, Vector2 scale)
	{
	}
}
