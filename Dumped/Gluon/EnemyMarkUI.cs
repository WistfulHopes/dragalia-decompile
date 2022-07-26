using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class EnemyMarkUI : EnemyMarkSimpleUI
{
	[SerializeField]
	protected RectTransform conditionRt;

	[SerializeField]
	protected RectTransform nameRt;

	[SerializeField]
	protected RectTransform rateRt;

	[SerializeField]
	protected RectTransform hpGaugeShineRootRt;

	[SerializeField]
	protected RectTransform hpGaugeShineImageAdjustRt;

	[SerializeField]
	protected ElementIconUISpriteRenderer elementIcon;

	[SerializeField]
	protected Text nameText;

	[SerializeField]
	protected InGameGaugeUISpriteRenderer gauge;

	[SerializeField]
	protected SpriteRenderer elementIconImage;

	[SerializeField]
	protected SpriteRenderer emphasisBase;

	[SerializeField]
	protected SpriteRenderer emphasisText;

	[SerializeField]
	protected SpriteRenderer hpGaugeShineGaugeImage;

	[SerializeField]
	protected EnemyRareTimerCtrl enemyRareTimerCtrl;

	[SerializeField]
	protected Sprite[] emphasisBaseSprite;

	[SerializeField]
	protected Sprite[] emphasisTextSprite;

	[SerializeField]
	protected float scaleTargetChara;

	[SerializeField]
	protected float scaleMobEnemy;

	[SerializeField]
	public float durationMarkHP;

	[SerializeField]
	protected float hpGaugeShineAdjustStartPosX;

	[SerializeField]
	protected float hpGaugeShineAdjustEndPosX;

	[SerializeField]
	protected float rareInfoDmodeAdjustPosY;

	protected RectTransform gaugeRt;

	protected VisibleUIObject conditionVisible;

	protected VisibleUIObject labelVisible;

	protected VisibleUIObject hpGaugeShineVisible;

	protected SpriteRenderer[] rareLabelSpriteRenderers;

	protected HitCountUI hitCountUI;

	protected EnemyAbilityHeadGaugeUI enemyAbilityHeadGaugeUI;

	protected DisplayType currentType;

	protected float displayDuration;

	protected bool isVisibleEmphasisMark;

	protected float untargetDuration;

	protected const float untargetTime = 0.5f;

	public override void Initialize(EnemyCharacter enemy, InGameUICtrl inGameUI)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void LateUpdate()
	{
	}

	protected void UpdateChara()
	{
	}

	protected bool IsVisibleAttachUI()
	{
		return default(bool);
	}

	public void UpdateHpGaugeShine()
	{
	}

	protected void Invisible()
	{
	}

	public override void Show(DisplayType type, [Optional] CharacterBase target)
	{
	}

	protected void CharaHPRoutine(bool bTarget)
	{
	}

	public void CharaHpGaugeClear()
	{
	}

	public void ApplyCharaHpGauge(bool immediate = false)
	{
	}

	protected void ApplyInfoIcon(CharacterBase chara, bool isForce = false)
	{
	}

	protected bool ApplyElementIcon(ElementalType elementType, bool isForce = false)
	{
		return default(bool);
	}

	protected bool ApplyTribeIcon(TribeType tribeType, bool isForce = false)
	{
		return default(bool);
	}

	protected void TargetChara(bool bTarget)
	{
	}

	protected void RareVisible(bool b)
	{
	}

	public override EnemyAbilityHeadGaugeUI CreateEnemyAbilityHeadGaugeUI(EnemyAbilityHeadGaugeUI.IconType type)
	{
		return null;
	}

	public override void OnUpdateHpGaugeShineGaugeFade(float value)
	{
	}

	public override void OnUpdateHpGaugeShineLocalPosX(float value)
	{
	}
}
