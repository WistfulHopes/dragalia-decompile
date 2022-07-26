using Gluon.Event;
using UnityEngine;

namespace Gluon;

public class BRItemPopPoint : MonoBehaviour
{
	[SerializeField]
	private int groupId;

	public BattleRoyalDungeonItemSet itemSet;

	public BattleRoyalDungeonItem poppedItem;

	private int pointId;

	public int GroupId => default(int);

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void PopItem()
	{
	}

	public static BattleRoyalDungeonItem PopItem(BattleRoyalDungeonItemSet itemSet, BRItemId id, Vector3 pos, bool isSync)
	{
		return default(BattleRoyalDungeonItem);
	}
}
