using UnityEngine;

namespace Gluon;

public class TextureScroll : MaterialControlComponent
{
	[SerializeField]
	private TextureScrollData[] _textureScrollData;

	[SerializeField]
	private bool enableStopProduction;

	public TextureScrollData[] textureScrollData => null;

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
