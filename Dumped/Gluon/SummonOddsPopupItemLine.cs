using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class SummonOddsPopupItemLine : MonoBehaviour
{
	[SerializeField]
	public Image elementalIcon;

	public Image weaponTypeIcon;

	[SerializeField]
	public GameObject elementalTypeGO;

	public GameObject weaponTypeGO;

	public GameObject pickupGO;

	[SerializeField]
	public Text itemName;

	public Text percentage;

	[SerializeField]
	public GameObject captionNode;

	public GameObject normalNode;

	public Text captionText;

	public const float captionHeight = 48f;

	public const float normalHeight = 32f;

	private static GameObject prefab;

	public static GameObject LoadPrefab()
	{
		return null;
	}

	public static void ReleasePrefab()
	{
	}

	public void SetupByData(SummonOddsTableViewData data)
	{
	}
}
