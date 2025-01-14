using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon;

public class GrowthManaCircleStatusController : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	public CommonUnitIcon unitIcon;

	public GrowthManaCircleStatusObject[] statusObjects;

	public GameObject[] pagerOn;

	public GameObject[] pagerOff;

	public Button leftArrow;

	public Button rightArrow;

	[HideInInspector]
	public GrowthManaCircleModel model;

	private int currentIndex;

	private Vector2 beginDragPosition;

	private bool isAnimating;

	private const float resolutionFixRate = 100f;

	private void Start()
	{
	}

	public void Reload()
	{
	}

	private void SetCharaIcon()
	{
	}

	private void SetPageOn(int index)
	{
	}

	public void SetArrowEnable(bool enable)
	{
	}

	private void ShowSkillDetailDialog(int skillId, int level, int maxLevel)
	{
	}

	public void OnSkill1ButtonPressed()
	{
	}

	public void OnSkill2ButtonPressed()
	{
	}

	private void ShowAbilityDetailDialog(int abilityId, int abilityLv, ElementalType type)
	{
	}

	public void Ability1ButtonPressed()
	{
	}

	public void Ability2ButtonPressed()
	{
	}

	public void Ability3ButtonPressed()
	{
	}

	private void ShowExAbilityDetailDialog(int abilityId, int index)
	{
	}

	public void ExAbilityButtonPressed()
	{
	}

	public void ExAbility2ButtonPressed()
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void ShowNextStatusObject()
	{
	}

	public void ShowPrevStatusObject()
	{
	}

	public void OnAnimationCompleted()
	{
	}
}
