using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class ElementIconUI : MonoBehaviour
{
	[SerializeField]
	private Image iconImage;

	[SerializeField]
	private Sprite[] elementSprites;

	private static int numElement;

	private VisibleUIObject visibleIcon;

	public void Initialize()
	{
	}

	private static int GetElementNum()
	{
		return default(int);
	}

	public void SetImage(ElementalType elm)
	{
	}

	public void Visible(bool b)
	{
	}
}
