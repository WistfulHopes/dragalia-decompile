using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class InGamePartyButtonUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform rootRt;

	[SerializeField]
	private RectTransform rebornRootRt;

	[SerializeField]
	private RectTransform rebornIconRt;

	[SerializeField]
	private RectTransform unlimitRebornIconRt;

	[SerializeField]
	private RectTransform rebornTimeRt;

	[SerializeField]
	private Button button;

	[SerializeField]
	private ElementIconUISpriteRenderer element;

	[SerializeField]
	private InGameGaugeUISpriteRenderer hpGauge;

	[SerializeField]
	private InGameGaugeUISpriteRenderer timeGauge;

	[SerializeField]
	private InGameGaugeUISpriteRenderer shieldGauge;

	[SerializeField]
	private SpriteRenderer playerNoImage;

	[SerializeField]
	private SpriteRenderer frameImage;

	[SerializeField]
	private PlayerBuffUI playerBuffUI;

	[SerializeField]
	private SpriteRenderer faceImage;

	[SerializeField]
	private SpriteRenderer monoFaceImage;

	[SerializeField]
	private SpriteRenderer servitorFaceImage;

	[SerializeField]
	private SpriteRenderer rebornTimeImage;

	[SerializeField]
	private Text rebornCountText;

	[SerializeField]
	private InGameRemainLifeIconCtrl remainLifeIconCtrl;

	[SerializeField]
	private Sprite[] playerNoIcon;

	[SerializeField]
	private Sprite[] numberSprites;

	[SerializeField]
	private Material colorAdjustMaterial;

	[SerializeField]
	private float dispBuffSec;

	[SerializeField]
	private float monochromeSaturation;

	[SerializeField]
	private float monochromeBrightness;

	[SerializeField]
	private float rebornIconMerginX;

	private bool isDying;

	[SerializeField]
	private Color dyingColorMax;

	[SerializeField]
	private Color dyingColorMin;

	private bool isActive;

	private bool isAlive;

	private int propertySaturation;

	private int propertyBrightness;

	private CharacterSelector csDragon;

	private VisibleUIObject rebornRootVisible;

	private VisibleUIObject rebornTimeVisible;

	private List<RebornLifeIconUI> rebornIconList;

	private bool isUpdateRebornTimer;

	private int charaRemainLifeNum;

	[HideInInspector]
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

	[HideInInspector]
	public int playerNo
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

	[HideInInspector]
	public MoveControlUI moveControl
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public CharacterBase owner
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Initialize(Action<CharacterBase, int> onClick, int idx, float scaleFactor, bool isUnlimitReborn, int rebornNum)
	{
	}

	public override void FastUpdate()
	{
	}

	private void UpdateCharaRemainLife(bool isForce = false)
	{
	}

	public void SetHPGauge(bool immediate)
	{
	}

	public void SetTimeGauge(DragonCharacter dragon, float value, bool immediate)
	{
	}

	public void SetShieldGauge(bool immediate)
	{
	}

	public void SetImage(CharacterBase chara, Material face, Material faceMono, Sprite sprite, Sprite spriteMono)
	{
	}

	public void SetServitorImage(Material face, Sprite sprite)
	{
	}

	private void ChangeImage(bool alive)
	{
	}

	public bool IsActive()
	{
		return default(bool);
	}

	public void Active(bool b)
	{
	}

	public Vector2 GetButtonPosition()
	{
		return default(Vector2);
	}

	public void SetPlayerNo(int no)
	{
	}

	public Sprite GetPlayerNoImage(int no)
	{
		return null;
	}

	private static int GetSign(float rate)
	{
		return default(int);
	}

	public void SetEnableButton(bool isEnable)
	{
	}

	public void SetEnableRebornIcon(bool isUnlimitReborn, int enableCount)
	{
	}

	public void SetEnableRebornIconOtherPlayer(int playerNo, bool isUnlimitReborn, int rebornNum)
	{
	}

	public void SetVisibleRebornIcon(int enableCount)
	{
	}

	public void SetRebornTime(float elapsed, float duration)
	{
	}

	public int GetVisibleRebornIconNum()
	{
		return default(int);
	}

	public int GetEnablelRebornIconNum()
	{
		return default(int);
	}

	private bool IsShowRebornCountUI()
	{
		return default(bool);
	}
}
