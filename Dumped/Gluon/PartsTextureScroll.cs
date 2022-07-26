using Cute.Core;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon;

public class PartsTextureScroll : FastUpdateMonoBehaviour
{
	[SerializeField]
	private PartsTextureScrollData[] _partsTextureScrollData;

	[SerializeField]
	private bool enableStopProduction;

	private RenderPartsData _renderPartsData;

	private float _startTime;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	protected void Reset()
	{
	}

	public override void FastUpdate()
	{
	}
}
