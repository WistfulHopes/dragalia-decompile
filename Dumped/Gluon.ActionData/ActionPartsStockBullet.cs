using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsStockBullet : ActionParts
{
	[SerializeField]
	private StockBulletData _data;

	public override PartsData data => null;
}
