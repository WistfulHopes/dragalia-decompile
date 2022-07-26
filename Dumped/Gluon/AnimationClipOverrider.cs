using UnityEngine;

namespace Gluon;

public class AnimationClipOverrider : MonoBehaviour
{
	[SerializeField]
	private string[] clipNames;

	[SerializeField]
	private AnimationClip[] overrideClips;

	public void Override(Animator animator)
	{
	}
}
