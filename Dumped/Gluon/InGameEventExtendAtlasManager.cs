using System;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class InGameEventExtendAtlasManager : FastUpdateMonoBehaviour
{
	[Serializable]
	public class BossPartGaugeUIIconData
	{
		public int type;

		public Sprite sprite;
	}

	[SerializeField]
	private Material _atlasMaterial;

	[SerializeField]
	private Sprite _bossGaugeUIBreakGaugeIconSprite;

	[SerializeField]
	private BossPartGaugeUIIconData[] _bossPartGaugeUIIconDataList;

	[SerializeField]
	private Sprite[] _questSkillButtonIconSpriteList;

	[SerializeField]
	private Sprite[] _questSkillButtonBGSpriteList;

	public static InGameEventExtendAtlasManager Create(InGameUIConst.DecorationType type)
	{
		return null;
	}

	public bool GetAtlasMaterial(out Material material)
	{
		return default(bool);
	}

	public bool GetBossGaugeUIBreakGaugeIconSprite(out Material material, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetBossGaugeUIBreakGaugeIconSprite(out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetBossPartGaugeUIIconSprite(int type, out Material material, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetBossPartGaugeUIIconSprite(int type, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetQuestSkillButtonIconSprite(int index, out Material material, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetQuestSkillButtonIconSprite(int index, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetQuestSkillButtonBGSprite(out Material material, int index, out Sprite sprite)
	{
		return default(bool);
	}

	public bool GetQuestSkillButtonBGSprite(int index, out Sprite sprite)
	{
		return default(bool);
	}
}
