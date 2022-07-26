using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon;

public class QuestSelectWheel : MonoBehaviour
{
	private class PosElement : IComparable<PosElement>
	{
		public Vector3 pos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int index
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public QuestSelectWheelElement.WheelChapterSize chapterSize
		{
			[CompilerGenerated]
			get
			{
				return default(QuestSelectWheelElement.WheelChapterSize);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PosElement(Vector3 a_pos, int a_index)
		{
		}

		public int CompareTo(PosElement a_posElement)
		{
			return default(int);
		}
	}

	[Serializable]
	public class NewChapterActionTime
	{
		public float dropCellDelayTime;

		public float titleDelayTime;

		public float bgDelayTime;

		public float otherCellDelayTime;

		public float endDelayTime;
	}

	[SerializeField]
	private Canvas selfCanvas;

	[SerializeField]
	private GameObject orgWheelElement;

	[SerializeField]
	public Button chapterWheelOverAllButton;

	[SerializeField]
	public Button uiChapterLeftButton;

	[SerializeField]
	public Button uiChapterRightButton;

	[SerializeField]
	public Text uiChapterNumberText;

	[SerializeField]
	public Text uiChapterTitleText;

	[SerializeField]
	private GameObject wheel;

	[SerializeField]
	private Image lightImage;

	[SerializeField]
	private Image uiChapterTitlelineImage;

	[SerializeField]
	private Image uiChapterTitleBgImage;

	[SerializeField]
	public GameObject chapterTitleRoot;

	[SerializeField]
	private Image uiBgLayer;

	[SerializeField]
	private CanvasGroup uiArrowCanvasGroup;

	private List<QSChapterElement> chapterList;

	private RectTransform canvasRect;

	private bool touchInCanvas;

	private bool touchFlick;

	private bool touchDrag;

	private bool touchSwipe;

	private QuestSelectWheelElement[] chapterArray;

	private QuestSelectWheelElement[] chapterArrayOrg;

	private int chapterNum;

	private List<QuestMainGroupElement> questGroupList;

	private int maxChapter;

	[SerializeField]
	private float elementsScele;

	[SerializeField]
	private float chapterRot1;

	private const float wheelScale = 0.9f;

	private float rot;

	[SerializeField]
	private float rotSpeedFirstConst;

	[SerializeField]
	private float miniFirstSpeed;

	[SerializeField]
	private float swipeSpeed;

	[SerializeField]
	private float breakSpeedOneConst;

	[SerializeField]
	private float breakSpeedSecondConst;

	[SerializeField]
	private float reverseSpeedConst;

	[SerializeField]
	private float breakSpeed;

	[SerializeField]
	private float rotSpeed;

	private bool initialized;

	private float beginRot;

	private float endRot;

	private float wheelWidth;

	private float firstTouchRot;

	private Vector3 firstTouchPos;

	private QuestSelectWheelElement touchTopWheelElement;

	private QuestSelectWheelElement topWheelElement;

	private QuestSelectWheelElement orgWheelElementObj;

	private int _lastSelectedChapterNumber;

	private bool isFirstTop;

	[SerializeField]
	private float inWorldMapElementBaseY;

	[SerializeField]
	private float inWorldMapElementdelay;

	private CanvasGroup myCanvasGroup;

	public UnityAction<int, QuestSelectWheelElement> onClickWheel;

	private Vector2 defaultChapterNumberPos;

	private Vector2 defaultChapterTitlePos;

	private float openMoveDistance;

	private float closeMoveDistance;

	private Vector2 lineWidth;

	private bool isPlayingChapterScrollByArrowButton;

	public bool isWheel;

	public bool isWheelScrollEnabled;

	[SerializeField]
	public NewChapterActionTime newChapterDelayTime;

	public float jump;

	public float bounce;

	public float jumpTime;

	public float frameTime;

	public float bounceTime;

	public QuestSelectScene sceneObj
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float ElementsScale => default(float);

	public int lastSelectedChapterNumber => default(int);

	private void Clear()
	{
	}

	public void Initialize()
	{
	}

	public IEnumerator InitializeWheelElements()
	{
		return null;
	}

	private void InitializeQuestGroupList()
	{
	}

	private void Update()
	{
	}

	public void ResetWheel()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public void OnClickMainQuestChapter(QuestSelectWheelChapter clickedChapter)
	{
	}

	public void PlayAreaMapWheelAnim([Optional] UnityAction action)
	{
	}

	public void PlayNewChapterWheelAnimationTop()
	{
	}

	public void PlayNewChapterWheelAnimation([Optional] UnityAction action)
	{
	}

	public void PlayWorldMapWheelAnim([Optional] UnityAction action)
	{
	}

	public void ExitWorldMapWheelAnim([Optional] UnityAction action)
	{
	}

	private void SetTextAlpha(float alpha)
	{
	}

	public void OpenChapterTitle()
	{
	}

	public void CloseChapterTitle()
	{
	}

	private void AnimChapterTitle(bool isBackwards)
	{
	}

	public Sequence NewAnimChapterTitle()
	{
		return null;
	}

	private Sequence NewChapterLightFunction()
	{
		return null;
	}

	private Sequence NewChapterLineFunction()
	{
		return null;
	}

	private Sequence NewChapterNumberTextFunction()
	{
		return null;
	}

	private Sequence NewChapterTitleTextFunction()
	{
		return null;
	}

	public void SetChapterList(List<QSChapterElement> a_chapterList)
	{
	}

	public int CheckMaxChapter()
	{
		return default(int);
	}

	public void SetRotationByChapter(int topChapter, bool isPlaySound = true)
	{
	}

	private void SetRotation(float rot, bool isPlaySound = true)
	{
	}

	public void UpdateAllAchievementLevels()
	{
	}

	public void DisplayChapterNumberAndTitle()
	{
	}

	public void DisplayChapterNumberAndTitleFromMaster(QuestMainGroupElement qmge)
	{
	}

	public QuestSelectWheelElement GetTopChapterElement()
	{
		return null;
	}

	private Vector3 GetNowPoint()
	{
		return default(Vector3);
	}

	public void OnClickChapterLeft()
	{
	}

	public void OnClickChapterRight()
	{
	}

	public void LeftRightArrowsEnable(bool enable)
	{
	}

	public Tweener LeftRightArrowFadeIn(float endValue, float duration)
	{
		return null;
	}

	public void OnClickDifficulty()
	{
	}

	private bool IsDown()
	{
		return default(bool);
	}

	private bool IsFlickLeft()
	{
		return default(bool);
	}

	private bool IsFlickRight()
	{
		return default(bool);
	}

	private bool IsUp()
	{
		return default(bool);
	}

	private bool IsDrag()
	{
		return default(bool);
	}

	private bool IsPress()
	{
		return default(bool);
	}

	private bool IsTouchGuard()
	{
		return default(bool);
	}

	public void StartEnterAnimation()
	{
	}

	public void StartExitAnimation()
	{
	}

	public void NewChapterAnimation()
	{
	}

	public void NewChapterrAnimationTop()
	{
	}

	public void CanvasEnable(float alpha)
	{
	}

	public void SetBgLayerWidth(float width)
	{
	}
}
