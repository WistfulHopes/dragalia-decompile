using UnityEngine;

namespace Gluon;

public class ElementIconUISpriteRenderer : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer iconImage;

	[SerializeField]
	private Sprite[] elementSprites;

	private static int numElement;

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
