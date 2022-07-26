using UnityEngine;

namespace Gluon;

public class FlashPlayerManager : MonoBehaviour
{
	[SerializeField]
	private int flashPlayingMax;

	private PoolableObject<FlashPlayer> flashPlayerPool;

	public FlashPlayer GetflashPlayer()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void InitFlashPlayerPool()
	{
	}

	private FlashPlayer GetFlashPlayerFromPool()
	{
		return null;
	}
}
