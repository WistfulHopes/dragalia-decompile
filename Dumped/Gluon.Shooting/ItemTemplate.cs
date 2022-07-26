using UnityEngine;

namespace Gluon.Shooting;

public class ItemTemplate : MonoBehaviour
{
	[SerializeField]
	public SpriteRenderer image;

	public Transform tf;

	[SerializeField]
	public Sprite[] animationSpriteList;

	public int addScore;

	public int addHardScore;

	public int addPower;

	public int drainR;

	[SerializeField]
	public Sprite[] toScoreSprites;

	public Sprite[] toHardScoreSprites;

	[SerializeField]
	public Item.Phase entryPhase;

	public ItemManager.TemplateType type;
}
