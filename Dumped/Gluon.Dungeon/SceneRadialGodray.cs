using System.Collections;
using SPFX;
using UnityEngine;

namespace Gluon.Dungeon;

public class SceneRadialGodray : MonoBehaviour
{
	[SerializeField]
	private float FadeStartRotationRateX;

	[SerializeField]
	private float FadeEndRotationRateX;

	[SerializeField]
	private float EffectMoveRateX;

	[SerializeField]
	private float EffectMoveRateZ;

	[SerializeField]
	private float EffectScreenOffsetX;

	[SerializeField]
	private float EffectScreenOffsetY;

	[SerializeField]
	private float EffectMoveXCorrectionByAspect;

	private const float BaseAspectRatio = 1.775f;

	private SPFXInstance effectInstanceObject;

	private void Start()
	{
	}

	private IEnumerator PlayEffectCoroutine()
	{
		return null;
	}

	private void Update()
	{
	}
}
