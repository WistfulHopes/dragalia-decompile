using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class DropItemBright : FastUpdateMonoBehaviour
{
	[SerializeField]
	private Image baseImage;

	[SerializeField]
	private Image brightImage0;

	[SerializeField]
	private Image brightImage1;

	private float animTime;

	private const float animDuration = 8f;

	private const float animDurationHalf = 4f;

	public bool isPlaying
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static DropItemBright Create(GameObject parent, GameObject prefab)
	{
		return null;
	}

	private void Initialize()
	{
	}

	public override void FastUpdate()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	public void SetFade(float alpha)
	{
	}
}
