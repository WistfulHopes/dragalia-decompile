using System;
using Cute.UI;
using UnityEngine;

namespace Gluon;

public class MiniMapData : MonoBehaviour
{
	[Serializable]
	public struct MapChipSprite
	{
		public string spriteName;

		public SpriteRenderer spriteRenderer;
	}

	[SerializeField]
	[ReadOnly]
	private MapChipSprite[] _mapChipSprites;

	[SerializeField]
	[ReadOnly]
	private AtlasReference[] _atlasReferences;

	private Sprite GetSprite(AtlasReference atlasReference, string name)
	{
		return null;
	}

	private void Awake()
	{
	}
}
