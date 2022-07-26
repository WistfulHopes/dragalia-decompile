using UnityEngine;

namespace Gluon;

public class BaseCanvasParticleSettings : MonoBehaviour
{
	[SerializeField]
	public int particleNum;

	[SerializeField]
	public float rangeX;

	public float offsetX;

	[SerializeField]
	public float rangeY;

	public float offsetY;

	[SerializeField]
	public float moveSpeedRangeX;

	[SerializeField]
	public float moveSpeedBaseX;

	[SerializeField]
	public float moveSpeedRangeY;

	[SerializeField]
	public float moveSpeedBaseY;

	[SerializeField]
	public int lifeRange;

	[SerializeField]
	public int lifeBase;

	[SerializeField]
	public float fadeSpeed;

	[SerializeField]
	public int emissionIntervalMyPage;

	[SerializeField]
	public int initialNumberMyPage;

	[SerializeField]
	public Color particleColorMyPage;

	[SerializeField]
	public float alphaMyPage;

	[SerializeField]
	public float radiusRangeMyPage;

	[SerializeField]
	public float radiusBaseMyPage;

	[SerializeField]
	public int emissionIntervalCommon;

	[SerializeField]
	public int initialNumberCommon;

	[SerializeField]
	public Color particleColorCommon;

	[SerializeField]
	public float alphaCommon;

	[SerializeField]
	public float radiusRangeCommon;

	[SerializeField]
	public float radiusBaseCommon;
}
