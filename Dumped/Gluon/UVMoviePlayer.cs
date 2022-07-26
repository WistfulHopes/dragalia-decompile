using UnityEngine;

namespace Gluon;

public class UVMoviePlayer : MonoBehaviour
{
	[SerializeField]
	private Renderer _renderer;

	[SerializeField]
	private UVMovieController _uvMovieController;

	[SerializeField]
	private float _playOffsetTime;

	[SerializeField]
	private bool _isStartPlay;

	[SerializeField]
	private string _texturePropertyName;

	private int _texturePropertyID;

	private int _textureSTPropertyID;

	private MaterialPropertyBlock _materialPropertyBlock;

	private float _startTime;

	private float GetNowTime()
	{
		return default(float);
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
