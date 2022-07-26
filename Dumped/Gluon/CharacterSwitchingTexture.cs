using System;
using System.Collections;
using UnityEngine;

namespace Gluon;

public class CharacterSwitchingTexture : MonoBehaviour
{
	[Serializable]
	public class SwitchData
	{
		public Texture2D texture;

		public Vector2 scale;

		public Vector2 offset;
	}

	[SerializeField]
	private string[] _switchPartsNames;

	[SerializeField]
	private string _propertyMainTexName;

	[SerializeField]
	private string _propertySubTexName;

	[SerializeField]
	private bool _updateOwnerMaterial;

	[SerializeField]
	private SwitchData[] _switchData;

	private int _propertyMainTexID;

	private int _propertyMainTexSTID;

	private int _propertySubTexID;

	private float _fadeRatio;

	private int _fadeStartIndex;

	private int _fadeEndIndex;

	private RenderObjectBase _owner;

	private float _duration;

	private float _time;

	private IEnumerator coSwitingTexture;

	public SwitchData[] switchData => null;

	public string[] switchPartsNames => null;

	public int propertyMainTexID => default(int);

	public int propertyMainTexSTID => default(int);

	public int propertySubTexID => default(int);

	private void Start()
	{
	}

	public void Play(int start_idx, int end_idx, float duration, bool initializeIfNeed = false)
	{
	}

	public void RestoreGraphicsProperties()
	{
	}

	private IEnumerator CoSwitingTexture()
	{
		return null;
	}

	public void Stop()
	{
	}

	private void Finish()
	{
	}
}
