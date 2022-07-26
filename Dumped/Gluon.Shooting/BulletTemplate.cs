using UnityEngine;

namespace Gluon.Shooting;

public class BulletTemplate : MonoBehaviour
{
	[SerializeField]
	public SpriteRenderer image;

	public Transform tf;

	[SerializeField]
	public Sprite fadeOutSprite;

	[SerializeField]
	public Sprite[] spriteAnims;

	[SerializeField]
	public float rMain;

	public float rSub;

	public int renderDepth;

	public BulletManager.TemplateType type;

	public BaseObject.CollisionType collisionType;
}
