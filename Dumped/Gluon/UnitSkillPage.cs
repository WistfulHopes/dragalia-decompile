using UnityEngine;

namespace Gluon;

public class UnitSkillPage : MonoBehaviour
{
	[SerializeField]
	public UnitDetailSkillInfoCell[] skillCellList;

	[HideInInspector]
	public UnitDetailCanvas parentCanvas;

	private UnitDetailModel.UnitDetailType unitType;

	public void SetupSkillPage(UnitDetailModel.UnitDetailType type)
	{
	}

	private void SetSkillInfo()
	{
	}
}
