using SPFX;
using UnityEngine;

namespace Gluon;

[DisallowMultipleComponent]
public class CustomSPFXRadialBlurObject : MonoBehaviour
{
	public Vector3 BlurOffset;

	public float BlurDelay;

	public float BlurTime;

	public float BlurStrength;

	public float BlurPower;

	public float BlurAttenuation;

	public CustomSPFXBlurController.BlurSampleLabel BlurSample;

	public AnimationCurve BlurCurve;

	public bool IsBlurFollowGameObject;

	private SPFXInstanceBase SpfxComponent;

	private CustomSPFXBlurController[] BlurComponents;

	private float BlurDelayRest;

	private bool BlurCreated;

	private void Awake()
	{
	}

	private void RetargetBlurComponent()
	{
	}

	private void OnPlay(GameObject This)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void BlurInit()
	{
	}

	private void BlurExec()
	{
	}
}
