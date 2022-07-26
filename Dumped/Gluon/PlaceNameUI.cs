using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class PlaceNameUI : MonoBehaviour
{
	[SerializeField]
	private Text placeName;

	[SerializeField]
	private Text summary;

	[SerializeField]
	private Text exConditionText;

	[SerializeField]
	private Text exCondition2Text;

	[SerializeField]
	private Text exCondition3Text;

	[SerializeField]
	private Image bg;

	[SerializeField]
	private Image border;

	[SerializeField]
	private GameObject timeObject;

	[SerializeField]
	private Image timeIcon;

	[SerializeField]
	private Text timeText;

	[SerializeField]
	private RectTransform exConditionRt;

	[SerializeField]
	private RectTransform exCondition2Rt;

	[SerializeField]
	private RectTransform exCondition3Rt;

	[SerializeField]
	private RectTransform timeRt;

	[SerializeField]
	private float fadeTime;

	[SerializeField]
	private float bgAlpha;

	private VisibleUIObject rootVisible;

	private Vector3 timeOriginPos;

	private Tweener tweenerFade;

	private const float CONTINUE_IMPOSSIBLE_MERGIN = 45f;

	private readonly Color REBORN_CONDITION_COLOR;

	public static PlaceNameUI Create(GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize()
	{
	}

	public void Open(string placeName, string summary, Color summaryColor, float time)
	{
	}

	public void Close()
	{
	}

	public bool IsVisible()
	{
		return default(bool);
	}

	private void SetupLayout()
	{
	}

	private void OnUpdateFade(float value)
	{
	}

	private void OnCompleteFadeIn()
	{
	}

	private void OnCompleteFadeOut()
	{
	}
}
