using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class DmodeUnitItemDetailInfoCell : MonoBehaviour
{
	[SerializeField]
	protected DmodeCommonInGameIcon icon;

	[SerializeField]
	protected Text nameText;

	[SerializeField]
	protected Text hpText;

	[SerializeField]
	protected Text attackText;

	[SerializeField]
	protected DmodeItemDetailInfoBaseCell cell;

	[SerializeField]
	protected DmodeItemDetailInfoBaseCell skillCell;

	public void Setup(DmodeDungeonItemType type, int itemId, ElementalType elementalType, [Optional] DmodeDungeonItem item)
	{
	}

	public void Setup(int id, ElementalType elementalType)
	{
	}
}
