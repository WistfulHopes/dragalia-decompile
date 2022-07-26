using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class HumanMarkUI : CharacterMarkUI
{
	[SerializeField]
	private RectTransform conditionRootRt;

	[SerializeField]
	private RectTransform conditionRt;

	[SerializeField]
	private RectTransform markRt;

	[SerializeField]
	private RectTransform gaugeRt;

	[SerializeField]
	private RectTransform nameRt;

	[SerializeField]
	private RectTransform iconRt;

	[SerializeField]
	private RectTransform levelAnimRt;

	[SerializeField]
	private SpriteRenderer markImage;

	[SerializeField]
	private SpriteRenderer iconImage;

	[SerializeField]
	private Text nameText;

	[SerializeField]
	private InGameGaugeUISpriteRenderer gauge;

	[SerializeField]
	private InGameCounterUI levelCounter;

	[SerializeField]
	private InGameAnimUI levelNumberAnim;

	[SerializeField]
	private InGameAnimUI levelBgAnim;

	[SerializeField]
	private Sprite[] marks;

	[SerializeField]
	private Vector3 namePositionBR;

	[SerializeField]
	private Vector3 markPositionBR;

	[SerializeField]
	private Vector3 gaugePositionBR;

	[SerializeField]
	private float correctPosY;

	[SerializeField]
	public float durationPlayerMarkHP;

	[SerializeField]
	public float iconAdjustPosX;

	[SerializeField]
	public float iconMinAdjustPosX;

	private InGameUICtrl inGameUI;

	private HumanCharacter owner;

	private RectTransform rootRt;

	private VisibleUIObject rootRtVisible;

	private VisibleUIObject conditionRootRtVisible;

	private VisibleUIObject conditionRtVisible;

	private VisibleUIObject nameRtVisible;

	private VisibleUIObject iconRtVisible;

	private VisibleUIObject levelAnimRtVisible;

	private Sequence seqMark;

	private SandTimerUI sandTimerUI;

	private Dictionary<CharaCircleGaugeUI.Type, CharaCircleGaugeUI> circleGaugeDic;

	private Vector3 iconOriginalPos;

	private DisplayType currentType;

	private float displayDuration;

	private float moveDuration;

	private bool isOwner;

	private Vector2 moveSposS;

	private Vector2 moveSposE;

	private Vector2 prevSpos;

	private const float SandTimerOffsetY = 33f;

	private const float SandTimerMarkAdjustY = 40f;

	private const float CircleGaugeOffsetY = 50f;

	private const float CircleGaugeMarkAdjustY = 82f;

	private const float MoveUpdateDuration = 2f / 15f;

	public void Initialize(HumanCharacter human, InGameUICtrl inGameUI)
	{
	}

	private void OnDestroy()
	{
	}

	private void _Destroy(MonoBehaviour obj)
	{
	}

	private void _Destroy(Transform obj)
	{
	}

	private void LateUpdate()
	{
	}

	private CharacterBase GetCurrentPlayerCharacter()
	{
		return null;
	}

	private void UpdatePlayer()
	{
	}

	private void UpdateIcon(bool isDisplay)
	{
	}

	public override void UpdatePosition(bool interpolation = true)
	{
	}

	private Vector2 GetEasePos(Vector2 startPos, Vector2 endPos, float time, float duration)
	{
		return default(Vector2);
	}

	private Vector2 GetScreenPos(CharacterBase chara)
	{
		return default(Vector2);
	}

	private void InvisibleAll()
	{
	}

	private void InvisibleGauge()
	{
	}

	public override void Show(DisplayType type, [Optional] CharacterBase target)
	{
	}

	private void Show(DisplayType type)
	{
	}

	private void PlayerHPRoutine()
	{
	}

	public override void SetPlayerNo(int no, bool own)
	{
	}

	public override void SetVisible(bool visible)
	{
	}

	public override bool IsVisible()
	{
		return default(bool);
	}

	public void CreateSandTimerUI()
	{
	}

	public void ShowSandTimerUI()
	{
	}

	public void HideSandTimerUI()
	{
	}

	public void SetSandTimerUICount(int count)
	{
	}

	public void SetSandTimerUICountColor(SandTimerUI.CountColorType type)
	{
	}

	private bool IsSandTimerUICountDown()
	{
		return default(bool);
	}

	public override void CreateCircleGaugeUI(CharaCircleGaugeUI.Type type)
	{
	}

	public override void ShowCircleGaugeUI(CharaCircleGaugeUI.Type type)
	{
	}

	public override void HideCircleGaugeUI(CharaCircleGaugeUI.Type type)
	{
	}

	public override void SetCircleGaugeUIGaugeTimer(CharaCircleGaugeUI.Type type, float time, float initialTime)
	{
	}

	public override void SetCircleGaugeUICount(CharaCircleGaugeUI.Type type, int count)
	{
	}
}
