using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class SpriteAnimation : MonoBehaviour
{
	public Image image;

	public Sprite[] clip;

	[SerializeField]
	public float interval;

	private int currentClipIndex;

	private int maxIndex;

	private float currentTime;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
