using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class BossBreakUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private ElementIconUISpriteRenderer elementIcon;

	[SerializeField]
	private Text nameText;

	[SerializeField]
	private InGameGaugeUISpriteRenderer hpGauge;

	[SerializeField]
	private InGameGaugeUISpriteRenderer breakGauge;

	[SerializeField]
	private RectTransform adjustRt;

	[SerializeField]
	private RectTransform breakGaugeRt;

	[SerializeField]
	private RectTransform hpGaugeShineRootRt;

	[SerializeField]
	private RectTransform hpGaugeShineSubRootRt;

	[SerializeField]
	private RectTransform hpGaugeShineImageAdjustRt;

	[SerializeField]
	private RectTransform hpGaugeShineIconRt;

	[SerializeField]
	private RectTransform unlimitIconRt;

	[SerializeField]
	private SpriteRenderer elementIconImage;

	[SerializeField]
	private SpriteRenderer bgHpRtModSprite;

	[SerializeField]
	private SpriteRenderer bgBreakModSprite;

	[SerializeField]
	private SpriteRenderer breakGaugeIcon;

	[SerializeField]
	private SpriteRenderer hpGaugeShineBgImage;

	[SerializeField]
	private SpriteRenderer hpGaugeShineGaugeImage;

	[SerializeField]
	private SpriteRenderer hpGaugeShineIconImage;

	[SerializeField]
	private BossStatusInfoUI statusInfoUI;

	[SerializeField]
	private RectTransform gaugeEffectRt;

	[SerializeField]
	private RectTransform raidEffectRt;

	[SerializeField]
	private float hpGaugeShineAdjustStartPosX;

	[SerializeField]
	private float hpGaugeShineAdjustEndPosX;

	private EnemyCharacter _owner;

	private VisibleUIObject rootVisible;

	private VisibleUIObject breakGaugeVisible;

	private VisibleUIObject breakGaugeIconVisible;

	private VisibleUIObject hpGaugeShineRootVisible;

	private VisibleUIObject hpGaugeShineSubRootVisible;

	private CharaCircleGaugeMiasmaUI miasmaGaugeUI;

	private InGameFollowLayout followLayout;

	private Sequence seqGaugeMove;

	private Sequence seqGaugeMod;

	private Sequence seqHpGaugeShineIcon;

	private int lastFishGrade;

	private int lastInfoIconType;

	private bool isChangeOwner;

	private Dictionary<int, bool> enableIronWallDict;

	private EnemyCharacter owner
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static BossBreakUI Create(GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize()
	{
	}

	private void OnDestroy()
	{
	}

	public override void FastUpdate()
	{
	}

	public void UpdateHpGaugeShine()
	{
	}

	public void Open(CharacterBase chara, string name, bool hasBreak, float initialHpValue, InGameEventExtendAtlasManager eeAtlasManager)
	{
	}

	private void OpenBreakGauge(float rate)
	{
	}

	public void Close()
	{
	}

	public bool IsVisible()
	{
		return default(bool);
	}

	public void SetHPValue(float value)
	{
	}

	public void SetBreakValue(float value, bool immediate = false)
	{
	}

	public void GetRaidEffectPosition(ref Vector3 pos)
	{
	}

	public void GetGaugeEffectPosition(ref Vector3 pos)
	{
	}

	public InGameGaugeUISpriteRenderer GetBreakGauge()
	{
		return null;
	}

	public void OnStatusInfoUIChangePage()
	{
	}

	public CharaCircleGaugeMiasmaUI CreateBossMiasmaGaugeUI(CharacterBase boss)
	{
		return null;
	}

	private void ApplyInfoIcon(CharacterBase chara, bool isForce = false)
	{
	}

	private bool ApplyElementIcon(ElementalType elementType, bool isForce = false)
	{
		return default(bool);
	}

	private bool ApplyTribeIcon(TribeType tribeType, bool isForce = false)
	{
		return default(bool);
	}

	public void PlayQuestEffectBreak(float durationTime)
	{
	}

	private void PlayQuestEffectBreakGauge(bool playFromBeginning = true)
	{
	}

	public void StopQuestEffectBreak()
	{
	}

	private void StopQuestEffectBreakGauge(bool isImmediate = false)
	{
	}

	public void PlayQuestEffectOverdrive()
	{
	}

	private void PlayQuestEffectOverdriveGauge(bool playFromBeginning = true)
	{
	}

	public void StopQuestEffectOverdrive()
	{
	}

	private void StopQuestEffectOverdriveGauge(bool isImmediate = false)
	{
	}

	public void PlayQuestEffectBerserk()
	{
	}

	public void StopQuestEffectBerserk()
	{
	}

	public void PlayQuestEffectRaidFishGrade(int grade, [Optional] Action<PlayFTU> endFunc)
	{
	}

	public void StopQuestEffectRaidFishGrade()
	{
	}

	private void StopQuestEffectGauge(PlayFTU.Type type, bool isImmediate)
	{
	}

	public void OnUpdateHpGaugeShineBgFade(float value)
	{
	}

	public void OnUpdateHpGaugeShineGaugeFade(float value)
	{
	}

	public void OnUpdateHpGaugeShineLocalPosX(float value)
	{
	}
}
