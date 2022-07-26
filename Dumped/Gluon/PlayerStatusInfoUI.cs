using System.Collections.Generic;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class PlayerStatusInfoUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	protected RectTransform _infoRt;

	[SerializeField]
	protected int _horizontalIconNum;

	[SerializeField]
	protected int _verticalIconNum;

	protected CharacterBase _character;

	protected int _pageIndex;

	protected int _pageMax;

	protected float _listCollectInterval;

	protected List<CharaStatusInfoUI> _infoList;

	protected List<CharacterBuffCoolDownController.CoolDownData> _workCoolDownList;

	protected List<CharacterAuraCtrl.Parameter> _workSelfAuraList;

	protected List<CharacterAuraCtrl.Parameter> _workPartyAuraList;

	protected static GameObject _originStatusInfoUI;

	public const float ListCollectIntervalTime = 1f / 6f;

	protected int PageIconNum => default(int);

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	public void SetCharacter(CharacterBase chara)
	{
	}

	public override void FastUpdate()
	{
	}

	public void OnChangePage()
	{
	}

	protected virtual void CollectStatusInfo()
	{
	}

	protected void CollectStatusInfoByEnemyAbility(EnemyCharacter enemy, int startIndex, int endIndex, ref int index, ref int uiIndex)
	{
	}

	protected int GetDisplayStartIndex()
	{
		return default(int);
	}

	protected int GetDisplayEndIndex()
	{
		return default(int);
	}

	protected void SetPageIndex(int num)
	{
	}

	protected bool CheckDispRange(int startIndex, int endIndex, int index)
	{
		return default(bool);
	}

	protected virtual CharaStatusInfoUI CreateStatusInfoUI()
	{
		return null;
	}

	protected CharaStatusInfoUI GetStatusInfoUI()
	{
		return null;
	}

	protected CharaStatusInfoUI GetStatusInfoUI(int buffIconId, int productId)
	{
		return null;
	}

	protected CharaStatusInfoUI GetStatusInfoUI(AbnormalStatusType type)
	{
		return null;
	}

	protected CharaStatusInfoUI GetStatusInfoUI(EnemyAbilityType type)
	{
		return null;
	}

	protected CharaStatusInfoUI GetStatusInfoUI(AuraConst.TargetType targetType, AuraType type, int productId)
	{
		return null;
	}

	public void OnUpdateBlinkAnim(float value)
	{
	}
}
