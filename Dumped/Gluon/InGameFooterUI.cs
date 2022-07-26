using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon;

public class InGameFooterUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private Button changePlayerButton;

	[SerializeField]
	private InGameGaugeUISpriteRenderer hpGauge;

	[SerializeField]
	private InGameGaugeUISpriteRenderer timeGauge;

	[SerializeField]
	private InGameGaugeUISpriteRenderer shieldGauge;

	[SerializeField]
	private ElementIconUISpriteRenderer element;

	[SerializeField]
	public RectTransform[] skillRt;

	[SerializeField]
	public RectTransform skillRefPointRt;

	[SerializeField]
	public RectTransform supportSkillRt;

	[SerializeField]
	public RectTransform stampRt;

	[SerializeField]
	public RectTransform questSkillRt;

	[SerializeField]
	public RectTransform modeSelectRt;

	[SerializeField]
	public RectTransform dragonRt;

	[SerializeField]
	private RectTransform bgRt;

	[SerializeField]
	private RectTransform rebornIconRt;

	[SerializeField]
	private RectTransform unlimitRebornIconRt;

	[SerializeField]
	public RectTransform inversionMoveRt;

	[SerializeField]
	public RectTransform hpTextRt;

	[SerializeField]
	public RectTransform charaLevelRt;

	[SerializeField]
	public Text charaLevelText;

	[SerializeField]
	private Color skillBackColor;

	[SerializeField]
	private SpriteRenderer[] hpNumberSpriteRenderer;

	[SerializeField]
	private RectTransform rotRt;

	[SerializeField]
	private RotZControlUI rotMark;

	[SerializeField]
	private PlayerStatusInfoUI statusInfoUI;

	[SerializeField]
	private InGameRemainLifeIconCtrl remainLifeIconCtrl;

	[SerializeField]
	private float rotTime;

	[SerializeField]
	private float rebornIconMerginX;

	[SerializeField]
	private float rebornStartAnimWait;

	[SerializeField]
	private Sprite[] hpNumberSprite;

	private bool isDragon;

	private CharacterBase owner;

	private CharacterSelector csDragon;

	private Material currentMaterial;

	private Material currentDamageMaterial;

	private Material humanMaterial;

	private Material dragonMaterial;

	private PlayFTU ftu;

	private PlayFTU.Type ftuType;

	private List<PlayFTU.MaterialInfo> ftuMaterial;

	private List<RebornLifeIconUI> rebornIconList;

	private bool isLeft;

	private float moveDirection;

	private float moveDistance;

	private float screenAdjustScale;

	private int charaRemainLifeNum;

	private const int FtuMaterialNum = 2;

	public static InGameFooterUI Create(GameObject parent, int siblingIndex, UnityAction onClick, bool isLeft, bool isUnlimitReborn, int rebornNum)
	{
		return null;
	}

	private void Initialize(UnityAction onClick, bool isLeft, bool isUnlimitReborn, int rebornNum)
	{
	}

	public override void FastUpdate()
	{
	}

	private void UpdatePos()
	{
	}

	private void UpdateCharaRemainLife(bool isForce = false)
	{
	}

	public void Active(bool b)
	{
	}

	public void ApplyCharacter(CharacterBase chara, bool isSelected, bool isForce = false)
	{
	}

	private void SetupHpInfoOnly(CharacterBase chara, bool immediate = false)
	{
	}

	private void SetupDpInfoOnly(DragonCharacter dragon, bool immediate = false)
	{
	}

	public void SetHPGauge(CharacterBase chara, bool immediate)
	{
	}

	public void SetTimeGauge(DragonCharacter dragon, float value, bool immediate)
	{
	}

	public void SetShieldGauge(CharacterBase chara, bool immediate)
	{
	}

	public void SetFTU(PlayFTU ftu, PlayFTU.Type ftuType)
	{
	}

	public void VisibleFTU(bool v)
	{
	}

	public void ActiveFTU(bool isActive)
	{
	}

	public void PauseFTU()
	{
	}

	public void DamageFTU()
	{
	}

	private void RotateMark()
	{
	}

	public void VisibleRotateMark(bool v)
	{
	}

	private void SetHpNumber(bool visible, int hp)
	{
	}

	public void SetLevelText(int level)
	{
	}

	public void AdjustSkillButtonPosition()
	{
	}

	public void OnStatusInfoUIChangePage()
	{
	}

	public void SetEnableRebornIcon(int enableCount)
	{
	}

	public void SetVisibleRebornIcon(int enableCount)
	{
	}

	public void PlayRebornShowAnim()
	{
	}

	public void PlayRebornConsumeAnim(int index, [Optional] Action onComplete)
	{
	}

	public void OnUpdateBlinkAnim(float value)
	{
	}
}
