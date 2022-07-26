using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class VesselBombUI : FastUpdateMonoBehaviour
{
	private enum State
	{
		Count,
		CoolTime
	}

	private class SmokeImageInitData
	{
		private SpriteRenderer smokeImage;

		public Vector3 pos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 scale
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Setup(SpriteRenderer image)
		{
		}

		public void Reset()
		{
		}
	}

	[SerializeField]
	private RectTransform adjustRt;

	[SerializeField]
	private RectTransform effectRt;

	[SerializeField]
	private RectTransform effectAnimRt;

	[SerializeField]
	private RectTransform coolTimeRt;

	[SerializeField]
	private RectTransform smokeRt;

	[SerializeField]
	private SpriteRenderer effectImage;

	[SerializeField]
	private SpriteRenderer[] smokeImageList;

	[SerializeField]
	private Text countText;

	[SerializeField]
	private CircleGauge gaugeCtrl;

	[SerializeField]
	private float countTextColorThreshold;

	[SerializeField]
	private Color[] countTextColorList;

	[SerializeField]
	private Color lowCountTextColor;

	[SerializeField]
	private float finishAnimWaitTime;

	[SerializeField]
	private Sprite[] effectSpriteList;

	private SmokeImageInitData[] smokeImageInitDataList;

	private VisibleUIObject rootVisible;

	private State state;

	private CharacterBase owner;

	private CharacterMarkUI markUI;

	private Sequence seqFinishAnim;

	private float countDispRemainTime;

	private int maxCount;

	private ExtraBuffType effectType;

	private Color currCountTextColor;

	private float maxCoolTime;

	private static int createCount;

	public int count
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float coolTime
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool isVisible
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

	public int index
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static VesselBombUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize(int index, CharacterBase owner, CharacterMarkUI markUI)
	{
	}

	private void OnDestroy()
	{
	}

	public override void FastUpdate()
	{
	}

	public void Show()
	{
	}

	public void Hide(bool isReset = false)
	{
	}

	public bool SetCount(int count, int maxCount, bool isForce = false, bool isShow = true)
	{
		return default(bool);
	}

	public void SetEffectType(ExtraBuffType type, bool isForce = false)
	{
	}

	public bool SetCoolTime(float time, float maxTime, bool isForce = false, bool isShow = true)
	{
		return default(bool);
	}

	private bool IsShow()
	{
		return default(bool);
	}

	private bool IsParentVisible()
	{
		return default(bool);
	}

	private void PlayFinishAnim()
	{
	}

	public static void ResetCreateCount()
	{
	}
}
