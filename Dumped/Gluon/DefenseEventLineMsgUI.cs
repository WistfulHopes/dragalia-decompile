using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class DefenseEventLineMsgUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform bgRt;

	[SerializeField]
	private Text message;

	[SerializeField]
	private SpriteRenderer bgImage;

	[SerializeField]
	private float fadeTime;

	[SerializeField]
	private float stayTime;

	[SerializeField]
	private float slideMoveVal;

	private RectTransform rootRt;

	private CanvasGroup canvasGroup;

	private Tweener tweenerFade;

	private bool isDisplaying;

	public void Initialize(Sprite sprite, Material material)
	{
	}

	private void OnDestroy()
	{
	}

	public bool IsDisplaying()
	{
		return default(bool);
	}

	public void Display(string msg)
	{
	}

	private void OnUpdateFadeIn(float value)
	{
	}

	private void OnCompleteFadeIn()
	{
	}

	private void OnCompleteStay()
	{
	}

	private void OnUpdateFadeOut(float value)
	{
	}

	private void OnCompleteFadeOut()
	{
	}

	public void AdjustPosY(float posY)
	{
	}
}
