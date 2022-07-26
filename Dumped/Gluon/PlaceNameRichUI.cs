using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class PlaceNameRichUI : MonoBehaviour
{
	[SerializeField]
	private Text placeName;

	[SerializeField]
	private Image bg;

	[SerializeField]
	private Text floorText;

	[SerializeField]
	private Text floorPlace;

	[SerializeField]
	private Image lineImage;

	[SerializeField]
	private Text exConditionText;

	[SerializeField]
	private Text exCondition2Text;

	[SerializeField]
	private Text exCondition3Text;

	[SerializeField]
	private RectTransform exConditionRt;

	[SerializeField]
	private RectTransform exCondition2Rt;

	[SerializeField]
	private RectTransform exCondition3Rt;

	[SerializeField]
	private float fadeInTime;

	[SerializeField]
	private float fadeOutTime;

	[SerializeField]
	private float bgAlpha;

	private RectTransform rootRt;

	private Tweener tweenerFade;

	private Coroutine coroutine;

	private PlayFTU ftu;

	private PlayFTU.Type ftuType;

	private string ftuCloseLabel;

	private bool isActive;

	private bool isRaedy;

	private bool isFloor;

	private readonly Color REBORN_CONDITION_COLOR;

	public static PlaceNameRichUI Create(GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize()
	{
	}

	public void SetFTU(PlayFTU ftu, PlayFTU.Type ftuType, string ftuCloseLabel)
	{
	}

	public void Ready(string placeName, int floor)
	{
	}

	private void OnReady(PlayFTU sender)
	{
	}

	private void SetupLayout()
	{
	}

	public void Open()
	{
	}

	private IEnumerator PlayFlash()
	{
		return null;
	}

	public void Close()
	{
	}

	private IEnumerator PlayCloseFlash()
	{
		return null;
	}

	private void OnUpdateFadeIn(float value)
	{
	}

	private void OnUpdateFadeOut(float value)
	{
	}

	private void OnCompleteFadeIn()
	{
	}

	private void OnCompleteFadeOut()
	{
	}

	public void Release()
	{
	}

	private void SetActive(bool active)
	{
	}
}
