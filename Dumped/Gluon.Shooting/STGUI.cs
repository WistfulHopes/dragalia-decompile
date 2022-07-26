using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon.Shooting;

public class STGUI : MonoBehaviour
{
	[SerializeField]
	public Image topFade;

	[SerializeField]
	public Transform uiScrollTarget;

	public DragEventScrollRect dragEventScrollRect;

	[SerializeField]
	public RectTransform gameRect;

	[NonSerialized]
	public Canvas canvas;

	[SerializeField]
	public Image[] lifeHearts;

	public Text shootLevelText;

	public Color initFadeColor;

	[SerializeField]
	public GameObject hiScoreMark;

	[SerializeField]
	public Button pauseButton;

	public STGPausePU pausePU;

	[SerializeField]
	public Sprite[] numbers;

	public Image[] digits;

	[SerializeField]
	public GameObject levelUpGO;

	public CanvasGroup levelUpCanvasGroup;

	[SerializeField]
	public GameObject bossAppearGO;

	public Text dragonName;

	public Text dragonLevel;

	public GameObject[] trueMidHideGOs;

	public Animator bossAppearAnimator;

	[SerializeField]
	public GameObject dropHeartHeart;

	public CanvasGroup dropHeartCanvasGroup;

	[SerializeField]
	public UIAnimationPublisher enterPublisher;

	[SerializeField]
	public GameObject gaugeGO;

	public GameObject gaugeIndicator;

	public CommonSlider slider;

	[SerializeField]
	public GameObject bombGO;

	public CanvasGroup bombCanvasGroup;

	public Button bombButton;

	public GameObject logoGO;

	public CanvasGroup logoCanvasGroup;

	public GameObject[] marker;

	public CanvasGroup[] markerCanvasGroup;

	private bool isInBombAnimation;

	[NonSerialized]
	public bool isInPause;

	private int[] bossDisplayLevel;

	private int[] bossIds;

	private float savedTimeScale;

	private Coroutine waitBossAppearCoroutine;

	private List<Sequence> runningSequences;

	private Vector2 curInputPos;

	private int displayLevel;

	private Enemy watchEnemy;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void DoInitFadeIn()
	{
	}

	public void BlackOut(float boTime)
	{
	}

	public void Restart(bool fromMenu = false)
	{
	}

	public void UpdateInputPos()
	{
	}

	public Vector3 GetInputPos()
	{
		return default(Vector3);
	}

	public bool IsAnyFingerPressed()
	{
		return default(bool);
	}

	public void ShowIndi()
	{
	}

	private void SetBackKey(UnityAction action)
	{
	}

	private void SetBackKeyAsEvent(UnityEvent backKeyEvent)
	{
	}

	public void EnableBomb()
	{
	}

	public void OnBombButton()
	{
	}

	public void ShowSlider(float bossHp, float expandTime, float slideTime)
	{
	}

	public void ShowBossInfo(float bossHp, int level)
	{
	}

	private void ShowBossAppear()
	{
	}

	private IEnumerator WaitBossAppearDone()
	{
		return null;
	}

	public void UpdateScore(int score)
	{
	}

	public void UpdateWatch()
	{
	}

	public void ShowMarker(int index)
	{
	}

	public void ShowLogo()
	{
	}

	public void CloseSlider()
	{
	}

	public void UpdateBossGauge(float bossHp, float maxHp)
	{
	}

	public void SetLifeVal(int life, int recoverCount)
	{
	}

	public void PlayDropLife(int pos)
	{
	}

	public void ShowLevelUp()
	{
	}

	public void SetShootLevel(int level)
	{
	}

	private void Update()
	{
	}

	public void OnPause()
	{
	}

	protected void OnApplicationPause(bool pause)
	{
	}

	private void CreatePause()
	{
	}

	public void SetSliderWatch(Enemy enemy)
	{
	}

	public void QuitShooting()
	{
	}

	public void CreateGameOverFlow()
	{
	}
}
