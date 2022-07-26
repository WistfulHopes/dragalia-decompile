using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class StrategyDialog2 : StrategyDialogBase
{
	[SerializeField]
	private Text dpointText;

	[SerializeField]
	private Text dpointRareText;

	[SerializeField]
	private Text charaLevelText;

	[SerializeField]
	private Text charaExpText;

	[SerializeField]
	private Text charaHpText;

	[SerializeField]
	private Text charaAtkText;

	[SerializeField]
	private Text servitoLevelText;

	[SerializeField]
	private Text servitorHpText;

	[SerializeField]
	private Text servitorAtkText;

	[SerializeField]
	private Image charaIconImage;

	[SerializeField]
	private Image servitorIconImage;

	[SerializeField]
	private Slider charaExpGauge;

	[SerializeField]
	private Toggle announceStar5Toggle;

	[SerializeField]
	private Toggle announceStar4Toggle;

	[SerializeField]
	private Toggle announceStar3Toggle;

	[SerializeField]
	private Toggle announceSkillToggle;

	[SerializeField]
	private Text lifeCountText;

	[SerializeField]
	private int maxLevelTextSize;

	private int charaId;

	private int servitorId;

	private DmodeActiveAbilityListPopup abilityPU;

	public static StrategyDialog2 Create(GameObject parent)
	{
		return null;
	}

	protected override void Initialize()
	{
	}

	public override void Open()
	{
	}

	public static void ApplyToggleCheckMark(ref Toggle toggle, DmodeCtrl.AnnounceFlagType type)
	{
	}

	protected override bool ExecCloseButtonPressed()
	{
		return default(bool);
	}

	protected override bool ExecRetryButtonPressed()
	{
		return default(bool);
	}

	protected override bool ExecRetireButtonPressed()
	{
		return default(bool);
	}

	public void OnClickCharaInfoButton()
	{
	}

	public void OnClickServitorInfoButton()
	{
	}

	public void OnClickAnnounceStar5(bool value)
	{
	}

	public void OnClickAnnounceStar4(bool value)
	{
	}

	public void OnClickAnnounceStar3(bool value)
	{
	}

	public void OnClickAnnounceSkill(bool value)
	{
	}
}
