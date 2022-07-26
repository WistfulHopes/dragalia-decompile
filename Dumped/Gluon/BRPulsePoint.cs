using UnityEngine;

namespace Gluon;

public class BRPulsePoint : MonoBehaviour
{
	[SerializeField]
	private BRPulse pulse;

	[SerializeField]
	public float radius;

	[SerializeField]
	private DungeonManager.eStageDifficulty stageDifficulty;

	public DungeonManager.eStageDifficulty StageDifficulty => default(DungeonManager.eStageDifficulty);

	private void Awake()
	{
	}
}
