using UnityEngine;

namespace Gluon;

public class LocalizeTextLayoutAdjuster : MonoBehaviour
{
	public float en_us_add_X;

	public float en_us_add_Y;

	public float zh_cn_add_X;

	public float zh_cn_add_Y;

	public float zh_tw_add_X;

	public float zh_tw_add_Y;

	public bool manualSpacing;

	public float ja_jp_manual_lineSpacing;

	public float en_us_manual_lineSpacing;

	public float zh_cn_manual_lineSpacing;

	public float zh_tw_manual_lineSpacing;

	public const float ja_jp_lineSpacing = 0.6f;

	public const float en_us_lineSpacing = 1.05f;

	public const float zh_cn_lineSpacing = 1.05f;

	public const float zh_tw_lineSpacing = 1.25f;

	private const float en_us_default_X = 0f;

	private const float en_us_default_Y = -2f;

	private const float zh_cn_default_X = 0f;

	private const float zh_cn_default_Y = 0f;

	private const float zh_tw_default_X = 0f;

	private const float zh_tw_default_Y = 0f;

	private void Awake()
	{
	}
}
