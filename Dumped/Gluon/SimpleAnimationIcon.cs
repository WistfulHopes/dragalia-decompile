using UnityEngine;

namespace Gluon;

public class SimpleAnimationIcon : MonoBehaviour
{
	public enum Type
	{
		ExpandWithDelay,
		Expand,
		FadeIn,
		None
	}

	[SerializeField]
	public Type type;

	[HideInInspector]
	public int delayIndex;

	private RectTransform rectTransform;

	private const float expandRate = 1.15f;

	private const float expandDuration = 4f / 15f;

	private const float bounceDuration = 2f / 15f;

	private const float fadeInDuration = 0.5f;

	private CanvasGroup canvasGroup;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void StartAnimation()
	{
	}

	public static float GetDelayTimeByAnimationType(int index, Type animType)
	{
		return default(float);
	}

	protected void StartExpandAnimation(float delay)
	{
	}

	public void SkipAnimation()
	{
	}

	protected void StartFadeInAnimation(float delay)
	{
	}
}
