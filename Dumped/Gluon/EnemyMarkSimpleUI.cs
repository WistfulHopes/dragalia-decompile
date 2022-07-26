using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon;

public class EnemyMarkSimpleUI : CharacterMarkUI
{
	protected InGameUICtrl inGameUI;

	private EnemyCharacter _owner;

	protected RectTransform rootRt;

	protected CharaCircleGaugeUI circleGaugeUI;

	protected VesselBombUI vesselBombUI;

	protected EnemyAbilityHeadIconUI enemyAbilityHeadIconUI;

	protected int lastInfoIconType;

	protected const float circleGaugeOffsetY = 55f;

	protected EnemyCharacter owner
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float correctPosY
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public virtual void Initialize(EnemyCharacter enemy, InGameUICtrl inGameUI)
	{
	}

	protected virtual void OnDestroy()
	{
	}

	private void LateUpdate()
	{
	}

	public override void UpdatePosition(bool interpolation = true)
	{
	}

	public override void SetVisible(bool visible)
	{
	}

	public override bool IsVisible()
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

	public override void SetCircleGaugeUIAdjustPos(CharaCircleGaugeUI.Type type, Vector3 pos)
	{
	}

	public override void SetCircleGaugeUIAdjustScale(CharaCircleGaugeUI.Type type, float scale)
	{
	}

	public override bool IsVisibleCircleGauge()
	{
		return default(bool);
	}

	public override VesselBombUI CreateVesselBombUI()
	{
		return null;
	}

	public override EnemyAbilityHeadIconUI CreateEnemyAbilityHeadIconUI()
	{
		return null;
	}

	public override void ShowEnemyAbilityHeadIconUI(string iconName)
	{
	}

	public override void HideEnemyAbilityHeadIconUI()
	{
	}
}
