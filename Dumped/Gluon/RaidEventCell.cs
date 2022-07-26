using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class RaidEventCell : QuestCellBase
{
	public enum RaidUltimateStatus
	{
		Locked,
		OneKeyObtained,
		TwoKeyObtained,
		Unlocked
	}

	[SerializeField]
	private Image banner;

	[SerializeField]
	private GameObject entryConditionNode;

	[SerializeField]
	private Text entryConditionText;

	[SerializeField]
	private GameObject timeLockNode;

	[SerializeField]
	private Text releaseTimeText;

	[SerializeField]
	private GameObject questNameNode;

	[SerializeField]
	private Text questNameText;

	[SerializeField]
	private Button baseButton;

	[SerializeField]
	protected GameObject newIconRoot;

	[SerializeField]
	protected GameObject newGlowRoot;

	[SerializeField]
	protected RectTransform animationCellTrans;

	[SerializeField]
	public GameObject ultimateLockGO;

	public Transform ultimateFlashNode;

	public GameObject ultimateUnlockTextNode;

	[SerializeField]
	public float readyStateWait;

	public float fullUnlockWait;

	public float ultimateUnlockInterval;

	public float ultimateSyncLoopWait;

	protected int questSubType;

	protected List<QuestEventMenuElement> cellData;

	private QuestUtil.QuestState state;

	private Coroutine flashCoroutine;

	private TouchGuardObject touchGuardObj;

	private FlRoot root;

	private const string ultimateUnlockFlashPath = "Prefabs/OutGame/EventQuest/Flash/RaidUltimate/pf_RaidUltimateBannerLock";

	private const string prefsUltimateStatusTemplate = "RaidUltimateStatus_{0}";

	public EventListCtrl eventListCtrl
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

	private void OnEnable()
	{
	}

	private void UpdateContent()
	{
	}

	public void SetContent(int questSubType, List<QuestEventMenuElement> cellData, QuestUtil.QuestState questState, bool showStateIcon = true)
	{
	}

	public static void GetUltimateUnlockStatus(int eventId, out RaidUltimateStatus recordedStatus, out RaidUltimateStatus currentStatus)
	{
	}

	private void RecordUltimateUnlockStatus(int eventId, RaidUltimateStatus currentStatus)
	{
	}

	private void OnDestroy()
	{
	}

	private IEnumerator ExecuteUltimateUnlockFlash(FlRoot root, RaidUltimateStatus recordedStatus, RaidUltimateStatus currentStatus)
	{
		return null;
	}

	public void OnClick()
	{
	}

	public override bool SetGradientShader()
	{
		return default(bool);
	}

	public override void SetStateIcons()
	{
	}
}
