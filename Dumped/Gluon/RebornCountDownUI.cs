using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class RebornCountDownUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _bgRt;

	[SerializeField]
	private RectTransform _iconRt;

	[SerializeField]
	private SpriteRenderer _timeImage;

	[SerializeField]
	private SpriteRenderer _unlimitAddIconImage;

	[SerializeField]
	private CircleGauge _gaugeCtrl;

	[SerializeField]
	private Sprite[] _numberSprites;

	[SerializeField]
	private float _iconMerginX;

	private VisibleUIObject _rootVisible;

	private List<RebornLifeIconUI> _iconList;

	private Sequence _seqAnim;

	private Tweener _twUnlimitAddIconAnim;

	private int lastTimeImageIndex;

	private const int TIME_MAX_NUM = 9;

	public bool IsPlaying
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsVisible
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static RebornCountDownUI Create(GameObject parent, bool isUnlimitReborn, int rebornNum, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize(GameObject lifePobj, bool isUnlimitReborn, int rebornNum)
	{
	}

	private void OnDestroy()
	{
	}

	public override void FastUpdate()
	{
	}

	public void Show(int restRebornCount, int consumeRebornCount)
	{
	}

	public void Hide()
	{
	}

	public void SetVisible(bool visible)
	{
	}

	public void SetTime(float elapsed, float duration)
	{
	}

	private void PlayShow()
	{
	}

	private void PlayHide()
	{
	}

	private void PlayIconBlink(int restRebornCount, int consumeRebornCount)
	{
	}

	private void PlayUnlimitAddIconBlink()
	{
	}

	private void OnUpdateUnlimitAddIconBlink(float fade)
	{
	}

	private void SetFade(SpriteRenderer obj, float fade)
	{
	}

	public static void SetEnableIcon(ref List<RebornLifeIconUI> list, int enableCount)
	{
	}

	public static void SetVisibleIcon(ref List<RebornLifeIconUI> list, int enableCount)
	{
	}

	public static void SetFade(ref List<RebornLifeIconUI> list, float fade)
	{
	}

	public static int GetTimeToImageIndex(float time)
	{
		return default(int);
	}

	public static int GetPartyCharaRebornNum(int rebornNum, int partyCharaNum, int partyIndex)
	{
		return default(int);
	}
}
