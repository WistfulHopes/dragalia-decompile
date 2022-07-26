using UnityEngine;

namespace Gluon;

public class AnimationUIAutoSet : MonoBehaviour
{
	[SerializeField]
	public float enterScaleMin;

	public float enterScaleMax;

	public bool randomEnterScale;

	[SerializeField]
	public int enterDelayMin;

	public int enterDelayMax;

	[SerializeField]
	public int exitDelayMin;

	public int exitDelayMax;

	[SerializeField]
	public bool overrideOriginal;

	public GameObject[] objectsInSet;

	private AnimationUIAutoPublisher publisher;

	public void Preheat(AnimationUIAutoPublisher publisher)
	{
	}

	public void Publish(AnimationUIAutoPublisher publisher)
	{
	}

	public void PlayEnterAnimation()
	{
	}

	public void PlayExitAnimation()
	{
	}

	public void ClearPlayedState(bool enterState = false, bool exitState = false)
	{
	}

	public void CompleteRunningAnimation()
	{
	}
}
