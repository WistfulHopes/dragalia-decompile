using System.Collections.Generic;
using System.Threading.Tasks;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon;

public class ExcludeSummonConfirmPopup : PopupBase
{
	[SerializeField]
	private ExcludeSummonConfirmCtrl excludeSummonConfirmCtrl;

	[SerializeField]
	private Text beforeStoneNum;

	[SerializeField]
	private Text afterStoneNum;

	[SerializeField]
	private Text okButtonText;

	[SerializeField]
	private Button okButton;

	[SerializeField]
	private GameObject endDateTimeLine;

	[SerializeField]
	private Text endDateTimeText;

	[SerializeField]
	private GameObject specifiedCommercialActObj;

	[SerializeField]
	private Text specifiedCommercialTransactionActText;

	[SerializeField]
	private Text specifiedCommercialActInformationText;

	[SerializeField]
	private RectTransform frame;

	[SerializeField]
	private RectTransform info;

	[SerializeField]
	private RectTransform cellList;

	[SerializeField]
	private RectTransform buttons;

	private int summonId;

	private GiftType type;

	private List<ExcludeSummonCellData> excludeSummonCellDataList;

	private List<int> entityList;

	private SummonTopItemData summonTopItemData;

	private UnityAction onSummonRequest;

	public static ExcludeSummonConfirmPopup Create(SummonTopItemData itemData, List<ExcludeSummonCellData> list, UnityAction onSummonRequest)
	{
		return null;
	}

	protected override void Start()
	{
	}

	private Task<SummonExcludeGetOddsDataResponse> RequestSummonExcludeGetOddsData()
	{
		return null;
	}

	public void OnOddsButton()
	{
	}

	public void OnSummonButton()
	{
	}

	public void StoneUpdate()
	{
	}

	public void RequestSummonExcludeRequest()
	{
	}

	private int[] GetExcludeEntityList()
	{
		return null;
	}

	public void OnSpecifiedCommercialTransactionActPressed()
	{
	}
}
