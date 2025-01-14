using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon;

public class UnitDetailInfoBaseCell : MonoBehaviour
{
	public UnityAction<int, int, int> iconCallBack;

	[SerializeField]
	public Graphic icon;

	public GameObject levelGO;

	public Text levelText;

	public Text nameText;

	[SerializeField]
	public GameObject lockedPanel;

	public GameObject normalPanel;

	public GameObject nonePanel;

	[SerializeField]
	public Graphic charaBG;

	public Graphic weaponBG;

	public Graphic dragonBG;

	public Graphic amuletBG;

	public Graphic unionBG;

	protected int dataId;

	protected int level;

	protected int maxLevel;

	protected bool isLockCell;

	public void Start()
	{
	}

	public virtual void IconPressed()
	{
	}

	public void SetBGImage(AbilityConst.UnitType giftType)
	{
	}
}
