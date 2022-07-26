using UnityEngine;

namespace Gluon;

public class SummonStageEffectLocation : SingletonMonoBehaviour<SummonStageEffectLocation>
{
	[SerializeField]
	public Transform[] locations;

	public Transform[] weapons;

	public Transform[] moons;

	public SummonStageShadowReceiver[] shadows;

	public SummonStageShadowReceiver aoShadows;

	public TweenSequenceVisualizer pillarMovement;

	public Animator statueAnimator;

	[SerializeField]
	public GameObject modelParent;

	public void ClearShadows()
	{
	}
}
